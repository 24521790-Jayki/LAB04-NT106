using Newtonsoft.Json.Linq; // Cần cài NuGet Newtonsoft.Json
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http; // Cần cho HttpClient
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04_N5106
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/auth/token";
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password!");
                return;
            }

            rtbResponse.Text = "Đang kết nối...";
            btnLogin.Enabled = false; // Khóa nút khi đang xử lý

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Tạo MultipartFormDataContent theo yêu cầu đề bài
                    var content = new MultipartFormDataContent();
                    content.Add(new StringContent(username), "username");
                    content.Add(new StringContent(password), "password");

                    // Gửi request POST
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Đọc nội dung trả về
                    string responseString = await response.Content.ReadAsStringAsync();

                    // Parse JSON
                    JObject jsonObject = JObject.Parse(responseString);

                    if (response.IsSuccessStatusCode)
                    {
                        // Đăng nhập thành công -> Lấy token_type và access_token
                        string tokenType = jsonObject["token_type"].ToString();
                        string accessToken = jsonObject["access_token"].ToString();

                        rtbResponse.Text = $"{tokenType} {accessToken}\nĐăng nhập thành công";
                    }
                    else
                    {
                        // Đăng nhập thất bại -> Lấy thông tin lỗi trong field "detail"
                        string detail = jsonObject["detail"].ToString();
                        rtbResponse.Text = $"Đăng nhập thất bại.\nDetail: {detail}";
                    }
                }
            }
            catch (Exception ex)
            {
                rtbResponse.Text = "Lỗi hệ thống: " + ex.Message;
            }
            finally
            {
                btnLogin.Enabled = true; // Mở lại nút
            }
        }

        // Hàm này được tạo tự động trong Designer của bạn, cần khai báo để tránh lỗi
        private void rtbResponse_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống nếu không cần xử lý gì khi text thay đổi
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bai05_Load(object sender, EventArgs e)
        {

        }
    }
}