namespace ThunderClouding.userControls
{
    partial class StorageDevicesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageDevicesControl));
            this.devicesCtrl_panel = new System.Windows.Forms.Panel();
            this.refreshDevices_button = new System.Windows.Forms.Button();
            this.devices_panel = new System.Windows.Forms.Panel();
            this.devicesCtrl_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesCtrl_panel
            // 
            this.devicesCtrl_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(111)))));
            this.devicesCtrl_panel.Controls.Add(this.refreshDevices_button);
            this.devicesCtrl_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesCtrl_panel.Location = new System.Drawing.Point(0, 0);
            this.devicesCtrl_panel.Name = "devicesCtrl_panel";
            this.devicesCtrl_panel.Size = new System.Drawing.Size(717, 33);
            this.devicesCtrl_panel.TabIndex = 1;
            // 
            // refreshDevices_button
            // 
            this.refreshDevices_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshDevices_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshDevices_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(111)))));
            this.refreshDevices_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.refreshDevices_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.refreshDevices_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshDevices_button.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshDevices_button.ForeColor = System.Drawing.Color.White;
            this.refreshDevices_button.Image = ((System.Drawing.Image)(resources.GetObject("refreshDevices_button.Image")));
            this.refreshDevices_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshDevices_button.Location = new System.Drawing.Point(0, 0);
            this.refreshDevices_button.Name = "refreshDevices_button";
            this.refreshDevices_button.Size = new System.Drawing.Size(35, 33);
            this.refreshDevices_button.TabIndex = 1;
            this.refreshDevices_button.UseVisualStyleBackColor = true;
            this.refreshDevices_button.Click += new System.EventHandler(this.refreshDevices_button_Click);
            // 
            // devices_panel
            // 
            this.devices_panel.AutoScroll = true;
            this.devices_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devices_panel.Location = new System.Drawing.Point(0, 33);
            this.devices_panel.Name = "devices_panel";
            this.devices_panel.Size = new System.Drawing.Size(717, 344);
            this.devices_panel.TabIndex = 2;
            // 
            // StorageDevicesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.devices_panel);
            this.Controls.Add(this.devicesCtrl_panel);
            this.Name = "StorageDevicesControl";
            this.Size = new System.Drawing.Size(717, 377);
            this.devicesCtrl_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel devicesCtrl_panel;
        private System.Windows.Forms.Button refreshDevices_button;
        private System.Windows.Forms.Panel devices_panel;
    }
}
