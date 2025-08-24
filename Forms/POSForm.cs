using System.Windows.Forms;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Services;
using POSpresso.Controls;

namespace POSpresso.Forms
{
    public partial class POSForm : Form
    {
        private readonly ProductService _productService;
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
        private void AddToCart(CartItem item)
        {
            //cart control for UI
            var cartControl = new CartItemControl(item);
        }

        private void Product_Clicked(object? sender, ProductDTO product)
        {
            using var optionsForm = new ProductOptions(product);
            optionsForm.OnAddToCart += AddToCart;
            optionsForm.ShowDialog();
        }

        private async void POSForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }
    }
}
