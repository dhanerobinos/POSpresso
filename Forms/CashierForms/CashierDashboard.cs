using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Interfaces;
using POSpresso.Services;
using POSpresso.Forms.CashierForms;

namespace POSpresso.Forms
{
    public partial class CashierDashboard : Form
    {
        private User _user;
        private readonly IServiceProvider _serviceProvider;
        private readonly FormLoaderService _formLoader;
        private readonly SaleService _salesService;
        private readonly IPaymentMethodService _paymentService;

        public int? SelectedPaymentMethodId { get; private set; }
        public CashierDashboard(FormLoaderService formLoader, SaleService salesService, PaymentMethodService paymentMethodService)
        {
            InitializeComponent();
            _formLoader = formLoader;
            _salesService = salesService;
            _paymentService = paymentMethodService;

            this.Load += (s, e) =>
            {
                _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<CashierDashboardForm>());
            };
        }
        public void SetCurrentUser(User user)
        {
            _user = user;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                Application.Restart();
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            var posForm = Program.ServiceProvider.GetRequiredService<POSForm>();
            posForm.OnAddToCart += AddToCart;

            _formLoader.LoadForm(mainPanel, posForm);
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<CashierDashboardForm>());
        }

        private void btnProductStatus_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<ProductStatusForm>());
        }
    }
}
