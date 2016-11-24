namespace ThunderClouding.userControls
{
    partial class ProfileInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileInfo));
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteFile_button = new System.Windows.Forms.Button();
            this.ok_profileInfo_button = new System.Windows.Forms.Button();
            this.cancel_profileInfo_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_textBox
            // 
            this.username_textBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.username_textBox.ForeColor = System.Drawing.Color.White;
            this.username_textBox.Location = new System.Drawing.Point(130, 85);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.ReadOnly = true;
            this.username_textBox.Size = new System.Drawing.Size(278, 22);
            this.username_textBox.TabIndex = 0;
            this.username_textBox.MouseEnter += new System.EventHandler(this.highlightControlBorder_Event);
            this.username_textBox.MouseLeave += new System.EventHandler(this.removeHighlightFromBoarder_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // deleteFile_button
            // 
            this.deleteFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFile_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.deleteFile_button.Image = ((System.Drawing.Image)(resources.GetObject("deleteFile_button.Image")));
            this.deleteFile_button.Location = new System.Drawing.Point(413, 83);
            this.deleteFile_button.Name = "deleteFile_button";
            this.deleteFile_button.Size = new System.Drawing.Size(36, 29);
            this.deleteFile_button.TabIndex = 5;
            this.deleteFile_button.UseVisualStyleBackColor = true;
            this.deleteFile_button.Click += new System.EventHandler(this.deleteFile_button_Click);
            // 
            // ok_profileInfo_button
            // 
            this.ok_profileInfo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_profileInfo_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.ok_profileInfo_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ok_profileInfo_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ok_profileInfo_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.ok_profileInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_profileInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ok_profileInfo_button.ForeColor = System.Drawing.Color.White;
            this.ok_profileInfo_button.Location = new System.Drawing.Point(575, 447);
            this.ok_profileInfo_button.Name = "ok_profileInfo_button";
            this.ok_profileInfo_button.Size = new System.Drawing.Size(75, 28);
            this.ok_profileInfo_button.TabIndex = 6;
            this.ok_profileInfo_button.Text = "Ok";
            this.ok_profileInfo_button.UseVisualStyleBackColor = false;
            this.ok_profileInfo_button.Click += new System.EventHandler(this.ok_profileInfo_button_Click);
            // 
            // cancel_profileInfo_button
            // 
            this.cancel_profileInfo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_profileInfo_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancel_profileInfo_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.cancel_profileInfo_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.cancel_profileInfo_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancel_profileInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_profileInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cancel_profileInfo_button.ForeColor = System.Drawing.Color.White;
            this.cancel_profileInfo_button.Location = new System.Drawing.Point(481, 447);
            this.cancel_profileInfo_button.Name = "cancel_profileInfo_button";
            this.cancel_profileInfo_button.Size = new System.Drawing.Size(75, 28);
            this.cancel_profileInfo_button.TabIndex = 7;
            this.cancel_profileInfo_button.Text = "Cancel";
            this.cancel_profileInfo_button.UseVisualStyleBackColor = false;
            this.cancel_profileInfo_button.Click += new System.EventHandler(this.cancel_profileInfo_button_Click);
            // 
            // ProfileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cancel_profileInfo_button);
            this.Controls.Add(this.ok_profileInfo_button);
            this.Controls.Add(this.deleteFile_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_textBox);
            this.Name = "ProfileInfo";
            this.Size = new System.Drawing.Size(673, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteFile_button;
        private System.Windows.Forms.Button ok_profileInfo_button;
        private System.Windows.Forms.Button cancel_profileInfo_button;
    }
}
