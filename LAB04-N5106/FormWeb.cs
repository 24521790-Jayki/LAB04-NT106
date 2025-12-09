using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core; // Requires NuGet Package: Microsoft.Web.WebView2

namespace LAB04_N5106
{
    public partial class FormWeb : Form
    {
        // Constructor accepting the URL
        public FormWeb(string url)
        {
            InitializeComponent();
            // Ensure the webView control is named 'webView' in the Designer properties
            LoadUrl(url);
        }

        private async void LoadUrl(string url)
        {
            try
            {
                // 1. Initialize the WebView2 environment
                await webView.EnsureCoreWebView2Async();

                // 2. Navigate to the URL
                if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) &&
                    (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    webView.Source = uriResult;
                }
                else
                {
                    MessageBox.Show("Invalid URL format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading WebView: " + ex.Message);
            }
        }
    }
}