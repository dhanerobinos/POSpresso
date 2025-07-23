using POSpresso.Domain.Enums;
using POSpresso.Services;
using POSpresso.Domain.DTO;
using System.Threading.Tasks;
using POSpresso.Helper;

namespace POSpresso.Forms.AdminForms
{
    public partial class ManageUserForm : Form
    {
        private readonly ManageUserService _manageUserService;
        private int? _selectedUserId = null;

        public ManageUserForm(ManageUserService manageUserService)
        {
            InitializeComponent();
            _manageUserService = manageUserService;
            dtgvUsers.SelectionChanged += dgvUsers_SelectionChanged;

        }
        public async Task LoadUsersAsync()
        {
            var users = await _manageUserService.GetAllUsersAsync();

            dtgvUsers.DataSource = users
             .Select(u => new
             {
                 u.UserId,
                 u.Username,
                 u.FirstName,
                 u.LastName,
                 u.Role,
                 u.Status
             })
             .ToList();
            dtgvUsers.Columns["UserId"].Visible = false;

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
                Status = (UserStatus)cbStatus.SelectedItem!
            };
          
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var userDTO = GetUserDTOFromInputs();
            try
            {
                await _manageUserService.AddUserAsync(userDTO);
                MessageBox.Show("User added successfully!");
                await LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Add user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void btnEditUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userDto = GetUserDTOFromInputs();
            userDto.UserId = _selectedUserId.Value;

            try
            {
                await _manageUserService.UpdateUserAsync(userDto);
                MessageBox.Show("User updated successfully!");
                await LoadUsersAsync();
                FormHelper.ClearFormInputs(ManageUserPanel);
                _selectedUserId = null; // reset after update
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (confirm != DialogResult.Yes)
                return;

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearFormInputs(this);
        }

        private void dtgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtgvUsers.Rows[e.RowIndex];
                _selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value); 

                tbUsername.Text = row.Cells["Username"].Value?.ToString();
                tbFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                tbLastName.Text = row.Cells["LastName"].Value?.ToString();
                cbUserRole.SelectedItem = Enum.Parse<UserRole>(row.Cells["Role"].Value?.ToString()!);
                cbStatus.SelectedItem = Enum.Parse<UserStatus>(row.Cells["Status"].Value?.ToString()!);
                tbPassword.Text = "";
            }
        }
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvUsers.CurrentRow == null || dtgvUsers.CurrentRow.Index < 0)
            {
                FormHelper.ClearFormInputs(ManageUserPanel);
                _selectedUserId = null;
                return;
            }
            var row = dtgvUsers.CurrentRow;
            if (row.Cells["UserId"].Value == null)
            {
                FormHelper.ClearFormInputs(ManageUserPanel);
                _selectedUserId = null;
                return;
            }
            _selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);
            tbUsername.Text = row.Cells["Username"].Value?.ToString();
            tbFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            tbLastName.Text = row.Cells["LastName"].Value?.ToString();

            if (Enum.TryParse<UserRole>(row.Cells["Role"].Value?.ToString(), out var role))
            {
                cbUserRole.SelectedItem = role;
            }

            else
            {
                cbUserRole.SelectedIndex = -1;
            }
                

            if (Enum.TryParse<UserStatus>(row.Cells["Status"].Value?.ToString(), out var status))
            {
                cbStatus.SelectedItem = status;
            }

            else
            {
                cbStatus.SelectedIndex = -1;
            }
        }


        private async void ManageUserForm_Load(object sender, EventArgs e)
        {
            cbUserRole.DataSource = Enum.GetValues(typeof(UserRole));
            cbStatus.DataSource = Enum.GetValues(typeof(UserStatus));

            await LoadUsersAsync();

        }
    }
}

