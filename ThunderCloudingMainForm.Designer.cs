namespace ThunderClouding
{
    partial class MainFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormClass));
            this.leftMenu_panel = new System.Windows.Forms.Panel();
            this.homePage_button = new System.Windows.Forms.Button();
            this.gallery_button = new System.Windows.Forms.Button();
            this.music_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.separatePanel = new System.Windows.Forms.Panel();
            this.homeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.RichTextBox();
            this.searchBtnPictureBox = new System.Windows.Forms.PictureBox();
            this.title_panel = new System.Windows.Forms.Panel();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.homePage = new ThunderClouding.homePage();
            this.fileViewer = new ThunderClouding.FileViewer();
            this.leftMenu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButtonPictureBox)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtnPictureBox)).BeginInit();
            this.title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMenu_panel
            // 
            this.leftMenu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.leftMenu_panel.Controls.Add(this.homePage_button);
            this.leftMenu_panel.Controls.Add(this.gallery_button);
            this.leftMenu_panel.Controls.Add(this.music_button);
            this.leftMenu_panel.Controls.Add(this.settings_button);
            this.leftMenu_panel.Controls.Add(this.separatePanel);
            this.leftMenu_panel.Controls.Add(this.homeButtonPictureBox);
            this.leftMenu_panel.Controls.Add(this.searchPanel);
            this.leftMenu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu_panel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.leftMenu_panel.Location = new System.Drawing.Point(0, 0);
            this.leftMenu_panel.Name = "leftMenu_panel";
            this.leftMenu_panel.Size = new System.Drawing.Size(216, 533);
            this.leftMenu_panel.TabIndex = 0;
            // 
            // homePage_button
            // 
            this.homePage_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.homePage_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePage_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.homePage_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.homePage_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.homePage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.homePage_button.ForeColor = System.Drawing.Color.White;
            this.homePage_button.Image = ((System.Drawing.Image)(resources.GetObject("homePage_button.Image")));
            this.homePage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homePage_button.Location = new System.Drawing.Point(0, 454);
            this.homePage_button.Name = "homePage_button";
            this.homePage_button.Size = new System.Drawing.Size(213, 31);
            this.homePage_button.TabIndex = 7;
            this.homePage_button.Text = "Home";
            this.homePage_button.UseVisualStyleBackColor = true;
            this.homePage_button.Click += new System.EventHandler(this.homePage_button_Click);
            // 
            // gallery_button
            // 
            this.gallery_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gallery_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.gallery_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.gallery_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.gallery_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gallery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gallery_button.ForeColor = System.Drawing.Color.White;
            this.gallery_button.Image = ((System.Drawing.Image)(resources.GetObject("gallery_button.Image")));
            this.gallery_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gallery_button.Location = new System.Drawing.Point(2, 276);
            this.gallery_button.Name = "gallery_button";
            this.gallery_button.Size = new System.Drawing.Size(213, 49);
            this.gallery_button.TabIndex = 6;
            this.gallery_button.Text = "Gallery";
            this.gallery_button.UseVisualStyleBackColor = true;
            // 
            // music_button
            // 
            this.music_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.music_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.music_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.music_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.music_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.music_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.music_button.ForeColor = System.Drawing.Color.White;
            this.music_button.Image = ((System.Drawing.Image)(resources.GetObject("music_button.Image")));
            this.music_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.music_button.Location = new System.Drawing.Point(2, 228);
            this.music_button.Name = "music_button";
            this.music_button.Size = new System.Drawing.Size(213, 49);
            this.music_button.TabIndex = 5;
            this.music_button.Text = "Music";
            this.music_button.UseVisualStyleBackColor = true;
            // 
            // settings_button
            // 
            this.settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.settings_button.ForeColor = System.Drawing.Color.White;
            this.settings_button.Image = ((System.Drawing.Image)(resources.GetObject("settings_button.Image")));
            this.settings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_button.Location = new System.Drawing.Point(0, 490);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(213, 31);
            this.settings_button.TabIndex = 4;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            // 
            // separatePanel
            // 
            this.separatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.separatePanel.Location = new System.Drawing.Point(0, 379);
            this.separatePanel.Name = "separatePanel";
            this.separatePanel.Size = new System.Drawing.Size(213, 3);
            this.separatePanel.TabIndex = 3;
            // 
            // homeButtonPictureBox
            // 
            this.homeButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homeButtonPictureBox.Image")));
            this.homeButtonPictureBox.InitialImage = null;
            this.homeButtonPictureBox.Location = new System.Drawing.Point(52, 12);
            this.homeButtonPictureBox.Name = "homeButtonPictureBox";
            this.homeButtonPictureBox.Size = new System.Drawing.Size(92, 97);
            this.homeButtonPictureBox.TabIndex = 1;
            this.homeButtonPictureBox.TabStop = false;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchBtnPictureBox);
            this.searchPanel.Location = new System.Drawing.Point(12, 125);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(192, 26);
            this.searchPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchTextBox.Location = new System.Drawing.Point(3, 1);
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(160, 22);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "";
            // 
            // searchBtnPictureBox
            // 
            this.searchBtnPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtnPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchBtnPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchBtnPictureBox.Image")));
            this.searchBtnPictureBox.Location = new System.Drawing.Point(166, 0);
            this.searchBtnPictureBox.Name = "searchBtnPictureBox";
            this.searchBtnPictureBox.Size = new System.Drawing.Size(26, 26);
            this.searchBtnPictureBox.TabIndex = 0;
            this.searchBtnPictureBox.TabStop = false;
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.title_panel.Controls.Add(this.formTitle_label);
            this.title_panel.Controls.Add(this.label1);
            this.title_panel.Controls.Add(this.label_X);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(216, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(617, 25);
            this.title_panel.TabIndex = 1;
            // 
            // formTitle_label
            // 
            this.formTitle_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formTitle_label.AutoSize = true;
            this.formTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.formTitle_label.ForeColor = System.Drawing.Color.White;
            this.formTitle_label.Location = new System.Drawing.Point(171, 5);
            this.formTitle_label.Name = "formTitle_label";
            this.formTitle_label.Size = new System.Drawing.Size(356, 17);
            this.formTitle_label.TabIndex = 2;
            this.formTitle_label.Text = "ThunderClouding - Network Attached Filesystem";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(571, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_X
            // 
            this.label_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_X.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_X.ForeColor = System.Drawing.Color.White;
            this.label_X.Location = new System.Drawing.Point(594, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(23, 25);
            this.label_X.TabIndex = 0;
            this.label_X.Text = "X";
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.homePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage.Location = new System.Drawing.Point(216, 25);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(617, 508);
            this.homePage.TabIndex = 3;
            // 
            // fileViewer
            // 
            this.fileViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.fileViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileViewer.Location = new System.Drawing.Point(216, 25);
            this.fileViewer.Name = "fileViewer";
            this.fileViewer.Size = new System.Drawing.Size(617, 508);
            this.fileViewer.TabIndex = 2;
            this.fileViewer.Load += new System.EventHandler(this.fileViewer_Load);
            // 
            // MainFormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(833, 533);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.fileViewer);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.leftMenu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThunderClouding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftMenu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeButtonPictureBox)).EndInit();
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtnPictureBox)).EndInit();
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMenu_panel;
        private System.Windows.Forms.PictureBox homeButtonPictureBox;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.PictureBox searchBtnPictureBox;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Panel separatePanel;
        private System.Windows.Forms.RichTextBox searchTextBox;
        private System.Windows.Forms.Button gallery_button;
        private System.Windows.Forms.Button music_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Label label1;
        private FileViewer fileViewer;
        private homePage homePage;
        private System.Windows.Forms.Button homePage_button;
        private System.Windows.Forms.Label formTitle_label;
    }
}

