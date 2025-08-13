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
        private int? _selectedCategoryID = null;
        public CategoryForm(IManageCategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }
        public async Task LoadCategoryAsync()
        {
            dtgvCategory.Rows.Clear();

            var category = await _categoryService.GetAllCategoriesAsync();
            string filter = cbFilterStatus.SelectedItem?.ToString();
            foreach (var categories in category)
            {
                if (filter == "Active" && !categories.IsActive) continue;
                if (filter == "Inactive" && categories.IsActive) continue;

                Image image = null;
                if (categories.CategoryImage != null)
                {
                    using (var ms = new MemoryStream(categories.CategoryImage))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                dtgvCategory.Rows.Add(
                    image,
                    categories.CategoryID,
                    categories.CategoryName,
                    categories.IsActive ? "Active" : "Inactive"
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

        private void PopulateInputsFromRow(DataGridViewRow row)
        {
            _selectedCategoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);
            tbCategoryName.Text = row.Cells["CategoryName"].Value?.ToString();
            pbCategoryImage.Image = row.Cells["Image"].Value as Image;
            
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCategoryName.Text) ||
               (_selectedCategoryID == null && selectedCategoryImage == null))
            {
                MessageBox.Show("Please fill in all required fields and add category photo.");
                return;
            }

            try
            {
                var categoryDTO = new ProductCategoryDTO
                {
                    CategoryName = tbCategoryName.Text.Trim(),
                    CategoryImage = selectedCategoryImage,
                    IsActive = cbCategoryStatus.SelectedItem?.ToString() == "Active"
                };

                if (_selectedCategoryID == null)
                {
                    await _categoryService.AddCategoryAsync(categoryDTO);
                    MessageBox.Show("Category added successfully!");
                }
                else
                {
                    categoryDTO.CategoryID = _selectedCategoryID.Value;
                    await _categoryService.UpdateCategoryAsync(categoryDTO);
                    MessageBox.Show("Category updated successfully!");
                }

                await LoadCategoryAsync();
                FormHelper.ClearFormInputs(this);
                cbCategoryStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
