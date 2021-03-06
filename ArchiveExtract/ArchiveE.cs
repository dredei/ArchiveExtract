﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using SharpCompress.Archive;
using SharpCompress.Common;
using SharpCompress.Reader;

namespace ArchiveExtract
{
    public class UpdEventExtractArgs : EventArgs
    {
        public int progress { get; set; }
        public int maxProgress { get; set; }
        public int archiveProgress { get; set; }
        public int archiveMaxProgress { get; set; }
        public int index { get; set; }
        public bool success { get; set; }
        public Color color { get; set; } // Красный - невозможно распаковать, оранжевый - невозможно удалить
    }

    class ArchiveE
    {
        string[] paths;
        bool zip;
        bool rar;
        bool sevenZ;
        bool remove;
        List<string> files;
        List<string> orangeFiles;
        public event EventHandler<UpdEventExtractArgs> updEventExtract = delegate { };

        public ArchiveE( string[] paths, bool zip, bool rar, bool sevenZ, bool remove )
        {
            this.paths = paths;
            this.zip = zip;
            this.rar = rar;
            this.sevenZ = sevenZ;
            this.remove = remove;
            files = new List<string>();
            orangeFiles = new List<string>();
        }

        public List<string> getFiles()
        {
            return files;
        }

        public List<string> getOrangeFiles()
        {
            return orangeFiles;
        }

        public void setRemove( bool remove )
        {
            this.remove = remove;
        }

        public void removeFile( int index )
        {
            files.RemoveRange( index, 1 );
        }

        public void searchFiles()
        {
            if ( zip )
            {
                files.AddRange( searchFilesByExtension( "*.zip" ) );
            }
            if ( rar )
            {
                files.AddRange( searchFilesByExtension( "*.rar" ) );
            }
            if ( sevenZ )
            {
                files.AddRange( searchFilesByExtension( "*.7z" ) );
            }
        }

        public List<string> searchFilesByExtension( string extension )
        {
            List<string> files = new List<string>();
            for ( int i = 0; i < this.paths.Length; i++ )
            {
                string path = paths[ i ];
                if ( Directory.Exists( path ) )
                {
                    files.AddRange( Directory.GetFiles( path, extension, SearchOption.AllDirectories ).ToList<string>() );
                }
            }
            return files;
        }

        public void removeOrangeFiles()
        {
            for ( int i = 0; i < orangeFiles.Count; i++ )
            {
                string file = orangeFiles[ i ];
                File.SetAttributes( file, FileAttributes.Normal );
                File.Delete( file );
            }
            orangeFiles.Clear();
        }

        public void extractFiles()
        {
            UpdEventExtractArgs args = new UpdEventExtractArgs();
            orangeFiles.Clear();
            args.progress = 0;
            args.maxProgress = files.Count;
            updEventExtract( this, args );
            for ( int i = 0; i < files.Count; i++ )
            {
                args.color = Color.Yellow;
                args.index = i;
                updEventExtract( this, args );
                string file = files[ i ];
                try
                {
                    var archive = ArchiveFactory.Open( file );
                    if ( archive.IsSolid )
                    {
                        args.archiveProgress = 0;
                        args.archiveMaxProgress = 1;
                        updEventExtract( this, args );
                        using ( Stream stream = File.OpenRead( file ) )
                        {
                            var reader = ReaderFactory.Open( stream );
                            while ( reader.MoveToNextEntry() )
                            {
                                if ( !reader.Entry.IsDirectory )
                                {
                                    reader.WriteEntryToDirectory( Path.GetDirectoryName( file ) + @"\" + Path.GetFileNameWithoutExtension( file ), ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite );
                                }
                            }
                        }
                    }
                    else
                    {
                        args.archiveProgress = 0;
                        args.archiveMaxProgress = archive.Entries.Count();
                        updEventExtract( this, args );
                        foreach ( var entry in archive.Entries )
                        {
                            if ( !entry.IsDirectory )
                            {
                                entry.WriteToDirectory( Path.GetDirectoryName( file ) + @"\" + Path.GetFileNameWithoutExtension( file ), ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite );
                            }
                            args.archiveProgress++;
                            updEventExtract( this, args );
                        }
                    }
                    archive.Dispose();
                    args.color = Color.Green;
                }
                catch
                {
                    args.color = Color.Red;
                }
                finally
                {
                    if ( this.remove && args.color != Color.Red )
                    {
                        try
                        {
                            File.Delete( file );
                        }
                        catch
                        {
                            args.color = Color.Orange;
                            orangeFiles.Add( file );
                        }
                    }
                    args.progress++;
                    updEventExtract( this, args );
                }
            }
        }
    }
}
