using System.Drawing; // Thêm dòng này để hiểu Color, Point, Size
using System.Windows.Forms; // Thêm dòng này để hiểu DockStyle, Keys, v.v.

namespace LAB04_N5106
{
    // SỬA: Đổi FromWeb thành FormWeb để khớp với file code chính
    partial class FormWeb
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 0);
            webView.Name = "webView";
            webView.Size = new Size(800, 450);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;

            // LƯU Ý: Mình tạm bỏ dòng click bên dưới đi vì nếu file code chính 
            // chưa viết hàm "webView_Click" thì sẽ bị báo lỗi tiếp.
            // webView.Click += webView_Click; 

            // 
            // FormWeb (Sửa tên ở đây luôn cho đồng bộ)
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView);
            Name = "FormWeb"; // Sửa Name của Form
            Text = "Webview";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}