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

namespace ArchiveExtract
{
    public partial class frmMain : Form
    {
        ArchiveE ae = null;
        Thread thr = null;

        public frmMain()
        {
            InitializeComponent();
        }

        public long getFileSize( string file )
        {
            FileInfo fi = new FileInfo( file );
            return fi.Length;
        }

        private string hSize( long sizeB )
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while ( sizeB >= 1024 && order + 1 < sizes.Length )
            {
                order++;
                sizeB = sizeB / 1024;
            }
            string result = String.Format( "{0:0.##} {1}", sizeB, sizes[ order ] );
            return result;
        }

        private void updProgress( object sender, UpdEventExtractArgs e )
        {
            pbAll.Maximum = e.maxProgress;
            pbAll.Value = e.progress;
            pbArchive.Maximum = e.archiveMaxProgress;
            pbArchive.Value = e.archiveProgress;
            lvFiles.Items[ e.index ].BackColor = e.color;
            lvFiles.Items[ e.index ].EnsureVisible();
            if ( e.marquee )
            {
                pbArchive.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                pbArchive.Style = ProgressBarStyle.Blocks;
            }
        }

        private void workExtract()
        {
            ae.extractFiles();
            MessageBox.Show( "Завершено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information );
            enableObjs();
        }

        private void btnSearch_Click( object sender, EventArgs e )
        {
            enableObjs();
            lvFiles.Items.Clear();
            ae = new ArchiveE( tbPath.Text, cbZip.Checked, cbRar.Checked, cbRemove.Checked );
            ae.searchFiles();
            List<string> files = ae.getFiles();
            for ( int i = 0; i < files.Count; i++ )
            {
                string file = files[ i ];
                ListViewItem li = new ListViewItem();
                li.Text = Path.GetFileName( file );
                li.SubItems.Add( hSize( getFileSize( file ) ).ToString() );
                li.BackColor = Color.White;
                lvFiles.Items.Add( li );
                lvFiles.Items[ lvFiles.Items.Count - 1 ].EnsureVisible();
            }
            lvFiles.Sort();
            enableObjs();
        }

        private void enableObjs()
        {
            tbPath.Enabled = !tbPath.Enabled;
            cbRar.Enabled = !cbRar.Enabled;
            cbRemove.Enabled = !cbRemove.Enabled;
            cbZip.Enabled = !cbZip.Enabled;
            btnExtract.Enabled = !btnExtract.Enabled;
            btnSearch.Enabled = !btnSearch.Enabled;
            btnSelectDir.Enabled = !btnSelectDir.Enabled;
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
            ae.updEventExtract += new EventHandler<UpdEventExtractArgs>( updProgress );
            thr = new Thread( workExtract );
            thr.Start();
        }

        private void frmMain_FormClosing( object sender, FormClosingEventArgs e )
        {
            if ( thr != null )
            {
                thr.Abort();
            }
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSelectDir_Click( object sender, EventArgs e )
        {
            fbd1.SelectedPath = tbPath.Text;
            if ( fbd1.ShowDialog() == DialogResult.OK )
            {
                tbPath.Text = fbd1.SelectedPath;
            }
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            Process.Start( @"http://softez.pp.ua/" );
        }
    }
}
