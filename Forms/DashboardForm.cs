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

            //sales for the last 7 days
            var stats = await _saleService.GetDailySalesAsync(DateTime.Today.AddDays(-6), DateTime.Today);

            var labels = string.Join(",", stats.Select(s => $"'{s.Date:MMM dd}'"));
            var values = string.Join(",", stats.Select(s => s.TotalSales));

            // bar color assignment
            var colors = string.Join(",", stats.Select((s, i) =>
            {
                string[] palette = new[]
                {
                    "#36A2EB", "#FF6384", "#FFCE56",
                    "#4CAF50", "#9C27B0", "#FF9800", "#795548"
                };
                return $"'{palette[i % palette.Length]}'";
            }));

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
                type: 'bar',
                data: {{
                    labels: [{labels}],
                    datasets: [{{
                        label: 'Daily Sales',
                        data: [{values}],
                        backgroundColor: [{colors}]
                    }}]
                }},
                options: {{
                    responsive: true,
                    scales: {{
                        y: {{
                            beginAtZero: true
                        }}
                    }}
                }}
            }});
        </script>
    </body>
    </html>";

            webView2.NavigateToString(html);
        }
    }
}
