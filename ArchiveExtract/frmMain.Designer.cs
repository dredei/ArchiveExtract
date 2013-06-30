namespace ArchiveExtract
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAll = new System.Windows.Forms.ProgressBar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.cbRemove = new System.Windows.Forms.CheckBox();
            this.cbZip = new System.Windows.Forms.CheckBox();
            this.cbRar = new System.Windows.Forms.CheckBox();
            this.pbArchive = new System.Windows.Forms.ProgressBar();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRemOrange = new System.Windows.Forms.Button();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.cms2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSevenZ = new System.Windows.Forms.CheckBox();
            this.cms1.SuspendLayout();
            this.cms2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Папки для сканирования:";
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFiles.ContextMenuStrip = this.cms1;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.Location = new System.Drawing.Point(3, 104);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(273, 139);
            this.lvFiles.TabIndex = 2;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            this.columnHeader2.Width = 70;
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(121, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "Удалить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pbAll
            // 
            this.pbAll.Location = new System.Drawing.Point(3, 316);
            this.pbAll.Name = "pbAll";
            this.pbAll.Size = new System.Drawing.Size(273, 15);
            this.pbAll.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(3, 337);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(273, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtract.Location = new System.Drawing.Point(3, 366);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(273, 23);
            this.btnExtract.TabIndex = 7;
            this.btnExtract.Text = "Распаковать";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // cbRemove
            // 
            this.cbRemove.AutoSize = true;
            this.cbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRemove.Location = new System.Drawing.Point(3, 249);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(197, 17);
            this.cbRemove.TabIndex = 8;
            this.cbRemove.Text = "Удалять архив после распаковки";
            this.cbRemove.UseVisualStyleBackColor = true;
            // 
            // cbZip
            // 
            this.cbZip.AutoSize = true;
            this.cbZip.Checked = true;
            this.cbZip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbZip.Location = new System.Drawing.Point(3, 272);
            this.cbZip.Name = "cbZip";
            this.cbZip.Size = new System.Drawing.Size(43, 17);
            this.cbZip.TabIndex = 9;
            this.cbZip.Text = "ZIP";
            this.cbZip.UseVisualStyleBackColor = true;
            // 
            // cbRar
            // 
            this.cbRar.AutoSize = true;
            this.cbRar.Checked = true;
            this.cbRar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRar.Location = new System.Drawing.Point(52, 272);
            this.cbRar.Name = "cbRar";
            this.cbRar.Size = new System.Drawing.Size(49, 17);
            this.cbRar.TabIndex = 10;
            this.cbRar.Text = "RAR";
            this.cbRar.UseVisualStyleBackColor = true;
            // 
            // pbArchive
            // 
            this.pbArchive.Location = new System.Drawing.Point(3, 295);
            this.pbArchive.Name = "pbArchive";
            this.pbArchive.Size = new System.Drawing.Size(273, 15);
            this.pbArchive.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(247, 421);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Site";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRemOrange
            // 
            this.btnRemOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemOrange.Location = new System.Drawing.Point(3, 395);
            this.btnRemOrange.Name = "btnRemOrange";
            this.btnRemOrange.Size = new System.Drawing.Size(273, 23);
            this.btnRemOrange.TabIndex = 13;
            this.btnRemOrange.Text = "Удалить \"оранжевые\" архивы";
            this.btnRemOrange.UseVisualStyleBackColor = true;
            this.btnRemOrange.Click += new System.EventHandler(this.btnRemOrange_Click);
            // 
            // lbPaths
            // 
            this.lbPaths.ContextMenuStrip = this.cms2;
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.Location = new System.Drawing.Point(3, 16);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(273, 82);
            this.lbPaths.TabIndex = 14;
            // 
            // cms2
            // 
            this.cms2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.очиститьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.cms2.Name = "contextMenuStrip1";
            this.cms2.Size = new System.Drawing.Size(172, 76);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить список";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // cbSevenZ
            // 
            this.cbSevenZ.AutoSize = true;
            this.cbSevenZ.Checked = true;
            this.cbSevenZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSevenZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSevenZ.Location = new System.Drawing.Point(107, 272);
            this.cbSevenZ.Name = "cbSevenZ";
            this.cbSevenZ.Size = new System.Drawing.Size(37, 17);
            this.cbSevenZ.TabIndex = 15;
            this.cbSevenZ.Text = "7z";
            this.cbSevenZ.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(279, 437);
            this.Controls.Add(this.cbSevenZ);
            this.Controls.Add(this.lbPaths);
            this.Controls.Add(this.btnRemOrange);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbRar);
            this.Controls.Add(this.cbZip);
            this.Controls.Add(this.cbRemove);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pbAll);
            this.Controls.Add(this.pbArchive);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchiveExtract";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cms1.ResumeLayout(false);
            this.cms2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ProgressBar pbAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.CheckBox cbRemove;
        private System.Windows.Forms.CheckBox cbZip;
        private System.Windows.Forms.CheckBox cbRar;
        private System.Windows.Forms.ProgressBar pbArchive;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnRemOrange;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.ContextMenuStrip cms2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbSevenZ;
    }
}

