using System;
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
        public bool marquee { get; set; }
        public Color color { get; set; }
    }

    class ArchiveE
    {
        string path;
        bool zip;
        bool rar;
        bool remove;
        List<string> files;
        public event EventHandler<UpdEventExtractArgs> updEventExtract = delegate { };

        public ArchiveE( string path, bool zip, bool rar, bool remove )
        {
            this.path = path;
            this.zip = zip;
            this.rar = rar;
            this.remove = remove;
            files = new List<string>();
        }

        public List<string> getFiles()
        {
            return files;
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
        }

        public List<string> searchFilesByExtension( string extension )
        {
            string[] files = Directory.GetFiles( path, extension, SearchOption.AllDirectories );
            return files.ToList<string>();
        }

        public void extractFiles()
        {
            UpdEventExtractArgs args = new UpdEventExtractArgs();
            string folder = path + @"\";
            Color color = Color.Yellow;
            args.progress = 0;
            args.maxProgress = files.Count;
            updEventExtract( this, args );
            for ( int i = 0; i < files.Count; i++ )
            {
                args.color = Color.Yellow;
                args.index = i;
                args.marquee = false;
                updEventExtract( this, args );
                string file = files[ i ];
                try
                {
                    var archive = ArchiveFactory.Open( file );
                    if ( archive.IsSolid )
                    {
                        args.archiveProgress = 0;
                        args.archiveMaxProgress = 1;
                        args.marquee = true;
                        updEventExtract( this, args );
                        using ( Stream stream = File.OpenRead( file ) )
                        {
                            var reader = ReaderFactory.Open( stream );
                            while ( reader.MoveToNextEntry() )
                            {
                                if ( !reader.Entry.IsDirectory )
                                {
                                    reader.WriteEntryToDirectory( folder + Path.GetFileNameWithoutExtension( file ), ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite );
                                }
                            }
                        }
                    }
                    else
                    {
                        args.marquee = false;
                        args.archiveProgress = 0;
                        args.archiveMaxProgress = archive.Entries.Count();
                        updEventExtract( this, args );
                        foreach ( var entry in archive.Entries )
                        {
                            if ( !entry.IsDirectory )
                            {
                                entry.WriteToDirectory( folder + Path.GetFileNameWithoutExtension( file ), ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite );
                            }
                            args.archiveProgress++;
                            updEventExtract( this, args );
                        }
                    }
                    args.color = Color.Green;
                }
                catch
                {
                    args.color = Color.Red;
                }
                finally
                {
                    args.progress++;
                    updEventExtract( this, args );
                }
            }
        }
    }
}
