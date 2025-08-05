using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.Entities;
using POSpresso.Forms;
using POSpresso.Helper;
using POSpresso.Interfaces;
using POSpresso.Services;
using System.Linq;

namespace POSpresso
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly FormLoaderService _formLoader;
        public User? LoggedInUser { get; private set; }

        public LoginForm(IAuthService authService, FormLoaderService formLoaderService)
        {
            InitializeComponent();
            _authService = authService;
            _formLoader = formLoaderService;
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = await _authService.GetByUsernameAsync(username);

            if (user != null && _authService.VerifyPassword(password, user.PasswordHash))
            {
                if (user.RequiresPasswordChange)
                {
                    var changePasswordForm = new ChangePasswordForm(_authService, user);
                    var result = changePasswordForm.ShowDialog();

                    if (result != DialogResult.OK)
                    {
                        MessageBox.Show("You must change your password to proceed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                _formLoader.LoadDashboard(this, user);
                FormHelper.ClearFormInputs(this);
                return;
            }

            MessageBox.Show("Invalid username or password, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
