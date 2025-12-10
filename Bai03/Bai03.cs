using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using HtmlAgilityPack;

namespace Bai03
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrWhiteSpace(url)) return;

            await webView.EnsureCoreWebView2Async();

            webView.CoreWebView2.Navigate(url);
        }


        private async void btnReload_Click(object sender, EventArgs e)
        {
            if (webView.CoreWebView2 != null)
                webView.CoreWebView2.Reload();
        }

        // =============================
        // Download File HTML
        // =============================
        private void btnDownHtml_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text.Trim();
                if (url == "")
                {
                    MessageBox.Show("Vui lòng nhập URL!");
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "HTML File|*.html";
                save.FileName = "download.html";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    WebClient client = new WebClient();
                    client.DownloadFile(url, save.FileName);

                    MessageBox.Show("Tải HTML thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // =============================
        // Download toàn bộ Resource (img, css, js)
        // =============================
        private void btnDownRes_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text.Trim();
                if (url == "")
                {
                    MessageBox.Show("Vui lòng nhập URL!");
                    return;
                }

                // --- Chọn thư mục lưu ---
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Chọn thư mục để lưu tài nguyên của website";

                    if (fbd.ShowDialog() != DialogResult.OK)
                        return; // Người dùng bấm Cancel

                    string selectedFolder = fbd.SelectedPath;

                    // --- Bắt đầu tải ---
                    WebClient client = new WebClient();
                    string html = client.DownloadString(url);

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                    // Tạo folder con cho rõ ràng
                    string folder = Path.Combine(selectedFolder, "resources");
                    Directory.CreateDirectory(folder);

                    // ------------------ TẢI IMG ------------------
                    var images = doc.DocumentNode.SelectNodes("//img[@src]");
                    if (images != null)
                    {
                        foreach (var img in images)
                        {
                            string src = img.GetAttributeValue("src", "");
                            string fullUrl = new Uri(new Uri(url), src).AbsoluteUri;

                            string fileName = Path.Combine(folder, Path.GetFileName(fullUrl));

                            try { client.DownloadFile(fullUrl, fileName); }
                            catch { }
                        }
                    }

                    // ------------------ TẢI CSS ------------------
                    var css = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet']");
                    if (css != null)
                    {
                        foreach (var c in css)
                        {
                            string href = c.GetAttributeValue("href", "");
                            string fullUrl = new Uri(new Uri(url), href).AbsoluteUri;

                            string fileName = Path.Combine(folder, Path.GetFileName(fullUrl));

                            try { client.DownloadFile(fullUrl, fileName); }
                            catch { }
                        }
                    }

                    // ------------------ TẢI JS ------------------
                    var js = doc.DocumentNode.SelectNodes("//script[@src]");
                    if (js != null)
                    {
                        foreach (var s in js)
                        {
                            string src = s.GetAttributeValue("src", "");
                            string fullUrl = new Uri(new Uri(url), src).AbsoluteUri;

                            string fileName = Path.Combine(folder, Path.GetFileName(fullUrl));

                            try { client.DownloadFile(fullUrl, fileName); }
                            catch { }
                        }
                    }

                    MessageBox.Show("Download Resources thành công!\nĐã lưu tại: " + folder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void Bai03_Load(object sender, EventArgs e)
        {

        }
    }
}
