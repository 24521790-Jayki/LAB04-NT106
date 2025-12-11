using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string savePath = txtSave.Text.Trim();

            if (url == "" || savePath == "")
            {
                MessageBox.Show("Vui lòng nhập URL và đường dẫn lưu file!");
                return;
            }

            try
            {
                WebClient client = new WebClient();

                // Download vào file
                client.DownloadFile(url, savePath);

                // Đọc nội dung vừa download
                string content = File.ReadAllText(savePath);

                // Hiển thị lên form
                txtResult.Text = content;

                MessageBox.Show("Download thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files (*.html)|*.html|All Files (*.*)|*.*";
            sfd.FileName = "output.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtSave.Text = sfd.FileName;
            }
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        private void Bai02_Load_1(object sender, EventArgs e)
        {

        }
    }
}
