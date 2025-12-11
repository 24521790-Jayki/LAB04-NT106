namespace Bai03
{
    partial class Bai03
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDownHtml = new System.Windows.Forms.Button();
            this.btnDownRes = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(95, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(600, 26);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://uit.edu.vn";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(10, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 25);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(710, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 25);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDownHtml
            // 
            this.btnDownHtml.Location = new System.Drawing.Point(800, 10);
            this.btnDownHtml.Name = "btnDownHtml";
            this.btnDownHtml.Size = new System.Drawing.Size(110, 25);
            this.btnDownHtml.TabIndex = 3;
            this.btnDownHtml.Text = "Down HTML";
            this.btnDownHtml.Click += new System.EventHandler(this.btnDownHtml_Click);
            // 
            // btnDownRes
            // 
            this.btnDownRes.Location = new System.Drawing.Point(920, 10);
            this.btnDownRes.Name = "btnDownRes";
            this.btnDownRes.Size = new System.Drawing.Size(140, 25);
            this.btnDownRes.TabIndex = 4;
            this.btnDownRes.Text = "Down Resources";
            this.btnDownRes.Click += new System.EventHandler(this.btnDownRes_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(10, 45);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1050, 650);
            this.webView.TabIndex = 5;
            this.webView.ZoomFactor = 1D;
            // 
            // Bai03
            // 
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDownHtml);
            this.Controls.Add(this.btnDownRes);
            this.Controls.Add(this.webView);
            this.Name = "Bai03";
            this.Text = "Basic Web Browser";
            this.Load += new System.EventHandler(this.Bai03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReload;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button btnDownHtml;
        private System.Windows.Forms.Button btnDownRes;
        #endregion
    }
}

