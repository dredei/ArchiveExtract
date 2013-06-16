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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectDir = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь для сканирования:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(3, 16);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(235, 20);
            this.tbPath.TabIndex = 1;
            this.tbPath.Text = "D:\\Arch";
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.Location = new System.Drawing.Point(3, 42);
            this.lvFiles.MultiSelect = false;
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
            // btnSelectDir
            // 
            this.btnSelectDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDir.Location = new System.Drawing.Point(244, 14);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(32, 23);
            this.btnSelectDir.TabIndex = 3;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // pbAll
            // 
            this.pbAll.Location = new System.Drawing.Point(3, 252);
            this.pbAll.Name = "pbAll";
            this.pbAll.Size = new System.Drawing.Size(273, 15);
            this.pbAll.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(3, 273);
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
            this.btnExtract.Location = new System.Drawing.Point(3, 302);
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
            this.cbRemove.Location = new System.Drawing.Point(3, 185);
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
            this.cbZip.Location = new System.Drawing.Point(3, 208);
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
            this.cbRar.Location = new System.Drawing.Point(52, 208);
            this.cbRar.Name = "cbRar";
            this.cbRar.Size = new System.Drawing.Size(49, 17);
            this.cbRar.TabIndex = 10;
            this.cbRar.Text = "RAR";
            this.cbRar.UseVisualStyleBackColor = true;
            // 
            // pbArchive
            // 
            this.pbArchive.Location = new System.Drawing.Point(3, 231);
            this.pbArchive.Name = "pbArchive";
            this.pbArchive.Size = new System.Drawing.Size(273, 15);
            this.pbArchive.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(247, 186);
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
            this.btnRemOrange.Location = new System.Drawing.Point(3, 331);
            this.btnRemOrange.Name = "btnRemOrange";
            this.btnRemOrange.Size = new System.Drawing.Size(273, 23);
            this.btnRemOrange.TabIndex = 13;
            this.btnRemOrange.Text = "Удалить оранжевые файлы";
            this.btnRemOrange.UseVisualStyleBackColor = true;
            this.btnRemOrange.Click += new System.EventHandler(this.btnRemOrange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(279, 355);
            this.Controls.Add(this.btnRemOrange);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbRar);
            this.Controls.Add(this.cbZip);
            this.Controls.Add(this.cbRemove);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pbAll);
            this.Controls.Add(this.pbArchive);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchiveExtract";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSelectDir;
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
    }
}

