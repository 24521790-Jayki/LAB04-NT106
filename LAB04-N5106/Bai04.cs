using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace LAB04_N5106
{
    // Class chứa dữ liệu phim
    public class Movie
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string DetailUrl { get; set; }
    }

    public partial class Bai04 : Form
    {
        private static readonly HttpClient Client = new HttpClient();

        public Bai04()
        {
            InitializeComponent();

            // Giá trị mặc định
            txtUrl.Text = "https://betacinemas.vn/phim.htm";
            txtFilepath.Text = "movies.json";

            // Gán sự kiện click
            btnCrawl.Click += BtnCrawl_Click;
        }

        // Sự kiện vẽ FlowLayout (Bắt buộc để Designer không lỗi)
        private void flowLayoutPanelMovies_Paint(object sender, PaintEventArgs e) { }

        private async void BtnCrawl_Click(object sender, EventArgs e)
        {
            try
            {
                btnCrawl.Enabled = false;
                progressBar1.Value = 0;

                // Xóa dữ liệu cũ trên giao diện
                if (flowLayoutPanelMovies.Controls.Count > 0)
                    flowLayoutPanelMovies.Controls.Clear();

                // 1. Crawl dữ liệu
                var movies = await CrawlDataAsync(txtUrl.Text);

                // 2. Lưu file JSON
                SaveToJson(movies, txtFilepath.Text);

                // 3. Hiển thị lên giao diện
                RenderUI(movies);

                progressBar1.Value = 100;
                MessageBox.Show($"Thành công! Đã tải {movies.Count} phim.\nClick vào phim để xem chi tiết.", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                btnCrawl.Enabled = true;
            }
        }

        private async Task<List<Movie>> CrawlDataAsync(string url)
        {
            var list = new List<Movie>();
            try
            {
                // Giả lập trình duyệt
                if (!Client.DefaultRequestHeaders.Contains("User-Agent"))
                    Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                string html = await Client.GetStringAsync(url);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                // XPath lấy danh sách phim (BetaCinemas)
                var nodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'col-lg-4')]");
                if (nodes == null) nodes = doc.DocumentNode.SelectNodes("//div[@class='item']");

                if (nodes != null)
                {
                    int total = nodes.Count;
                    int count = 0;
                    foreach (var node in nodes)
                    {
                        var titleNode = node.SelectSingleNode(".//h3/a") ?? node.SelectSingleNode(".//a");
                        var imgNode = node.SelectSingleNode(".//img");

                        if (titleNode != null)
                        {
                            string title = titleNode.InnerText.Trim();
                            string link = titleNode.GetAttributeValue("href", "");
                            string img = imgNode?.GetAttributeValue("src", "") ?? "";

                            // Xử lý link tương đối thành tuyệt đối
                            if (!string.IsNullOrEmpty(link) && !link.StartsWith("http"))
                                link = "https://betacinemas.vn" + link;

                            list.Add(new Movie
                            {
                                Title = title,
                                ImageUrl = img,
                                DetailUrl = link
                            });
                        }

                        // Cập nhật Progress Bar
                        count++;
                        if (progressBar1 != null) progressBar1.Value = (count * 90) / total;
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi vào cửa sổ Output nếu cần
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return list;
        }

        private void RenderUI(List<Movie> movies)
        {
            if (flowLayoutPanelMovies == null) return;

            foreach (var movie in movies)
            {
                // 1. Panel chứa phim
                Panel p = new Panel();
                p.Size = new Size(flowLayoutPanelMovies.Width - 30, 120);
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Margin = new Padding(5);
                p.BackColor = Color.White;

                // 2. Ảnh Poster
                PictureBox pb = new PictureBox();
                pb.Size = new Size(80, 110);
                pb.Location = new Point(5, 5);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Cursor = Cursors.Hand; // Hình bàn tay
                if (!string.IsNullOrEmpty(movie.ImageUrl))
                    try { pb.LoadAsync(movie.ImageUrl); } catch { }

                // Sự kiện Click Ảnh -> Mở FormWeb
                pb.Click += (s, e) => OpenWebForm(movie.DetailUrl);

                // 3. Tên Phim
                Label lbl = new Label();
                lbl.Text = movie.Title;
                lbl.Font = new Font("Arial", 12, FontStyle.Bold);
                lbl.ForeColor = Color.OrangeRed;
                lbl.Location = new Point(100, 10);
                lbl.AutoSize = true;
                lbl.Cursor = Cursors.Hand;

                // Sự kiện Click Tên -> Mở FormWeb
                lbl.Click += (s, e) => OpenWebForm(movie.DetailUrl);

                // 4. Link text (Trang trí)
                Label lblLink = new Label();
                lblLink.Text = movie.DetailUrl;
                lblLink.Font = new Font("Arial", 8, FontStyle.Italic);
                lblLink.ForeColor = Color.Gray;
                lblLink.Location = new Point(100, 45);
                lblLink.AutoSize = true;

                p.Controls.Add(pb);
                p.Controls.Add(lbl);
                p.Controls.Add(lblLink);
                flowLayoutPanelMovies.Controls.Add(p);
            }
        }

        // Hàm mở Form Web nội bộ
        private void OpenWebForm(string url)
        {
            try
            {
                FormWeb frm = new FormWeb(url);
                frm.Show(); // Hiện form mới lên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở trình duyệt: " + ex.Message);
            }
        }

        private void SaveToJson(List<Movie> data, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch { }
        }
    }
}