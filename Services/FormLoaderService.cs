using Microsoft.Extensions.DependencyInjection;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Forms;

namespace POSpresso.Services
{
    public class FormLoaderService
    {
        private readonly IServiceProvider _serviceProvider;
        public FormLoaderService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void LoadForm<T>(Panel panel) where T : Form
        {
            if (panel.Controls.Count > 0)
                panel.Controls[0].Dispose();

            var form = _serviceProvider.GetRequiredService<T>();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }

        public void LoadDashboard(Form currentForm, User user)
        {
            currentForm.Hide();

            Form dashboardForm = user.Role switch
            {
                UserRole.Admin => _serviceProvider.GetRequiredService<AdminDashboard>(),
                UserRole.Cashier => _serviceProvider.GetRequiredService<CashierDashboard>(),
                _ => throw new Exception("Invalid user role")
            };

            if (dashboardForm is AdminDashboard admin)
                admin.SetCurrentUser(user);
            else if (dashboardForm is CashierDashboard cashier)
                cashier.SetCurrentUser(user);

            dashboardForm.FormClosed += (_, _) => currentForm.Close();
            dashboardForm.Show();
        }
    }
}
