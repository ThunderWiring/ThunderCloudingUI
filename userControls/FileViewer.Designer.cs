namespace ThunderClouding
{
    partial class FileViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileViewer));
            this.titles_panel = new System.Windows.Forms.Panel();
            this.downloadAll_button = new System.Windows.Forms.Button();
            this.selectAll_button = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.deleteFile_button = new System.Windows.Forms.Button();
            this.gridView_button = new System.Windows.Forms.Button();
            this.listView_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileHost_panel = new System.Windows.Forms.Panel();
            this.titles_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titles_panel
            // 
            this.titles_panel.AutoSize = true;
            this.titles_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.titles_panel.Controls.Add(this.downloadAll_button);
            this.titles_panel.Controls.Add(this.selectAll_button);
            this.titles_panel.Controls.Add(this.upload_button);
            this.titles_panel.Controls.Add(this.deleteFile_button);
            this.titles_panel.Controls.Add(this.gridView_button);
            this.titles_panel.Controls.Add(this.listView_button);
            this.titles_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titles_panel.Location = new System.Drawing.Point(0, 0);
            this.titles_panel.Name = "titles_panel";
            this.titles_panel.Size = new System.Drawing.Size(617, 35);
            this.titles_panel.TabIndex = 1;
            // 
            // downloadAll_button
            // 
            this.downloadAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadAll_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadAll_button.Enabled = false;
            this.downloadAll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadAll_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.downloadAll_button.Image = ((System.Drawing.Image)(resources.GetObject("downloadAll_button.Image")));
            this.downloadAll_button.Location = new System.Drawing.Point(536, 3);
            this.downloadAll_button.Name = "downloadAll_button";
            this.downloadAll_button.Size = new System.Drawing.Size(36, 29);
            this.downloadAll_button.TabIndex = 6;
            this.downloadAll_button.UseVisualStyleBackColor = true;
            // 
            // selectAll_button
            // 
            this.selectAll_button.BackColor = System.Drawing.Color.Goldenrod;
            this.selectAll_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.selectAll_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.selectAll_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.selectAll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.selectAll_button.ForeColor = System.Drawing.Color.White;
            this.selectAll_button.Location = new System.Drawing.Point(299, 3);
            this.selectAll_button.Name = "selectAll_button";
            this.selectAll_button.Size = new System.Drawing.Size(75, 28);
            this.selectAll_button.TabIndex = 5;
            this.selectAll_button.Text = "Select All";
            this.selectAll_button.UseVisualStyleBackColor = false;
            this.selectAll_button.Click += new System.EventHandler(this.selectAll_button_Click);
            // 
            // upload_button
            // 
            this.upload_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.upload_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.upload_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.upload_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.upload_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.upload_button.ForeColor = System.Drawing.Color.White;
            this.upload_button.Location = new System.Drawing.Point(201, 3);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 28);
            this.upload_button.TabIndex = 3;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = false;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // deleteFile_button
            // 
            this.deleteFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFile_button.Enabled = false;
            this.deleteFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFile_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.deleteFile_button.Image = ((System.Drawing.Image)(resources.GetObject("deleteFile_button.Image")));
            this.deleteFile_button.Location = new System.Drawing.Point(578, 3);
            this.deleteFile_button.Name = "deleteFile_button";
            this.deleteFile_button.Size = new System.Drawing.Size(36, 29);
            this.deleteFile_button.TabIndex = 4;
            this.deleteFile_button.UseVisualStyleBackColor = true;
            // 
            // gridView_button
            // 
            this.gridView_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridView_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gridView_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView_button.Image = ((System.Drawing.Image)(resources.GetObject("gridView_button.Image")));
            this.gridView_button.Location = new System.Drawing.Point(96, 3);
            this.gridView_button.Name = "gridView_button";
            this.gridView_button.Size = new System.Drawing.Size(29, 29);
            this.gridView_button.TabIndex = 2;
            this.gridView_button.UseVisualStyleBackColor = true;
            this.gridView_button.Click += new System.EventHandler(this.gridView_button_Click);
            // 
            // listView_button
            // 
            this.listView_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listView_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.listView_button.Image = ((System.Drawing.Image)(resources.GetObject("listView_button.Image")));
            this.listView_button.Location = new System.Drawing.Point(135, 3);
            this.listView_button.Name = "listView_button";
            this.listView_button.Size = new System.Drawing.Size(36, 29);
            this.listView_button.TabIndex = 3;
            this.listView_button.UseVisualStyleBackColor = true;
            this.listView_button.Click += new System.EventHandler(this.listView_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "File Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(521, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(363, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Modified";
            // 
            // fileHost_panel
            // 
            this.fileHost_panel.AutoScroll = true;
            this.fileHost_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileHost_panel.Location = new System.Drawing.Point(0, 84);
            this.fileHost_panel.Name = "fileHost_panel";
            this.fileHost_panel.Size = new System.Drawing.Size(617, 424);
            this.fileHost_panel.TabIndex = 3;
            // 
            // FileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.fileHost_panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titles_panel);
            this.Name = "FileViewer";
            this.Size = new System.Drawing.Size(617, 508);
            this.titles_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titles_panel;
        private System.Windows.Forms.Button gridView_button;
        private System.Windows.Forms.Button listView_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteFile_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button selectAll_button;
        private System.Windows.Forms.Panel fileHost_panel;
        private System.Windows.Forms.Button downloadAll_button;

    }
}
