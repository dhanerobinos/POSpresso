using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Helper;
using POSpresso.Services;

namespace POSpresso.Forms.AdminForms
{
    public partial class ManageUserForm : Form
    {
        private readonly ManageUserService _manageUserService;
        private int? _selectedUserId = null;
        private byte[]? selectedUserImage = null;
        private readonly FormLoaderService _formLoader;
        public ManageUserForm(ManageUserService manageUserService, FormLoaderService formLoader)
        {
            InitializeComponent();
            _manageUserService = manageUserService;
            _formLoader = formLoader;
        }

        private void SetupUserGridView()
        {
            dtgvUsers.Columns.Clear();
            dtgvUsers.Rows.Clear();

            var imgCol = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Photo",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            };
            dtgvUsers.Columns.Add(imgCol);

            dtgvUsers.Columns.Add("UserId", "User ID");
            dtgvUsers.Columns["UserId"].Visible = false;

            dtgvUsers.Columns.Add("Username", "Username");
            dtgvUsers.Columns.Add("FirstName", "First Name");
            dtgvUsers.Columns.Add("LastName", "Last Name");
            dtgvUsers.Columns.Add("Role", "Role");
            dtgvUsers.Columns.Add("Status", "Status");

            dtgvUsers.Columns["Username"].Width = 100;
            dtgvUsers.Columns["FirstName"].Width = 100;
            dtgvUsers.Columns["LastName"].Width = 100;
            dtgvUsers.Columns["Role"].Width = 50;
            dtgvUsers.Columns["Status"].Width = 60;

            dtgvUsers.RowTemplate.Height = 50;
            dtgvUsers.AllowUserToAddRows = false;

            var editCol = new DataGridViewImageColumn
            {
                Name = "EditIcon",
                HeaderText = "",
                Width = 30,
                Image = Properties.Resources.icon_edit16,
                ToolTipText = "Edit User"
            };
            dtgvUsers.Columns.Add(editCol);

            dtgvUsers.RowTemplate.Height = 50;
            dtgvUsers.AllowUserToAddRows = false;
        }
        private void PopulateInputsFromRow(DataGridViewRow row)
        {
            _selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);
            tbUsername.Text = row.Cells["Username"].Value?.ToString();
            tbFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            tbLastName.Text = row.Cells["LastName"].Value?.ToString();
            cbUserRole.SelectedItem = Enum.TryParse<UserRole>(row.Cells["Role"].Value?.ToString(), out var role) ? role : null;
            cbStatus.SelectedItem = Enum.TryParse<UserStatus>(row.Cells["Status"].Value?.ToString(), out var status) ? status : null;
            UserPhotoBox.Image = row.Cells["Image"].Value as Image;
        }

        public async Task LoadUsersAsync()
        {
            dtgvUsers.Rows.Clear();
            var users = await _manageUserService.GetAllUsersAsync();
            foreach (var user in users)
            {
                Image? img = null;
                if (user.UserImage != null)
                {
                    using var ms = new MemoryStream(user.UserImage);
                    img = Image.FromStream(ms);
                }

                dtgvUsers.Rows.Add(
                    img,
                    user.UserId,
                    user.Username,
                    user.FirstName,
                    user.LastName,
                    user.Role,
                    user.Status
                );
            }

        }

        private UserDTO GetUserDTOFromInputs()
        {
            return new UserDTO
            {
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Role = (UserRole)cbUserRole.SelectedItem!,
                Status = (UserStatus)cbStatus.SelectedItem!,
                UserImage = selectedUserImage
            };

        }
        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // require password for new users
            if (_selectedUserId == null && string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var userDTO = GetUserDTOFromInputs();
                userDTO.UserId = _selectedUserId ?? 0;

                if (_selectedUserId == null)
                {
                    await _manageUserService.AddUserAsync(userDTO);
                    MessageBox.Show("User added successfully!");
                }
                else
                {
                    //updates password if changed
                    if (string.IsNullOrWhiteSpace(tbPassword.Text))
                    {
                        userDTO.Password = null; 
                    }

                    await _manageUserService.UpdateUserAsync(userDTO);
                    MessageBox.Show("User updated successfully!");
                }

                await LoadUsersAsync();
                FormHelper.ClearFormInputs(ManageUserPanel);
                _selectedUserId = null;
                selectedUserImage = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user? Only Delete if this user is added by mistake", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    await _manageUserService.DeleteUserAsync(_selectedUserId.Value);
                    MessageBox.Show("User deleted successfully!");
                    await LoadUsersAsync();
                    FormHelper.ClearFormInputs(this);
                    tbPassword.Text = "";
                    _selectedUserId = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFormInputs(this);
            btnChangePassword.Visible = false;
            tbPassword.Visible = true;
            _selectedUserId = null;
        }
        private void dtgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvUsers.Columns[e.ColumnIndex].Name == "EditIcon")
            {
                var row = dtgvUsers.Rows[e.RowIndex];
                PopulateInputsFromRow(row);
                ManageUserPanel.Visible = true;
                tbPassword.Visible = false;
                btnDeleteUser.Visible = true;
                btnChangePassword.Visible = true;
            }
        }

        private async void ManageUserForm_Load(object sender, EventArgs e)
        {
            cbUserRole.DataSource = Enum.GetValues(typeof(UserRole));
            cbStatus.DataSource = Enum.GetValues(typeof(UserStatus));

            SetupUserGridView();
            await LoadUsersAsync();
        }

        private void lbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedUserImage = File.ReadAllBytes(openFileDialog.FileName);
                    using var stream = new MemoryStream(selectedUserImage);
                    UserPhotoBox.Image = Image.FromStream(stream);
                }
            }
        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            ManageUserPanel.Visible = true;
            btnDeleteUser.Visible = false;
            btnChangePassword.Visible = false;
            tbPassword.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            tbPassword.Visible = true;
            btnChangePassword.Visible = false;
        }
    }
}

