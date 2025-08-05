using POSpresso.Domain.Entities;
using POSpresso.Services;
using POSpresso.Interfaces;

namespace POSpresso.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly IAuthService _authService;
        private readonly User _user;
        public ChangePasswordForm(IAuthService authService, User user)
        {
            InitializeComponent();
            _authService = authService;
            _user = user;
        }

        private async void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPass = tbNewPassword.Text.Trim();
            string confirmPass = tbConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Both password fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await _authService.UpdatePasswordAsync(_user.UserId, newPass);
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

