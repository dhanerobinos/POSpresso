using POSpresso.Domain.DTO;
using POSpresso.Domain.Enums;
using System;
using System.Windows.Forms;

namespace POSpresso.Forms.ProductForms
{
    public partial class ProductStatOptionForm : Form
    {
        private readonly ProductDTO _product;
        public event Action<ProductStatus>? OnStatusChanged;

        public ProductStatOptionForm(ProductDTO product)
        {
            InitializeComponent();
            _product = product;

            lbProductName.Text = _product.ProductName;
            if (_product.ProductImage != null)
            {
                using var ms = new MemoryStream(_product.ProductImage);
                pbProduct.Image = Image.FromStream(ms);
            }
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            OnStatusChanged?.Invoke(ProductStatus.Available);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUnavailable_Click(object sender, EventArgs e)
        {
            OnStatusChanged?.Invoke(ProductStatus.Unavailable);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
