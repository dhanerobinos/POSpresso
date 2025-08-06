using POSpresso.Domain.DTO;


namespace POSpresso
{
    public partial class ProductDisplayControl : UserControl
    {
        private ProductDTO? _product;

        public ProductDisplayControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void SetProduct(ProductDTO product)
        {
            _product = product;
            lblProductName.Text = product.ProductName;
            lblPrice.Text = $"₱{product.ProductPrice:N2}";

            if (product.ProductImage != null)
            {
                using var ms = new MemoryStream(product.ProductImage);
                pbProduct.Image = Image.FromStream(ms);
            }

            // You can also set tooltip, description, or color based on status
            this.Enabled = product.ProductIsAvailable;
            this.Tag = product.ProductId;
        }

        public event EventHandler<ProductDTO>? OnProductClicked;

        private void Card_Click(object? sender, EventArgs e)
        {
            if (_product != null)
                OnProductClicked?.Invoke(this, _product);
        }
    }
}
