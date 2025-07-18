using POSpresso.Domain.Entities;

namespace POSpresso.Forms
{
    public partial class AdminDashboard : Form
    {
        private User _user;
        public AdminDashboard()
        {
            InitializeComponent();
        }
        public void SetCurrentUser(User user)
        {
            _user = user;
            
        }
        private void MainForm(Form childForm)
        {
            mainPanel.Controls.Clear(); // Remove existing controls
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MainForm(new ProductForm());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
