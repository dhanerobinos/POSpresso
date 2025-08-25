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
            // Check if already exist
            foreach (Panel p in fpReceipt.Controls)
            {
                var lbl = p.Controls.OfType<Label>().FirstOrDefault();
                if (lbl != null && lbl.Text.StartsWith($"{item.ProductName} ({item.Size})"))
                {
                    // Update existing
                    int newQty = item.Quantity + 1;
                    lbl.Text = $"{item.ProductName} ({item.Size}) x{newQty} - ₱{item.Price * newQty:N2}";
                    return;
                }
            }

            // If not exists, add new panel
            var panel = new Panel
            {
                Width = fpReceipt.Width - 25,
                Height = 60,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            if (item.ProductImage != null)
            {
                using var ms = new MemoryStream(item.ProductImage);
                var picture = new PictureBox
                {
                    Image = Image.FromStream(ms),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 50,
                    Height = 50,
                    Dock = DockStyle.Left
                };
                panel.Controls.Add(picture);
            }

            var lblNew = new Label
            {
                Text = $"{item.ProductName} ({item.Size}) x{item.Quantity} - ₱{item.Price * item.Quantity:N2}",
                AutoSize = true,
                Left = 60,
                Top = 20
            };
            panel.Controls.Add(lblNew);

            fpReceipt.Controls.Add(panel);
        }


    }
}
