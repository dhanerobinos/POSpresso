using POSpresso.Services;

namespace POSpresso
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public LoginForm(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = tbUsername.Text.Trim();
            var password = tbPassword.Text.Trim();

            var user = await _authService.GetByUsernameAsync(username);
            if (user != null && _authService.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show($"Welcome {user.FirstName} {user.LastName}!", "Login Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
