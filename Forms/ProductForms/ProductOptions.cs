using POSpresso.Domain.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class ProductOptions : Form
    {
        private readonly ProductDTO _product;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
