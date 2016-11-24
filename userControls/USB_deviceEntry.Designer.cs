namespace ThunderClouding
{
    partial class USB_deviceEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USB_deviceEntry));
            this.deviceName_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceName_label
            // 
            this.deviceName_label.AutoSize = true;
            this.deviceName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deviceName_label.ForeColor = System.Drawing.Color.White;
            this.deviceName_label.Location = new System.Drawing.Point(102, 33);
            this.deviceName_label.Name = "deviceName_label";
            this.deviceName_label.Size = new System.Drawing.Size(114, 20);
            this.deviceName_label.TabIndex = 1;
            this.deviceName_label.Text = "Device Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 84);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // USB_deviceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.deviceName_label);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "USB_deviceEntry";
            this.Size = new System.Drawing.Size(728, 84);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.USB_deviceEntry_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.USB_deviceEntry_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.USB_deviceEntry_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.USB_deviceEntry_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label deviceName_label;
    }
}
