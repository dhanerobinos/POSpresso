using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.Entities;
using POSpresso.Forms.AdminForms;
using POSpresso.Services;

namespace POSpresso.Forms
{
    public partial class AdminDashboard : Form
    {
        private User? _user;
        private readonly IServiceProvider _serviceProvider;
        private readonly FormLoaderService _formLoader;
        public AdminDashboard(FormLoaderService formLoader)
        {
            InitializeComponent();
            _formLoader = formLoader;
        }
        public void SetCurrentUser(User user)
        {
            _user = user;
            
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<POSForm>());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<ProductForm>());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(mainPanel, Program.ServiceProvider.GetRequiredService<ManageUserForm>());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }
    }
}
