namespace Sekiro_Save_Manager.Forms
{
    partial class AboutDialog
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
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblIcon = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(404, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(467, 74);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "This software is provided \'as-is\', without any express or implied warranty. In no" +
    " event will the authors be held liable for any damages arising from the use of t" +
    "his software. ";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(82, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version: ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.LinkArea = new System.Windows.Forms.LinkArea(11, 13);
            this.lblAuthor.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblAuthor.Location = new System.Drawing.Point(82, 36);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(132, 17);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.TabStop = true;
            this.lblAuthor.Text = "Created by Nate Shoffner";
            this.lblAuthor.UseCompatibleTextRendering = true;
            this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthor_LinkClicked);
            // 
            // lblIcon
            // 
            this.lblIcon.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblIcon.AutoSize = true;
            this.lblIcon.LinkArea = new System.Windows.Forms.LinkArea(14, 6);
            this.lblIcon.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblIcon.Location = new System.Drawing.Point(82, 57);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(108, 17);
            this.lblIcon.TabIndex = 5;
            this.lblIcon.TabStop = true;
            this.lblIcon.Text = "Icon made by Icons8";
            this.lblIcon.UseCompatibleTextRendering = true;
            this.lblIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblIcon_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sekiro_Save_Manager.Properties.Resources.icons8_data_backup_96;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Sekrio Save Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel lblAuthor;
        private System.Windows.Forms.LinkLabel lblIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}