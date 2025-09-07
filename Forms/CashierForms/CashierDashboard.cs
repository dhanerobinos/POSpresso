using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Interfaces;
using POSpresso.Services;

namespace POSpresso.Forms
{
    public partial class CashierDashboard : Form
    {
        private User _user;
        private readonly IServiceProvider _serviceProvider;
        private readonly FormLoaderService _formLoader;
        private readonly SaleService _salesService;
        public CashierDashboard(FormLoaderService formLoader, SaleService salesService)
        {
            InitializeComponent();
            _formLoader = formLoader;
            _salesService = salesService;

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

                // Map UI CartItem → DTO
                saleItems.Add(new SaleDetailsDTO
                {
                    ProductId = control.ProductId,
                    ProductName = control.Item.ProductName,
                    Quantity = control.Quantity,
                    Price = control.Price,
                    Size = control.ItemSize
                });
            }

            decimal tax = subtotal * 0.12m; // sample 12% VAT
            decimal grandTotal = subtotal + tax;

            var saleDto = new SaleDTO
            {
                UserId = _user?.UserId ?? 0, // Logged-in user
                Subtotal = subtotal,
                Tax = tax,
                Total = grandTotal,
                Items = saleItems
            };

            // Save to DB via service
            await _salesService.SaveSaleAsync(saleDto);

            var receiptForm = new ReceiptForm(saleDto);
            receiptForm.ShowDialog();

            // Clear cart
            fpReceipt.Controls.Clear();
        }
    }
}
