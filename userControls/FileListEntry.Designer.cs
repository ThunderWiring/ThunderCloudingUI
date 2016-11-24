namespace ThunderClouding
{
    partial class FileListEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileListEntry));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.type_label = new System.Windows.Forms.Label();
            this.dateModified_label = new System.Windows.Forms.Label();
            this.fileName_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fileSize_label = new System.Windows.Forms.Label();
            this.viewFile_button = new System.Windows.Forms.Button();
            this.downloadFile_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.type_label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dateModified_label, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.fileName_label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 3, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(747, 49);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.type_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.type_label.Location = new System.Drawing.Point(189, 0);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(180, 49);
            this.type_label.TabIndex = 4;
            this.type_label.Text = "type";
            this.type_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateModified_label
            // 
            this.dateModified_label.AutoSize = true;
            this.dateModified_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateModified_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateModified_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateModified_label.Location = new System.Drawing.Point(375, 0);
            this.dateModified_label.Name = "dateModified_label";
            this.dateModified_label.Size = new System.Drawing.Size(180, 49);
            this.dateModified_label.TabIndex = 1;
            this.dateModified_label.Text = "date modified";
            this.dateModified_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileName_label
            // 
            this.fileName_label.AutoSize = true;
            this.fileName_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fileName_label.Location = new System.Drawing.Point(3, 0);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(180, 49);
            this.fileName_label.TabIndex = 0;
            this.fileName_label.Text = "file name";
            this.fileName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileName_label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileName_label_MouseClick);
            this.fileName_label.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileName_label_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.viewFile_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileSize_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.downloadFile_button, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(561, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 43);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // fileSize_label
            // 
            this.fileSize_label.AutoSize = true;
            this.fileSize_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileSize_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSize_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fileSize_label.Location = new System.Drawing.Point(3, 0);
            this.fileSize_label.Name = "fileSize_label";
            this.fileSize_label.Size = new System.Drawing.Size(117, 43);
            this.fileSize_label.TabIndex = 2;
            this.fileSize_label.Text = "Size";
            this.fileSize_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewFile_button
            // 
            this.viewFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewFile_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.viewFile_button.Image = ((System.Drawing.Image)(resources.GetObject("viewFile_button.Image")));
            this.viewFile_button.Location = new System.Drawing.Point(126, 3);
            this.viewFile_button.Name = "viewFile_button";
            this.viewFile_button.Size = new System.Drawing.Size(24, 35);
            this.viewFile_button.TabIndex = 3;
            this.viewFile_button.UseVisualStyleBackColor = true;
            // 
            // downloadFile_button
            // 
            this.downloadFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadFile_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.downloadFile_button.Image = ((System.Drawing.Image)(resources.GetObject("downloadFile_button.Image")));
            this.downloadFile_button.Location = new System.Drawing.Point(156, 3);
            this.downloadFile_button.Name = "downloadFile_button";
            this.downloadFile_button.Size = new System.Drawing.Size(24, 35);
            this.downloadFile_button.TabIndex = 4;
            this.downloadFile_button.UseVisualStyleBackColor = true;
            // 
            // FileListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FileListEntry";
            this.Size = new System.Drawing.Size(747, 49);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label fileName_label;
        private System.Windows.Forms.Label dateModified_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label fileSize_label;
        private System.Windows.Forms.Button viewFile_button;
        private System.Windows.Forms.Button downloadFile_button;

    }
}
