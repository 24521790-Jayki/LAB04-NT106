using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;      
using System.IO;

namespace LTMCB_Lab4_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetHTML(string szUrl)
        {
            WebRequest request = WebRequest.Create(szUrl);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBox1.Text.Trim();   // ô nhập URL

                if (string.IsNullOrWhiteSpace(url))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ website!");
                    return;
                }
                string html = GetHTML(url);
                textBox2.Text = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang: " + ex.Message);
            }
        }
    }
}
