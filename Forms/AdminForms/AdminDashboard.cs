using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Forms.AdminForms;
using POSpresso.Interfaces;
using POSpresso.Services;

namespace POSpresso.Forms
{
    public partial class AdminDashboard : Form
    {
        private User? _user;
        private readonly IServiceProvider _serviceProvider;
        private readonly FormLoaderService _formLoader;
        private readonly ProductService _productService;
        private readonly SaleService _salesService;
        private readonly IPaymentMethodService _paymentService;

        public int? SelectedPaymentMethodId { get; private set; }

        public AdminDashboard(FormLoaderService formLoader, ProductService productService, SaleService salesService, PaymentMethodService paymentMethodService)
        {
            InitializeComponent();
            _formLoader = formLoader;
            _productService = productService;
            _salesService = salesService;

            this.Load += (s, e) =>
            {
                _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<DashboardForm>());
            };
            _paymentService = paymentMethodService;

        }
        public void SetCurrentUser(User user)
        {
            _user = user;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<DashboardForm>());
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            var posForm = Program.ServiceProvider.GetRequiredService<POSForm>();
            posForm.OnAddToCart += AddToCart;

            _formLoader.LoadForm(mainPanel, posForm);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<ProductForm>());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<ManageUserForm>());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<SalesReportForm>());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<SettingsForm>());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }

        private void AddToCart(CartItem item)
        {
            var existing = fpReceipt.Controls
             .OfType<CartItemControl>()
             .FirstOrDefault(c => c.ProductId == item.ProductId && c.ItemSize == item.Size);

            if (existing != null)
            {
                existing.UpdateQuantity(item.Quantity);
            }
            else
            {
                var control = new CartItemControl(item);
                control.OnQuantityChanged += UpdateTotals;
                fpReceipt.Controls.Add(control);
            }
            UpdateTotals();
        }
        private void UpdateTotals()
        {
            decimal subtotal = 0;

            foreach (var control in fpReceipt.Controls.OfType<CartItemControl>())
            {
                subtotal += control.SubTotal;
            }

            decimal tax = subtotal * 0.12m; // example 12% VAT
            decimal total = subtotal + tax;

            lbSubtotal.Text = $"Subtotal: ₱{subtotal:N2}";
            lbTax.Text = $"Tax: ₱{tax:N2}";
            lbTotal.Text = $"Total: ₱{total:N2}";
        }


        private async void btnCheckout_Click(object sender, EventArgs e)
        {

            if (fpReceipt.Controls.Count == 0)
            {
                MessageBox.Show("No items in the cart.");
                return;
            }

            decimal subtotal = 0;
            var saleItems = new List<SaleDetailsDTO>();

            foreach (var control in fpReceipt.Controls.OfType<CartItemControl>())
            {
                subtotal += control.SubTotal;
                saleItems.Add(new SaleDetailsDTO
                {
                    ProductId = control.ProductId,
                    ProductName = control.Item.ProductName,
                    Quantity = control.Quantity,
                    Price = control.Price,
                    Size = control.ItemSize
                });
            }

            decimal tax = subtotal * 0.12m;
            decimal grandTotal = subtotal + tax;

            // Show payment selection form
            using (var paymentForm = new PaymentForm(_paymentService))
            {
                var result = paymentForm.ShowDialog();

                if (result != DialogResult.OK || paymentForm.SelectedPaymentMethodId == null)
                {
                    MessageBox.Show("Checkout canceled or no payment method selected.");
                    return;
                }

                // Confirm payment before saving to DB
                var selectedPayment = await _paymentService.GetByIdAsync(paymentForm.SelectedPaymentMethodId.Value);
                using (var confirmPayment = new ConfirmPaymentForm(grandTotal, selectedPayment.MethodName))
                {
                    confirmPayment.ShowDialog();

                    if (!confirmPayment.IsConfirmed)
                    {
                        MessageBox.Show("Payment not confirmed. Transaction canceled.");
                        return;
                    }
                }

                // Proceed with saving sale
                var saleDto = new SaleDTO
                {
                    UserId = _user?.UserId ?? 0,
                    Subtotal = subtotal,
                    Tax = tax,
                    Total = grandTotal,
                    PaymentMethodId = paymentForm.SelectedPaymentMethodId.Value,
                    Items = saleItems
                };

                await _salesService.SaveSaleAsync(saleDto);

                // Show receipt
                var receiptForm = new ReceiptForm(saleDto);
                receiptForm.ShowDialog();

                // Clear cart
                fpReceipt.Controls.Clear();
                UpdateTotals();
            }
        }

        private void fpReceipt_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
