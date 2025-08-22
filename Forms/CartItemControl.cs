using POSpresso.Domain.DTO; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POSpresso.Forms
{
    public partial class CartItemControl : UserControl
    {
        private CartItem _item;
        public CartItemControl(CartItem item)
        {
          InitializeComponent();
          _item = item;
          LoadData();
        }
        private void LoadData()
        {
            lbProduct.Text = $"{_item.ProductName} ({_item.Size})";
            lbQty.Text = $"{_item.Quantity} x {_item.Price:C}";
            lbSubTotal.Text = _item.SubTotal.ToString("C");

            if (_item.ProductImage != null)
            {
                using (var ms = new MemoryStream(_item.ProductImage))
                {
                    pbProductImage.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
