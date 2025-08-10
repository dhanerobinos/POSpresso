using POSpresso.Domain.DTO;
using POSpresso.Services;
using POSpresso.Interfaces;


namespace POSpresso.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly IManageCategoryService _categoryService;
        private byte[]? selectedImage;
        public CategoryForm(IManageCategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var newCategory = new ProductCategoryDTO
            {
                CategoryName = tbCategoryName.Text.Trim(),
                CategoryImage = selectedImage
            };

            try
            {
                await _categoryService.AddCategoryAsync(newCategory);
                MessageBox.Show("Category added successfully!");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
