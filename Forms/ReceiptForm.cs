using POSpresso.Domain.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class ReceiptForm : Form
    {
        private readonly SaleDTO _sale;
        private PrintDocument printDocument;
        public ReceiptForm(SaleDTO sale)
        {
            InitializeComponent();
            _sale = sale;
            LoadReceipt();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void LoadReceipt()
        {
            var sb = new StringBuilder();
            sb.AppendLine("====== POSPRESSO ======");
            sb.AppendLine($"Date: {DateTime.Now}");
            sb.AppendLine("-----------------------");

            foreach (var item in _sale.Items)
            {
                sb.AppendLine($"{item.ProductId} - {item.Size ?? "N/A"}");
                sb.AppendLine($"Qty: {item.Quantity}  x  ₱{item.Price:N2}");
                sb.AppendLine($"Subtotal: ₱{item.Price * item.Quantity:N2}");
                sb.AppendLine();
            }

            sb.AppendLine("-----------------------");
            sb.AppendLine($"Subtotal: ₱{_sale.Subtotal:N2}");
            sb.AppendLine($"Tax: ₱{_sale.Tax:N2}");
            sb.AppendLine($"Total: ₱{_sale.Total:N2}");
            sb.AppendLine("=======================");

            rtbReceipt.Text = sb.ToString();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 20;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Consolas", 10);

            // Title
            e.Graphics.DrawString("=== POSPRESSO RECEIPT ===", new Font("Consolas", 12, FontStyle.Bold), Brushes.Black, leftMargin, y);
            y += 40;

            // Items
            foreach (var item in _sale.Items)
            {
                string line = $"{item.ProductId} ({item.Size ?? "N/A"})";
                e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, y);
                y += 20;

                string qtyPrice = $"Qty: {item.Quantity} x ₱{item.Price:N2} = ₱{item.Price * item.Quantity:N2}";
                e.Graphics.DrawString(qtyPrice, font, Brushes.Black, leftMargin + 20, y);
                y += 30;
            }

            // Totals
            e.Graphics.DrawString($"Subtotal: ₱{_sale.Subtotal:N2}", font, Brushes.Black, leftMargin, y);
            y += 20;
            e.Graphics.DrawString($"Tax: ₱{_sale.Tax:N2}", font, Brushes.Black, leftMargin, y);
            y += 20;
            e.Graphics.DrawString($"TOTAL: ₱{_sale.Total:N2}", new Font("Consolas", 11, FontStyle.Bold), Brushes.Black, leftMargin, y);
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }
    }
}

