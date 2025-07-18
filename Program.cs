using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POSpresso.Data;
using POSpresso.Services;
using POSpresso.Domain.Entities;
using POSpresso.Forms;

namespace POSpresso
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    // Register DbContext with config
                    services.AddDbContext<POSDbContext>();

                    // Register services
                    services.AddScoped<AuthService>();
                    services.AddScoped<ProductService>();

                    // Register forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<AdminDashboard>();
                    services.AddTransient<CashierDashboard>();  
                })
                .Build();

            ApplicationConfiguration.Initialize();
            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<POSDbContext>();

                if (!db.User.Any(u => u.Username == "admin"))
                {
                    var admin = new User
                    {
                        Username = "admin",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                        FirstName = "Admin",
                        LastName = "User",
                        Role = "Admin"
                    };

                    db.User.Add(admin);
                    db.SaveChanges();
                }
            }

            // Let DI give you the LoginForm
            var loginForm = host.Services.GetRequiredService<LoginForm>();
            Application.Run(loginForm);

            var result = loginForm.DialogResult;

            if (result == DialogResult.OK && loginForm.LoggedInUser != null)
            {
                var user = loginForm.LoggedInUser;
                if (user.Role == "Admin")
                {
                    var dashboard = new AdminDashboard();
                    dashboard.SetCurrentUser(user);
                    Application.Run(dashboard);


                }
                else if (user.Role == "Cashier")
                {
                    var dashboard = new CashierDashboard();
                    dashboard.SetCurrentUser(user);
                    Application.Run(dashboard);
                }
                MessageBox.Show($"Welcome {loginForm.LoggedInUser.FirstName} {loginForm.LoggedInUser.LastName}!", "Login Successful");
            }
            else
            {
                MessageBox.Show("Login failed or cancelled.", "Login Error");
            }
        }
    }
}
