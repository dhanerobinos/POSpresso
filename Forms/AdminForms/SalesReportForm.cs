using POSpresso.Interfaces;
using ClosedXML.Excel;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgvSalesReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = "SalesReport.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Report");

                        // Add headers
                        for (int i = 0; i < dtgvSalesReport.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dtgvSalesReport.Columns[i].HeaderText;
                        }

                        // Add data
                        for (int i = 0; i < dtgvSalesReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgvSalesReport.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value =
                                    dtgvSalesReport.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Report exported successfully!");
                    }
                }
            }
        }
    }
}
