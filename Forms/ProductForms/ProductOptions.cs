using POSpresso.Domain.DTO;

namespace POSpresso.Forms
{
    public partial class ProductOptions : Form
    {
        public event Action<CartItem>? OnAddToCart;

        private readonly ProductDTO _product;

        private int _mediumQty = 0;
        private int _largeQty = 0;

        public ProductOptions(ProductDTO product)
        {
            InitializeComponent();
            _product = product;

            lbProductName.Text = _product.ProductName;
            lbPrice.Text = $"₱{_product.ProductPrice:N2}";

            if (_product.ProductImage != null)
            {
                using var ms = new MemoryStream(_product.ProductImage);
                pbProduct.Image = Image.FromStream(ms);
            }

            // set at 0
            lblMediumQty.Text = "0";
            lblLargeQty.Text = "0";
        }

        private void btnMediumAdd_Click(object sender, EventArgs e)
        {
            _mediumQty++;
            lblMediumQty.Text = _mediumQty.ToString();
        }

        private void btnMediumMinus_Click(object sender, EventArgs e)
        {
            if (_mediumQty > 0) _mediumQty--;
            lblMediumQty.Text = _mediumQty.ToString();
        }

        private void btnLargeAdd_Click(object sender, EventArgs e)
        {
            _largeQty++;
            lblLargeQty.Text = _largeQty.ToString();
        }

        private void btnLargeMinus_Click(object sender, EventArgs e)
        {
            if (_largeQty > 0) _largeQty--;
            lblLargeQty.Text = _largeQty.ToString();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (_mediumQty == 0 && _largeQty == 0)
            {
                MessageBox.Show("Please select a quantity.");
                return;
            }

            decimal mediumPrice = _product.ProductPrice;
            decimal largePrice = _product.ProductPrice + 30;

            if (_mediumQty > 0)
            {
                OnAddToCart?.Invoke(new CartItem
                {

                    ProductId = _product.ProductId,
                    ProductName = _product.ProductName,
                    Size = "Medium",
                    Quantity = _mediumQty,
                    Price = mediumPrice,
                    ProductImage = _product.ProductImage
                });
            }

            if (_largeQty > 0)
            {
                OnAddToCart?.Invoke(new CartItem
                {
                    ProductId = _product.ProductId,
                    ProductName = _product.ProductName,
                    Size = "Large",
                    Quantity = _largeQty,
                    Price = largePrice,
                    ProductImage = _product.ProductImage
                });
            }

            // reset and close
            _mediumQty = 0; _largeQty = 0;
            lblMediumQty.Text = "0";
            lblLargeQty.Text = "0";
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void lblLargeQty_Click(object sender, EventArgs e)
        {

        }
    }
}
