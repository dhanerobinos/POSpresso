using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POSpresso.Data;
using POSpresso.Services;
using POSpresso.Domain.Entities;
using POSpresso.Forms;
using POSpresso.Forms.AdminForms;

namespace POSpresso
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
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
                    services.AddScoped<FormLoaderService>();

                    // Register forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<AdminDashboard>();
                    services.AddTransient<CashierDashboard>();
                    services.AddTransient<ManageUserForm>();
                    services.AddTransient<ProductForm>();
                })
                .Build();
            ServiceProvider = host.Services;

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

            var loginForm = host.Services.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }
    }
}
