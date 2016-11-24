namespace ThunderClouding
{
    partial class homePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.headerTop_panel = new System.Windows.Forms.Panel();
            this.username_label = new System.Windows.Forms.Label();
            this.avatar_pictureBox = new System.Windows.Forms.PictureBox();
            this.tabBar_panel = new System.Windows.Forms.Panel();
            this.myProfile_button = new System.Windows.Forms.Button();
            this.underLine_panel = new System.Windows.Forms.Panel();
            this.usbDevices_button = new System.Windows.Forms.Button();
            this.storageDevicesControl = new ThunderClouding.userControls.StorageDevicesControl();
            this.profileInfo = new ThunderClouding.userControls.ProfileInfo();
            this.headerTop_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pictureBox)).BeginInit();
            this.tabBar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerTop_panel
            // 
            this.headerTop_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.headerTop_panel.Controls.Add(this.username_label);
            this.headerTop_panel.Controls.Add(this.avatar_pictureBox);
            this.headerTop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTop_panel.Location = new System.Drawing.Point(0, 0);
            this.headerTop_panel.Name = "headerTop_panel";
            this.headerTop_panel.Size = new System.Drawing.Size(693, 177);
            this.headerTop_panel.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(151, 39);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(100, 22);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "User Name";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatar_pictureBox
            // 
            this.avatar_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatar_pictureBox.Image")));
            this.avatar_pictureBox.Location = new System.Drawing.Point(38, 21);
            this.avatar_pictureBox.Name = "avatar_pictureBox";
            this.avatar_pictureBox.Size = new System.Drawing.Size(91, 105);
            this.avatar_pictureBox.TabIndex = 0;
            this.avatar_pictureBox.TabStop = false;
            // 
            // tabBar_panel
            // 
            this.tabBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.tabBar_panel.Controls.Add(this.myProfile_button);
            this.tabBar_panel.Controls.Add(this.underLine_panel);
            this.tabBar_panel.Controls.Add(this.usbDevices_button);
            this.tabBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabBar_panel.Location = new System.Drawing.Point(0, 177);
            this.tabBar_panel.Name = "tabBar_panel";
            this.tabBar_panel.Size = new System.Drawing.Size(693, 46);
            this.tabBar_panel.TabIndex = 1;
            // 
            // myProfile_button
            // 
            this.myProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.myProfile_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.myProfile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myProfile_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.myProfile_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.myProfile_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.myProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.myProfile_button.ForeColor = System.Drawing.Color.White;
            this.myProfile_button.Location = new System.Drawing.Point(171, 0);
            this.myProfile_button.Name = "myProfile_button";
            this.myProfile_button.Size = new System.Drawing.Size(101, 41);
            this.myProfile_button.TabIndex = 3;
            this.myProfile_button.Text = "My Profile";
            this.myProfile_button.UseVisualStyleBackColor = false;
            this.myProfile_button.Click += new System.EventHandler(this.myProfile_button_Click);
            // 
            // underLine_panel
            // 
            this.underLine_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.underLine_panel.Location = new System.Drawing.Point(22, 39);
            this.underLine_panel.Name = "underLine_panel";
            this.underLine_panel.Size = new System.Drawing.Size(103, 5);
            this.underLine_panel.TabIndex = 2;
            // 
            // usbDevices_button
            // 
            this.usbDevices_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usbDevices_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.usbDevices_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usbDevices_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.usbDevices_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.usbDevices_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.usbDevices_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usbDevices_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usbDevices_button.ForeColor = System.Drawing.Color.White;
            this.usbDevices_button.Location = new System.Drawing.Point(21, 0);
            this.usbDevices_button.Name = "usbDevices_button";
            this.usbDevices_button.Size = new System.Drawing.Size(101, 41);
            this.usbDevices_button.TabIndex = 0;
            this.usbDevices_button.Text = "My Devices";
            this.usbDevices_button.UseVisualStyleBackColor = false;
            this.usbDevices_button.Click += new System.EventHandler(this.usbDevices_button_Click);
            // 
            // storageDevicesControl
            // 
            this.storageDevicesControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.storageDevicesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageDevicesControl.Location = new System.Drawing.Point(0, 223);
            this.storageDevicesControl.Name = "storageDevicesControl";
            this.storageDevicesControl.Size = new System.Drawing.Size(693, 317);
            this.storageDevicesControl.TabIndex = 2;
            // 
            // profileInfo
            // 
            this.profileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.profileInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfo.Location = new System.Drawing.Point(0, 223);
            this.profileInfo.Name = "profileInfo";
            this.profileInfo.Size = new System.Drawing.Size(693, 317);
            this.profileInfo.TabIndex = 3;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.profileInfo);
            this.Controls.Add(this.storageDevicesControl);
            this.Controls.Add(this.tabBar_panel);
            this.Controls.Add(this.headerTop_panel);
            this.Name = "homePage";
            this.Size = new System.Drawing.Size(693, 540);
            this.headerTop_panel.ResumeLayout(false);
            this.headerTop_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pictureBox)).EndInit();
            this.tabBar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerTop_panel;
        private System.Windows.Forms.PictureBox avatar_pictureBox;
        private System.Windows.Forms.Panel tabBar_panel;
        private System.Windows.Forms.Panel underLine_panel;
        private System.Windows.Forms.Button usbDevices_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button myProfile_button;
        private userControls.StorageDevicesControl storageDevicesControl;
        private userControls.ProfileInfo profileInfo;        
    }
}
