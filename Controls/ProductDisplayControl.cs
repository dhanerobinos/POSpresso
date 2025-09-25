using POSpresso.Domain.DTO;
using POSpresso.Domain.Enums;


namespace POSpresso
{
    public partial class ProductDisplayControl : UserControl
    {
        private ProductDTO? _product;

        public ProductDisplayControl()
        {
            InitializeComponent();

            // Subscribe to the Click event of the UserControl and all child controls
            this.Click += Card_Click;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += Card_Click;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void SetProduct(ProductDTO product)
        {
            _product = product;

            lbProductName.Text = product.ProductName;
            lblPrice.Text = $"₱{product.ProductPrice:N2}";

            if (product.ProductImage != null)
            {
                using var ms = new MemoryStream(product.ProductImage);
                pbProduct.Image = Image.FromStream(ms);
            }
            else
            {
                pbProduct.Image = null;
            }

            if (product.ProductStatus == ProductStatus.Unavailable)
            {
                this.BackColor = Color.LightGray;

                lbUnavailable.Visible = true;
                lbUnavailable.Text = "UNAVAILABLE";
                lbUnavailable.ForeColor = Color.White;
                lbUnavailable.BackColor = Color.FromArgb(180, Color.Black);
                lbUnavailable.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lbUnavailable.TextAlign = ContentAlignment.MiddleCenter;

                lbUnavailable.BringToFront();
            }
            else
            {
                this.BackColor = SystemColors.Control;
                lbUnavailable.Visible = false;
            }
        }

        public event EventHandler<ProductDTO>? OnProductClicked;

        private void Card_Click(object? sender, EventArgs e)
        {
            if (_product == null)
                return;

            if (!_product.ProductIsAvailable)
                return; // block clicks on unavailable products

            OnProductClicked?.Invoke(this, _product);
        }
    }
}
