namespace ThunderClouding
{
    partial class FileGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileGridView));
            this.fileIcon_pictureBox = new System.Windows.Forms.PictureBox();
            this.fileDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileIcon_pictureBox
            // 
            this.fileIcon_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileIcon_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fileIcon_pictureBox.Image")));
            this.fileIcon_pictureBox.Location = new System.Drawing.Point(14, 10);
            this.fileIcon_pictureBox.Name = "fileIcon_pictureBox";
            this.fileIcon_pictureBox.Size = new System.Drawing.Size(120, 120);
            this.fileIcon_pictureBox.TabIndex = 1;
            this.fileIcon_pictureBox.TabStop = false;
            // 
            // fileDescription_richTextBox
            // 
            this.fileDescription_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.fileDescription_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileDescription_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileDescription_richTextBox.ForeColor = System.Drawing.Color.White;
            this.fileDescription_richTextBox.Location = new System.Drawing.Point(7, 136);
            this.fileDescription_richTextBox.Name = "fileDescription_richTextBox";
            this.fileDescription_richTextBox.Size = new System.Drawing.Size(137, 50);
            this.fileDescription_richTextBox.TabIndex = 0;
            this.fileDescription_richTextBox.Text = "";
            // 
            // FileGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.fileDescription_richTextBox);
            this.Controls.Add(this.fileIcon_pictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FileGridView";
            this.Size = new System.Drawing.Size(152, 197);
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fileIcon_pictureBox;
        private System.Windows.Forms.RichTextBox fileDescription_richTextBox;
    }
}
