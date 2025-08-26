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
        public AdminDashboard(FormLoaderService formLoader)
        {
            InitializeComponent();
            _formLoader = formLoader;
        }
        public void SetCurrentUser(User user)
        {
            _user = user;
            
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

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }
        private void LoadPOSForm()
        {
            var posForm = new POSForm(_productService);
            posForm.TopLevel = false;
            posForm.FormBorderStyle = FormBorderStyle.None;
            posForm.Dock = DockStyle.Fill;

            posForm.OnAddToCart += AddToCart;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(posForm);
            posForm.Show();
        }

        private void AddToCart(CartItem item)
        {
           
            var existing = fpReceipt.Controls
                .OfType<CartItemControl>()
                .FirstOrDefault(c => c.ProductId == item.ProductId && c.ItemSize == item.Size);

            if (existing != null)
            {
                existing.UpdateQuantity(item.Quantity); 
                return;
            }

            var control = new CartItemControl(item);
            fpReceipt.Controls.Add(control);
        }
    }
}
