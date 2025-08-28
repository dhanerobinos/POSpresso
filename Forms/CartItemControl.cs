using POSpresso.Domain.DTO; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POSpresso.Forms
{
    public partial class CartItemControl : UserControl
    {
        private CartItem _item;

        public int ProductId => _item.ProductId;
        public string ItemSize => _item.Size;
        public int Quantity => _item.Quantity;
        public decimal Price => _item.Price;
        public decimal SubTotal => _item.SubTotal;
        public CartItem Item => _item;
        public event Action? OnQuantityChanged;

        public CartItemControl(CartItem item)
        {
            InitializeComponent();
            _item = item;
            LoadData();
        }

        public void UpdateQuantity(int delta)
        {
            _item.Quantity += delta;
            LoadData();
            //fire event
            OnQuantityChanged?.Invoke();
        }

        private void LoadData()
        {
            lbDetails.Text = $"{_item.ProductName} ({_item.Size})\n" +
                             $"₱{_item.Price:N2}  x {_item.Quantity} = ₱{_item.SubTotal:N2}";

            if (_item.ProductImage != null)
            {
                using var ms = new MemoryStream(_item.ProductImage);
                pbProductImage.Image = Image.FromStream(ms);
            }
        }

    }
}
