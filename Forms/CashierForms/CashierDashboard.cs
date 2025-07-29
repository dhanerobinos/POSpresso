using POSpresso.Domain.Entities;

namespace POSpresso.Forms
{
    public partial class CashierDashboard : Form
    {
        private User _user;
        public CashierDashboard()
        {
            InitializeComponent();
        }
        public void SetCurrentUser(User user)
        {
            _user = user;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
                Application.Restart();
            }
        }
    }
}
