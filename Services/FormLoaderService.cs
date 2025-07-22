using Microsoft.Extensions.DependencyInjection;
using POSpresso.Forms;
using POSpresso.Domain.Entities;

namespace POSpresso.Services
{
    public class FormLoaderService
    {
        private readonly IServiceProvider _serviceProvider;
        public FormLoaderService(IServiceProvider provider)
        {
            _serviceProvider = provider;
        }
        public void LoadForm(Panel panel, Form form)
        {
            if (panel.Controls.Count > 0)
                panel.Controls[0].Dispose();

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
                "Admin" => _serviceProvider.GetRequiredService<AdminDashboard>(),
                "Cashier" => _serviceProvider.GetRequiredService<CashierDashboard>(),
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
