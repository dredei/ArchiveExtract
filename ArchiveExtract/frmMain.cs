using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtensionMethods;
using Ini;
using Windows7.DesktopIntegration.WindowsForms;

namespace ArchiveExtract
{
    public partial class frmMain : Form
    {
        ArchiveE ae = null;
        Thread thr = null;
        SaveHistory history;

        public frmMain()
        {
            InitializeComponent();
        }

        public long getFileSize( string file )
        {
            FileInfo fi = new FileInfo( file );
            return fi.Length;
        }

        private void saveSettings()
        {
            IniFile ini = new IniFile( Application.StartupPath + @"\Settings.ini" );
            ini.Write( "rar", cbRar.Checked.ToString(), "Options" );
            ini.Write( "zip", cbZip.Checked.ToString(), "Options" );
            ini.Write( "7z", cbSevenZ.Checked.ToString(), "Options" );
            ini.Write( "Remove", cbRemove.Checked.ToString(), "Options" );
        }

        private void loadSettings()
        {
            IniFile ini = new IniFile( Application.StartupPath + @"\Settings.ini" );
            cbRar.Checked = bool.Parse( ini.Read( "rar", "Options", cbRar.Checked.ToString() ) );
            cbZip.Checked = bool.Parse( ini.Read( "zip", "Options", cbZip.Checked.ToString() ) );
            cbSevenZ.Checked = bool.Parse( ini.Read( "7z", "Options", cbSevenZ.Checked.ToString() ) );
            cbRemove.Checked = bool.Parse( ini.Read( "Remove", "Options", cbRemove.Checked.ToString() ) );
        }

        private void updProgress( object sender, UpdEventExtractArgs e )
        {
            pbAll.Maximum = e.maxProgress;
            pbAll.Value = e.progress;
            pbArchive.Maximum = e.archiveMaxProgress;
            pbArchive.Value = e.archiveProgress;
            lvFiles.Items[ e.index ].BackColor = e.color;
            lvFiles.Items[ e.index ].EnsureVisible();
            pbAll.SetTaskbarProgress();
        }

        private void workExtract()
        {
            ae.extractFiles();
            pbArchive.Style = ProgressBarStyle.Blocks;
            pbArchive.MarqueeAnimationSpeed = 0;
            MessageBox.Show( "Завершено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information );
            int orangeFilesCount = ( ae.getOrangeFiles() ).Count;
            if ( orangeFilesCount > 0 )
            {
                const string text = "Найдено {0} \"оранжевых\" файлов.\nУдалить их?";
                DialogResult res = MessageBox.Show( String.Format( text, orangeFilesCount ), "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if ( res == DialogResult.Yes )
                {
                    btnRemOrange_Click( btnRemOrange, new EventArgs() );
                }
            }
            enableObjs();
        }

        private void getPaths()
        {
            lbPaths.Items.Clear();
            lbPaths.Items.AddRange( this.history.getPaths() );
        }

        private void fillLv()
        {
            if ( ae == null )
            {
                return;
            }
            lvFiles.Items.Clear();
            List<string> files = ae.getFiles();
            for ( int i = 0; i < files.Count; i++ )
            {
                string file = files[ i ];
                ListViewItem li = new ListViewItem();
                li.Text = Path.GetFileName( file );
                li.SubItems.Add( ExMethods.getSizeReadable( getFileSize( file ) ) );
                li.BackColor = Color.White;
                lvFiles.Items.Add( li );
                lvFiles.Items[ lvFiles.Items.Count - 1 ].EnsureVisible();
            }
            lvFiles.Sort();
        }

        private void btnSearch_Click( object sender, EventArgs e )
        {
            if ( lbPaths.Items.Count == 0 )
            {
                MessageBox.Show( "Список папок пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            enableObjs();
            bool zip = cbZip.Checked;
            bool rar = cbRar.Checked;
            bool sevenZ = cbSevenZ.Checked;
            bool remove = cbRemove.Checked;
            ae = new ArchiveE( lbPaths.Items.Cast<string>().ToArray(), zip, rar, sevenZ, remove );
            ae.searchFiles();
            fillLv();
            enableObjs();
        }

        private void enableObjs()
        {
            cbRar.Enabled = !cbRar.Enabled;
            cbRemove.Enabled = !cbRemove.Enabled;
            cbZip.Enabled = !cbZip.Enabled;
            cbSevenZ.Enabled = !cbSevenZ.Enabled;
            btnExtract.Enabled = !btnExtract.Enabled;
            btnSearch.Enabled = !btnSearch.Enabled;
            btnRemOrange.Enabled = !btnRemOrange.Enabled;
            lbPaths.Enabled = !lbPaths.Enabled;
        }

        private void btnExtract_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < lvFiles.Items.Count; i++ )
            {
                lvFiles.Items[ i ].BackColor = Color.White;
            }
            if ( ae == null )
            {
                return;
            }
            enableObjs();
            ae.setRemove( cbRemove.Checked );
            ae.updEventExtract += new EventHandler<UpdEventExtractArgs>( updProgress );
            thr = new Thread( workExtract );
            thr.Start();
        }

        private void frmMain_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.history.saveHistory();
            this.saveSettings();
            if ( thr != null )
            {
                thr.Abort();
            }
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.history = new SaveHistory();
            this.getPaths();
            this.loadSettings();
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            Process.Start( @"http://softez.pp.ua/" );
        }

        private void btnRemOrange_Click( object sender, EventArgs e )
        {
            if ( ae != null )
            {
                ae.removeOrangeFiles();
                MessageBox.Show( "Удалено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void toolStripMenuItem1_Click( object sender, EventArgs e )
        {
            if ( ae == null || lvFiles.SelectedItems.Count == 0 )
            {
                return;
            }
            for ( int i = 0; i < lvFiles.SelectedItems.Count; i++ )
            {
                ae.removeFile( lvFiles.SelectedItems[ i ].Index );
                this.fillLv();
            }
        }

        private void добавитьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( fbd1.ShowDialog() == DialogResult.OK )
            {
                string path = fbd1.SelectedPath;
                this.history.addPath( path );
                this.getPaths();
            }
        }

        private void удалитьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( lbPaths.SelectedIndex < 0 )
            {
                return;
            }
            int index = lbPaths.SelectedIndex;
            this.history.deletePath( index );
            this.getPaths();
        }

        private void очиститьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            const string clearPaths = "Вы действительно хотите очистить список папок для сканирования?";
            DialogResult res = MessageBox.Show( clearPaths, "Очистка директорий", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
            if ( res == DialogResult.Yes )
            {
                this.history.clearPaths();
                this.getPaths();
            }
        }
    }
}
