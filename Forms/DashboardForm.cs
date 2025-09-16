using Microsoft.Web.WebView2.WinForms;
using POSpresso.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly ISaleService _saleService;
        private WebView2 webView2;

        public DashboardForm(ISaleService saleService)
        {
            InitializeComponent(); 
            _saleService = saleService;

            // Add WebView2 chart inside salesChartPanel
            webView2 = new WebView2
            {
                Dock = DockStyle.Fill
            };
            salesChartPanel.Controls.Add(webView2);
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async();

            var stats = await _saleService.GetCategoryStatsAsync();

            var labels = string.Join(",", stats.Select(s => $"'{s.CategoryName}'"));
            var values = string.Join(",", stats.Select(s => s.ProductCount));

            string html = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <script src='https://cdn.jsdelivr.net/npm/chart.js'></script>
            </head>
            <body>
                <canvas id='myChart' width='400' height='200'></canvas>
                <script>
                    const ctx = document.getElementById('myChart');
                    new Chart(ctx, {{
                        type: 'pie',
                        data: {{
                            labels: [{labels}],
                            datasets: [{{
                                label: 'Products by Category',
                                data: [{values}],
                                backgroundColor: ['#36A2EB','#FF6384','#FFCE56','#4CAF50','#9C27B0']
                            }}]
                        }}
                    }});
                </script>
            </body>
            </html>";

            webView2.NavigateToString(html);
        }
    }
}
