using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Helper;
using POSpresso.Interfaces;
using POSpresso.Services;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace POSpresso.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly IManageCategoryService _categoryService;
        private byte[]? selectedCategoryImage;
        private int? selectedCategoryID = null;
        private readonly Form _productform;
        public CategoryForm(IManageCategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }
        public async Task LoadCategoryAsync()
        {
            dtgvCategory.Rows.Clear();

            var categories = await _categoryService.GetAllCategoriesAsync();
            string filter = cbFilterStatus.SelectedItem?.ToString();

            foreach (var category in categories)
            {
                // Filter check
                if (!string.IsNullOrEmpty(filter) &&
                    !category.CategoryStatus.ToString().Equals(filter, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                Image image = null;
                if (category.CategoryImage != null && category.CategoryImage.Length > 0)
                {
                    using var ms = new MemoryStream(category.CategoryImage);
                    image = Image.FromStream(ms);
                }

                dtgvCategory.Rows.Add(
                    image,
                    category.CategoryID,
                    category.CategoryName,
                    category.CategoryStatus.ToString(),
                    category.CategoryImage,   //  raw bytes stored in hidden column,fixed GDI error
                    null
                );
            }
        }

        private void SetupCategoryGridView()
        {
            dtgvCategory.Columns.Clear();
            dtgvCategory.Rows.Clear();

            var imgCol = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Photo",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40
            };
            dtgvCategory.Columns.Add(imgCol);

            dtgvCategory.Columns.Add("CategoryID", "Category ID");
            dtgvCategory.Columns["CategoryID"].Visible = false;

            dtgvCategory.Columns.Add("CategoryName", "Category Name");
            dtgvCategory.Columns["CategoryName"].Width = 100;

            dtgvCategory.Columns.Add("IsActive", "Status");
            dtgvCategory.Columns["IsActive"].Width = 70;

            // 🔹 Add hidden CategoryImage column (for raw bytes)
            var hiddenBytesCol = new DataGridViewTextBoxColumn
            {
                Name = "CategoryImage",
                Visible = false
            };
            dtgvCategory.Columns.Add(hiddenBytesCol);

            dtgvCategory.RowTemplate.Height = 50;
            dtgvCategory.AllowUserToAddRows = false;

            var editCol = new DataGridViewImageColumn
            {
                Name = "EditIcon",
                HeaderText = "",
                Width = 20,
                Image = Properties.Resources.icon_edit16,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dtgvCategory.Columns.Add(editCol);
        }

        private async void PopulateInputsFromRow(DataGridViewRow row)
        {
            selectedCategoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);
            tbCategoryName.Text = row.Cells["CategoryName"].Value?.ToString();

            var imageBytes = row.Cells["CategoryImage"].Value as byte[];
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using var ms = new MemoryStream(imageBytes);
                pbCategoryImage.Image = Image.FromStream(ms);

                selectedCategoryImage = imageBytes;
            }
            else
            {
                pbCategoryImage.Image = null;
                selectedCategoryImage = null;
            }

            cbCategoryStatus.SelectedItem = row.Cells["IsActive"].Value?.ToString();
        }
       

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCategoryName.Text) ||
              (selectedCategoryID == null && selectedCategoryImage == null))
            {
                MessageBox.Show("Please fill in all required fields and add category photo.");
                return;
            }

            try
            {
                var categoryDTO = new ProductCategoryDTO
                {
                    CategoryName = tbCategoryName.Text.Trim(),
                    CategoryStatus = Enum.Parse<ProductCategoryStatusEnum>(
                        cbCategoryStatus.SelectedItem.ToString()
                    )
                };

                if (selectedCategoryImage != null)
                {
                    categoryDTO.CategoryImage = selectedCategoryImage;
                }
                else if (selectedCategoryID != null)
                {
                    var existing = await _categoryService.GetCategoryByIdAsync(selectedCategoryID.Value);
                    categoryDTO.CategoryImage = existing?.CategoryImage;
                }

                if (selectedCategoryID == null)
                {
                    await _categoryService.AddCategoryAsync(categoryDTO);
                    MessageBox.Show("Category added successfully!");
                }
                else
                {
                    categoryDTO.CategoryID = selectedCategoryID.Value;
                    await _categoryService.UpdateCategoryAsync(categoryDTO);
                    MessageBox.Show("Category updated successfully!");
                }

                await LoadCategoryAsync();
                FormHelper.ClearFormInputs(this);
                cbCategoryStatus.SelectedIndex = 0;
                selectedCategoryID = null;
                selectedCategoryImage = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbUploadCategoryImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedCategoryImage = File.ReadAllBytes(openFileDialog.FileName);
                    using var stream = new MemoryStream(selectedCategoryImage);
                    pbCategoryImage.Image = Image.FromStream(stream);
                }
            }
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            cbCategoryStatus.Items.AddRange(Enum.GetNames(typeof(ProductCategoryStatusEnum)));
            SetupCategoryGridView();
            await LoadCategoryAsync();
        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCategory.Columns[e.ColumnIndex].Name == "EditIcon")
            {
                var row = dtgvCategory.Rows[e.RowIndex];
                PopulateInputsFromRow(row);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFormInputs(this);
            selectedCategoryID = null;
            selectedCategoryImage = null;
        }
    }
}
