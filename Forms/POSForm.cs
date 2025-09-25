using POSpresso.Controls;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Services;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class POSForm : Form
    {
        private readonly ProductService _productService;
        public event Action<CartItem> OnAddToCart;
        public POSForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            this.Load += POSForm_Load;
        }
        private async Task LoadCategoriesAsync()
        {
            var categories = await _productService.GetAllCategoriesAsync();
            flpCategories.Controls.Clear();

            foreach (var category in categories)
            {
                var categoryDTO = new ProductCategoryDTO
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    CategoryImage = category.CategoryImage
                };

                var control = new ProductCategoryControl();
                control.SetCategory(categoryDTO);

                control.OnCategoryClicked += Category_Clicked;

                flpCategories.Controls.Add(control);
            }
        }
        private async void LoadProductsByCategory(int categoryId)
        {
            var products = await _productService.GetProductsByCategoryAsync(categoryId);

            flpProducts.Controls.Clear();

            foreach (var product in products)
            {
                var productControl = new ProductDisplayControl();
                productControl.SetProduct(product);
                productControl.OnProductClicked += Product_Clicked;

                flpProducts.Controls.Add(productControl);
            }
        }

        private void Category_Clicked(object? sender, ProductCategoryDTO category)
        {
            LoadProductsByCategory(category.CategoryID);
        }

        private void Product_Clicked(object? sender, ProductDTO product)
        {
            if (product.ProductStatus == ProductStatus.Unavailable)
            {
                MessageBox.Show($"{product.ProductName} is currently unavailable.");
                return;
            }

            using var optionsForm = new ProductOptions(product);
            optionsForm.OnAddToCart += (item) =>
            {
                OnAddToCart?.Invoke(item);
            };
            optionsForm.ShowDialog();
        }


        private async void POSForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }
    }
}
