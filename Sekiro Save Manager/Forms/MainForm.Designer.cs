namespace Sekiro_Save_Manager.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lvBackups = new System.Windows.Forms.ListView();
            this.colComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProfileLocation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutoBackupLocation = new System.Windows.Forms.Button();
            this.numBackupInterval = new System.Windows.Forms.NumericUpDown();
            this.txtAutoBackupLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRestore = new System.Windows.Forms.Button();
            this.chkHideRestoreWarning = new System.Windows.Forms.CheckBox();
            this.chkTrayMinimize = new System.Windows.Forms.CheckBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackupInterval)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackup.Enabled = false;
            this.btnBackup.Location = new System.Drawing.Point(6, 284);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup...";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lvBackups
            // 
            this.lvBackups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComment,
            this.colDate,
            this.colLocation,
            this.colSource});
            this.lvBackups.FullRowSelect = true;
            this.lvBackups.Location = new System.Drawing.Point(3, 3);
            this.lvBackups.Name = "lvBackups";
            this.lvBackups.Size = new System.Drawing.Size(676, 239);
            this.lvBackups.TabIndex = 1;
            this.lvBackups.UseCompatibleStateImageBehavior = false;
            this.lvBackups.View = System.Windows.Forms.View.Details;
            this.lvBackups.SelectedIndexChanged += new System.EventHandler(this.lvBackups_SelectedIndexChanged);
            // 
            // colComment
            // 
            this.colComment.Text = "Comment";
            this.colComment.Width = 153;
            // 
            // colDate
            // 
            this.colDate.Text = "Backup Date";
            this.colDate.Width = 120;
            // 
            // colLocation
            // 
            this.colLocation.Text = "Location";
            this.colLocation.Width = 180;
            // 
            // colSource
            // 
            this.colSource.Text = "Source Location";
            this.colSource.Width = 212;
            // 
            // btnProfileLocation
            // 
            this.btnProfileLocation.Location = new System.Drawing.Point(498, 34);
            this.btnProfileLocation.Name = "btnProfileLocation";
            this.btnProfileLocation.Size = new System.Drawing.Size(75, 23);
            this.btnProfileLocation.TabIndex = 3;
            this.btnProfileLocation.Text = "Browse...";
            this.btnProfileLocation.UseVisualStyleBackColor = true;
            this.btnProfileLocation.Click += new System.EventHandler(this.btnProfileLocation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game Profile Directory:";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(9, 37);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(483, 20);
            this.txtSaveLocation.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 339);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lvBackups);
            this.tabPage1.Controls.Add(this.btnRestore);
            this.tabPage1.Controls.Add(this.btnBackup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backups";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(676, 278);
            this.txtLog.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkTrayMinimize);
            this.tabPage3.Controls.Add(this.chkHideRestoreWarning);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnProfileLocation);
            this.tabPage3.Controls.Add(this.txtSaveLocation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(682, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAutoBackupLocation);
            this.groupBox1.Controls.Add(this.numBackupInterval);
            this.groupBox1.Controls.Add(this.txtAutoBackupLocation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkAutoBackup);
            this.groupBox1.Location = new System.Drawing.Point(9, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incremental Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Automatic Backup Directory";
            // 
            // btnAutoBackupLocation
            // 
            this.btnAutoBackupLocation.Location = new System.Drawing.Point(495, 99);
            this.btnAutoBackupLocation.Name = "btnAutoBackupLocation";
            this.btnAutoBackupLocation.Size = new System.Drawing.Size(75, 23);
            this.btnAutoBackupLocation.TabIndex = 7;
            this.btnAutoBackupLocation.Text = "Browse...";
            this.btnAutoBackupLocation.UseVisualStyleBackColor = true;
            this.btnAutoBackupLocation.Click += new System.EventHandler(this.btnAutoBackupLocation_Click);
            // 
            // numBackupInterval
            // 
            this.numBackupInterval.Location = new System.Drawing.Point(142, 51);
            this.numBackupInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numBackupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBackupInterval.Name = "numBackupInterval";
            this.numBackupInterval.Size = new System.Drawing.Size(88, 20);
            this.numBackupInterval.TabIndex = 6;
            this.numBackupInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBackupInterval.ValueChanged += new System.EventHandler(this.numBackupInterval_ValueChanged);
            // 
            // txtAutoBackupLocation
            // 
            this.txtAutoBackupLocation.Location = new System.Drawing.Point(6, 102);
            this.txtAutoBackupLocation.Name = "txtAutoBackupLocation";
            this.txtAutoBackupLocation.ReadOnly = true;
            this.txtAutoBackupLocation.Size = new System.Drawing.Size(483, 20);
            this.txtAutoBackupLocation.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Backup interval (minutes): ";
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Location = new System.Drawing.Point(7, 20);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(160, 17);
            this.chkAutoBackup.TabIndex = 0;
            this.chkAutoBackup.Text = "Enable incremental backups";
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            this.chkAutoBackup.CheckedChanged += new System.EventHandler(this.chkAutoBackup_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BackupTimer
            // 
            this.BackupTimer.Interval = 600000;
            this.BackupTimer.Tick += new System.EventHandler(this.BackupTimer_Tick);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(87, 284);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore...";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // chkHideRestoreWarning
            // 
            this.chkHideRestoreWarning.AutoSize = true;
            this.chkHideRestoreWarning.Location = new System.Drawing.Point(9, 66);
            this.chkHideRestoreWarning.Name = "chkHideRestoreWarning";
            this.chkHideRestoreWarning.Size = new System.Drawing.Size(204, 17);
            this.chkHideRestoreWarning.TabIndex = 9;
            this.chkHideRestoreWarning.Text = "Hide warning when restoring backups";
            this.chkHideRestoreWarning.UseVisualStyleBackColor = true;
            this.chkHideRestoreWarning.CheckedChanged += new System.EventHandler(this.chkHideRestoreWarning_CheckedChanged);
            // 
            // chkTrayMinimize
            // 
            this.chkTrayMinimize.AutoSize = true;
            this.chkTrayMinimize.Location = new System.Drawing.Point(9, 89);
            this.chkTrayMinimize.Name = "chkTrayMinimize";
            this.chkTrayMinimize.Size = new System.Drawing.Size(133, 17);
            this.chkTrayMinimize.TabIndex = 10;
            this.chkTrayMinimize.Text = "Minimize to system tray";
            this.chkTrayMinimize.UseVisualStyleBackColor = true;
            // 
            // TrayIcon
            // 
            this.TrayIcon.Text = "Sekiro Save Manager";
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(601, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 378);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekiro Save Manager";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackupInterval)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ListView lvBackups;
        private System.Windows.Forms.ColumnHeader colComment;
        private System.Windows.Forms.ColumnHeader colLocation;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Button btnProfileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer BackupTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBackupInterval;
        private System.Windows.Forms.ColumnHeader colSource;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutoBackupLocation;
        private System.Windows.Forms.TextBox txtAutoBackupLocation;
        private System.Windows.Forms.CheckBox chkHideRestoreWarning;
        private System.Windows.Forms.CheckBox chkTrayMinimize;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Button btnEdit;
    }
}

