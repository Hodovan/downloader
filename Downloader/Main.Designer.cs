namespace Downloader
{
    partial class Main
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
            this.btnDownloadSync = new System.Windows.Forms.Button();
            this.btnDownloadAsync = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnDownloadSync
            // 
            this.btnDownloadSync.Location = new System.Drawing.Point(13, 13);
            this.btnDownloadSync.Name = "btnDownloadSync";
            this.btnDownloadSync.Size = new System.Drawing.Size(160, 30);
            this.btnDownloadSync.TabIndex = 0;
            this.btnDownloadSync.Text = "Sync. Download";
            this.btnDownloadSync.UseVisualStyleBackColor = true;
            this.btnDownloadSync.Click += new System.EventHandler(this.btnDownloadSync_Click);
            // 
            // btnDownloadAsync
            // 
            this.btnDownloadAsync.Location = new System.Drawing.Point(13, 49);
            this.btnDownloadAsync.Name = "btnDownloadAsync";
            this.btnDownloadAsync.Size = new System.Drawing.Size(160, 30);
            this.btnDownloadAsync.TabIndex = 1;
            this.btnDownloadAsync.Text = "Async. Download";
            this.btnDownloadAsync.UseVisualStyleBackColor = true;
            this.btnDownloadAsync.Click += new System.EventHandler(this.btnDownloadAsync_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(412, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(160, 30);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File in Win. Explorer";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnDownloadAsync);
            this.Controls.Add(this.btnDownloadSync);
            this.Name = "Main";
            this.Text = "Downloader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadSync;
        private System.Windows.Forms.Button btnDownloadAsync;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

