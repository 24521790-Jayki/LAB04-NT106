namespace Bai02
{
    partial class Bai02
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 15);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(430, 26);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://uit.edu.vn";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(12, 50);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(350, 26);
            this.txtSave.TabIndex = 1;
            this.txtSave.Text = "E:\\output.html";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(460, 15);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(110, 57);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(558, 350);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(370, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 26);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Bai02
            // 
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtUrl);
            this.Name = "Bai02";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Bai02_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox txtResult;

        #endregion
    }
}

