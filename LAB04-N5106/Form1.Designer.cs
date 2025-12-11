using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LAB04_N5106
{
    partial class Bai04
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
            txtUrl = new TextBox();
            txtFilepath = new TextBox();
            btnCrawl = new Button();
            progressBar1 = new ProgressBar();
            flowLayoutPanelMovies = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(84, 25);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(510, 27);
            txtUrl.TabIndex = 0;
            // 
            // txtFilepath
            // 
            txtFilepath.Location = new Point(84, 142);
            txtFilepath.Name = "txtFilepath";
            txtFilepath.Size = new Size(510, 27);
            txtFilepath.TabIndex = 1;
            // 
            // btnCrawl
            // 
            btnCrawl.Location = new Point(648, 23);
            btnCrawl.Name = "btnCrawl";
            btnCrawl.Size = new Size(94, 29);
            btnCrawl.TabIndex = 2;
            btnCrawl.Text = "Trích xuất";
            btnCrawl.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-4, 660);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(826, 29);
            progressBar1.TabIndex = 3;
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.Location = new Point(-4, 222);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Size = new Size(798, 371);
            flowLayoutPanelMovies.TabIndex = 4;
            flowLayoutPanelMovies.Paint += flowLayoutPanelMovies_Paint;
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1613, 725);
            Controls.Add(flowLayoutPanelMovies);
            Controls.Add(progressBar1);
            Controls.Add(btnCrawl);
            Controls.Add(txtFilepath);
            Controls.Add(txtUrl);
            Name = "Bai04";
            Text = "Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private TextBox txtFilepath;
        private Button btnCrawl;
        private ProgressBar progressBar1;
        private FlowLayoutPanel flowLayoutPanelMovies;
    }
}