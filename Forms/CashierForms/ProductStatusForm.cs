using POSpresso.Controls;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Enums;

using POSpresso.Forms.ProductForms;
using POSpresso.Services;
using System.Windows.Forms;

namespace POSpresso.Forms.CashierForms
{
    public partial class ProductStatusForm : Form
    {
        private readonly ProductService _productService;
        private readonly ProductDTO _product;
        public event Action<ProductStatus> OnStatusChanged;

        public ProductStatusForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            this.Load += ProductStatusForm_Load;
     
        }

        private async Task LoadCategoriesAsync()
        {
            var categories = await _productService.GetAllCategoriesAsync();
            flpCategories.Controls.Clear();

            foreach (var category in categories)
            {
                var control = new ProductCategoryControl();
                control.SetCategory(new ProductCategoryDTO
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    CategoryImage = category.CategoryImage
                });

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

                productControl.OnProductClicked += async (s, p) =>
                {
                    using var statusForm = new ProductStatOptionForm(p);
                    statusForm.OnStatusChanged += async (newStatus) =>
                    {
                        await _productService.UpdateProductStatusAsync(p.ProductId, newStatus);
                        LoadProductsByCategory(categoryId); 
                        MessageBox.Show($"{p.ProductName} marked as {newStatus}.", "Status Updated");
                    };

                    statusForm.ShowDialog();
                };

                flpProducts.Controls.Add(productControl);
            }
        }


        private void Category_Clicked(object? sender, ProductCategoryDTO category)
        {
            LoadProductsByCategory(category.CategoryID);
        }

      
        private async void ProductStatusForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }
    }
}
