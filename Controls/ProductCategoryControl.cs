using POSpresso.Domain.DTO;
using System.Windows.Forms;

namespace POSpresso.Controls
{
    public partial class ProductCategoryControl : UserControl
    {
        private ProductCategoryDTO? _category;

        public event EventHandler<ProductCategoryDTO>? OnCategoryClicked;
        public ProductCategoryControl()
        {
            InitializeComponent();
            this.Click += Card_Click;
            lbCategory.Click += Card_Click;
            pbCategory.Click += Card_Click;
        }
        public void SetCategory(ProductCategoryDTO category)
        {
            _category = category;
            lbCategory.Text = category.CategoryName;

            if (category.CategoryImage != null)
            {
                using var ms = new MemoryStream(category.CategoryImage);
                pbCategory.Image = Image.FromStream(ms);
            }

            this.Tag = category.CategoryID;
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (_category != null)
                OnCategoryClicked?.Invoke(this, _category);
        }
    }
}
