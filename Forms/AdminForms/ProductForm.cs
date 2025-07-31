using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Helper;
using POSpresso.Interfaces;
using POSpresso.Services;
using System;
using System.Threading.Tasks;

namespace POSpresso.Forms
{
    public partial class ProductForm : Form
    {
        private readonly POSDbContext _context;
        private readonly ProductService _productService;
        private readonly FormLoaderService _formLoader;
        private byte[]? selectedProductImage = null;

        public ProductForm(ProductService productService, FormLoaderService formLoader)
        {
            _productService = productService;
            _formLoader = formLoader;
            InitializeComponent();

        }
        public async Task LoadProductsAsync()
        {
            dtgvProducts.Rows.Clear();

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
                Width = 50
            };
            dtgvProducts.Columns.Add(imgCol);
            dtgvProducts.Columns.Add("ProductId", "Product ID");
            dtgvProducts.Columns["ProductId"].Visible = false;
            dtgvProducts.Columns.Add("ProductName", "Product Name");
            dtgvProducts.Columns.Add("ProductDescription", "Description");
            dtgvProducts.Columns.Add("ProductPrice", "Price");
            dtgvProducts.Columns.Add("ProductStatus", "Status");
            dtgvProducts.Columns["ProductName"].Width = 100;
            dtgvProducts.Columns["ProductDescription"].Width = 200;
            dtgvProducts.Columns["ProductPrice"].Width = 80;
            dtgvProducts.Columns["ProductStatus"].Width = 80;
            dtgvProducts.RowTemplate.Height = 50;
            dtgvProducts.AllowUserToAddRows = false;
            var editCol = new DataGridViewImageColumn
            {
                Name = "EditIcon",
                HeaderText = "",
                Width = 30,
                Image = Properties.Resources.icon_edit16,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dtgvProducts.Columns.Add(editCol);
        }

        private void PopulateInputsFromRow(DataGridViewRow row)
        {
            tbProductName.Text = row.Cells["ProductName"].Value?.ToString();
            tbDescription.Text = row.Cells["ProductDescription"].Value?.ToString();
            tbPrice.Text = row.Cells["ProductPrice"].Value?.ToString();
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
                ProductPrice = decimal.Parse(tbPrice.Text.Trim()),
                ProductStatus = (ProductStatus)cbStatus.SelectedItem!,
                CategoryID = selectedCategory.CategoryID,
                ProductImage = selectedProductImage
            };
        }





        private void btnClear_Click(object sender, EventArgs e)
        {

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

            SetupProductGridView();
            await LoadProductsAsync();
        }

        private void dtgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvProducts.Columns[e.ColumnIndex].Name == "EditIcon")
            {
                var row = dtgvProducts.Rows[e.RowIndex];
                PopulateInputsFromRow(row);
            }
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductName.Text) ||
        string.IsNullOrWhiteSpace(tbPrice.Text) ||
        cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            var productDTO = GetProductDTOFromInputs();
            try
            {
                await _productService.AddProductAsync(productDTO);
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
