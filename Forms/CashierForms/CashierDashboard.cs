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
    }
}
