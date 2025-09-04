using POSpresso.Interfaces;
using System;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms.AdminForms
{
    public partial class SalesReportForm : Form
    {
        private readonly ISaleService _saleService;

        public SalesReportForm(ISaleService saleService)
        {
            InitializeComponent();
            _saleService = saleService;
        }

        private async void SalesReportForm_Load(object sender, EventArgs e)
        {
            await LoadReport();
        }

        private async Task LoadReport(DateTime? start = null, DateTime? end = null)
        {
            var sales = await _saleService.GetSalesAsync(start, end);

            dtgvSalesReport.DataSource = sales.Select(s => new
            {
                s.SaleId,
                s.SaleDate,
                s.SubTotal,
                s.Tax,
                s.Total,
                User = s.User != null ? s.User.Username : "Unknown"
            }).ToList();

     
            lbTransactions.Text = $"Transactions: {sales.Count}";
            lbSubtotal.Text = $"Subtotal: ₱{sales.Sum(s => s.SubTotal):N2}";
            lbTax.Text = $"Tax: ₱{sales.Sum(s => s.Tax):N2}";
            lbTotal.Text = $"TOTAL: ₱{sales.Sum(s => s.Total):N2}";
        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var start = dtpStart.Value.Date;
            var end = dtpEnd.Value.Date.AddDays(1).AddTicks(-1);

            await LoadReport(start, end);
        }
    }
}
