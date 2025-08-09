using Microsoft.Extensions.DependencyInjection;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Forms.AdminForms;
using POSpresso.Helper;
using POSpresso.Interfaces;
using POSpresso.Services;

namespace POSpresso.Forms
{
    public partial class ProductForm : Form
    {
        private readonly POSDbContext _context;
        private readonly IProductService _productService;
        private readonly FormLoaderService _formLoader;
        private readonly CategoryForm _categoryForm;
        private byte[]? selectedProductImage = null;
        private int? selectedProductId = null;
        public ProductForm(IProductService productService, FormLoaderService formLoader, CategoryForm categoryForm)
        {
            _productService = productService;
            _formLoader = formLoader;
            InitializeComponent();
            _categoryForm = categoryForm;
        }
        public async Task LoadProductsAsync()
        {
            dtgvProducts.Rows.Clear();
            btnDelete.Hide();
            var products = await _productService.GetAllProductsAsync();

            foreach (var product in products)
            {
                Image image = null;

                if (product.ProductImage != null)
                {
                    using (var ms = new MemoryStream(product.ProductImage))
                    {
                        image = Image.FromStream(ms);
                    }
                }

                dtgvProducts.Rows.Add(
                    image,
                    product.ProductId,
                    product.ProductName,
                    product.ProductDescription,
                    product.ProductPrice.ToString("C"),
                    product.ProductCategory.CategoryName,
                    product.ProductStatus.ToString(),
                    product.ProductCreatedAt
                );
            }
        }


        private void SetupProductGridView()
        {
            dtgvProducts.Columns.Clear();
            dtgvProducts.Rows.Clear();
            var imgCol = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Photo",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40
            };
            dtgvProducts.Columns.Add(imgCol);
            dtgvProducts.Columns.Add("ProductId", "Product ID");
            dtgvProducts.Columns["ProductId"].Visible = false;
            dtgvProducts.Columns.Add("ProductName", "Product Name");
            dtgvProducts.Columns["ProductName"].Width = 100;
            dtgvProducts.Columns.Add("ProductDescription", "Description");
            dtgvProducts.Columns["ProductDescription"].Width = 80;
            dtgvProducts.Columns.Add("ProductPrice", "Price");
            dtgvProducts.Columns["ProductPrice"].Width = 50;
            dtgvProducts.Columns.Add("CategoryName", "Category");
            dtgvProducts.Columns["CategoryName"].Width = 50;
            dtgvProducts.Columns.Add("ProductStatus", "Status");
            dtgvProducts.Columns["ProductStatus"].Width = 50;
            dtgvProducts.Columns.Add("CreatedAt", "Created");
            dtgvProducts.Columns["CreatedAt"].Width = 50;
            dtgvProducts.RowTemplate.Height = 50;
            dtgvProducts.AllowUserToAddRows = false;
            var editCol = new DataGridViewImageColumn
            {
                Name = "EditIcon",
                HeaderText = "",
                Width = 20,
                Image = Properties.Resources.icon_edit16,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dtgvProducts.Columns.Add(editCol);
        }

        private void PopulateInputsFromRow(DataGridViewRow row)
        {
            selectedProductId = row.Cells["ProductId"].Value as int?;
            tbProductName.Text = row.Cells["ProductName"].Value?.ToString();
            tbDescription.Text = row.Cells["ProductDescription"].Value?.ToString();
            tbPrice.Text = $"{decimal.Parse(row.Cells["ProductPrice"].Value?.ToString()?.Replace("₱", "") ?? "0"):C}";
            cbStatus.SelectedItem = Enum.TryParse<ProductStatus>(row.Cells["ProductStatus"].Value?.ToString(), out var status) ? status : null;
            var selectedCategoryName = row.Cells["CategoryName"].Value?.ToString();
            if (selectedCategoryName != null)
            {
                foreach (ProductCategory category in cbCategory.Items)
                {
                    if (category.CategoryName == selectedCategoryName)
                    {
                        cbCategory.SelectedItem = category;
                        break;
                    }
                }
            }
            else
            {
                cbCategory.SelectedItem = null;
            }

            if (row.Cells["Image"].Value is Image img)
            {
                using var ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                selectedProductImage = ms.ToArray();
            }
        }

        private ProductDTO GetProductDTOFromInputs()
        {
            var selectedCategory = cbCategory.SelectedItem as ProductCategory;

            if (selectedCategory == null)
                throw new InvalidOperationException("Selected category is invalid.");

            return new ProductDTO
            {
                ProductName = tbProductName.Text.Trim(),
                ProductDescription = tbDescription.Text.Trim(),
                ProductPrice = decimal.Parse(tbPrice.Text.Replace("₱", "").Trim()),
                ProductStatus = (ProductStatus)cbStatus.SelectedItem!,
                CategoryID = selectedCategory.CategoryID,
                ProductImage = selectedProductImage
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFormInputs(this);
            selectedProductId = null;
            selectedProductImage = null;
        }

        private void lbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedProductImage = File.ReadAllBytes(openFileDialog.FileName);
                    using var stream = new MemoryStream(selectedProductImage);
                    pbProductImage.Image = Image.FromStream(stream);
                }
            }
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            //enum
            cbStatus.DataSource = Enum.GetValues(typeof(ProductStatus));

            //DB
            cbCategory.DataSource = await _productService.GetAllCategoriesAsync();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            //Events
            tbPrice.Enter += (s, ev) => FormHelper.StripCurrency(tbPrice);
            tbPrice.Leave += (s, ev) => FormHelper.ApplyCurrency(tbPrice);

            SetupProductGridView();
            await LoadProductsAsync();
        }

        private void dtgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvProducts.Columns[e.ColumnIndex].Name == "EditIcon")
            {
                var row = dtgvProducts.Rows[e.RowIndex];
                PopulateInputsFromRow(row);
                btnDelete.Show();
            }
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductName.Text) ||
                string.IsNullOrWhiteSpace(tbPrice.Text) ||
                cbCategory.SelectedItem == null ||
                (selectedProductId == null && selectedProductImage == null))
            {
                MessageBox.Show("Please fill in all required fields and add product photo.");
                return;
            }
            try
            {
                var productDto = GetProductDTOFromInputs();

                if (selectedProductId == null)
                {
                    await _productService.AddProductAsync(productDto);
                    MessageBox.Show("Product added successfully!");
                }
                else
                {

                    productDto.ProductId = selectedProductId.Value;
                    await _productService.UpdateProductAsync(productDto);
                    MessageBox.Show("Product updated successfully!");
                }

                await LoadProductsAsync();
                FormHelper.ClearFormInputs(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == null)
            {
                MessageBox.Show("No product selected for deletion.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure you want to delete this product? Only Delete when if product is added by mistake", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _productService.DeleteProductAsync(selectedProductId.Value);
                    MessageBox.Show("Product deleted successfully!");
                    await LoadProductsAsync();
                    FormHelper.ClearFormInputs(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tbPrice_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            ProductsPanel.Show();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _categoryForm.ShowDialog();
        }
    }
}
