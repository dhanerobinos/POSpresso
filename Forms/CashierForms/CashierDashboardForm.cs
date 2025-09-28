using POSpresso.Interfaces;
using Microsoft.Web.WebView2.WinForms;
using System.Threading.Tasks;


namespace POSpresso.Forms.CashierForms
{
    public partial class CashierDashboardForm : Form
    {
        private readonly ISaleService _saleService;
        private WebView2 webView2;
        private WebView2 bestSellerWebView;

        public CashierDashboardForm(ISaleService saleService)
        {
            InitializeComponent();
            _saleService = saleService;
            // Add WebView2 chart inside salesChartPanel
            webView2 = new WebView2 { Dock = DockStyle.Fill };
            salesChartPanel.Controls.Add(webView2);

            // Add WebView2 chart inside BestSellerPanel
            bestSellerWebView = new WebView2 { Dock = DockStyle.Fill };
            BestSellerPanel.Controls.Add(bestSellerWebView);

        }
        private async void CashierDashboardForm_Load(object sender, EventArgs e)
        {
            await LoadCashierDashboardAsync();
        }

        private async Task LoadCashierDashboardAsync()
        {
            await webView2.EnsureCoreWebView2Async();

            // Get today's sales per product
            var stats = await _saleService.GetTodayProductSalesAsync();

            var labels = string.Join(",", stats.Select(s => $"'{s.ProductName}'"));
            var values = string.Join(",", stats.Select(s => s.QuantitySold));

            string html = $@"
<!DOCTYPE html>
<html>
<head>
    <script src='https://cdn.jsdelivr.net/npm/chart.js'></script>
</head>
<body style='display:flex; justify-content:center; align-items:center; height:100%; margin:0;'>
    <canvas id='myChart' width='400' height='200'></canvas>
    <script>
        const ctx = document.getElementById('myChart');
        new Chart(ctx, {{
            type: 'bar',
            data: {{
                labels: [{labels}],
                datasets: [{{
                    label: 'Items Sold Today',
                    data: [{values}],
                    backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#4CAF50', '#9C27B0']
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
            await webView2.EnsureCoreWebView2Async();

            webView2.NavigateToString(html);

            // Best Sellers (last 30 days)
            await bestSellerWebView.EnsureCoreWebView2Async();
            var bestSellers = await _saleService.GetBestSellersAsync(DateTime.Today.AddDays(-30), DateTime.Today);

            var total = bestSellers.Sum(b => b.QuantitySold);
            var labels2 = string.Join(",", bestSellers.Select(b => $"'{b.ProductName} ({(b.QuantitySold * 100 / total):0}%)'"));
            var values2 = string.Join(",", bestSellers.Select(b => b.QuantitySold));

            string bestSellerHtml = $@"


    <!DOCTYPE html>
    <html>
    <head>
        <script src='https://cdn.jsdelivr.net/npm/chart.js'></script>
    </head>
    <body style='display:flex; justify-content:center; align-items:center; height:100%; margin:0;'>
        <canvas id='bestSellerChart' width='400' height='200'></canvas>
        <script>
            const ctx = document.getElementById('bestSellerChart');
            new Chart(ctx, {{
                type: 'pie',
                data: {{
                    labels: [{labels2}],
                    datasets: [{{
                        data: [{values2}],
                        backgroundColor: ['#FF6384','#36A2EB','#FFCE56','#4CAF50','#9C27B0']
                    }}]
                }},
                options: {{
                    responsive: true
                }}
            }});
        </script>
    </body>
    </html>";

            bestSellerWebView.NavigateToString(bestSellerHtml);
        }
    }
}
