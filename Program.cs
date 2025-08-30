using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POSpresso.Data;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Forms;
using POSpresso.Forms.AdminForms;
using POSpresso.Interfaces;
using POSpresso.Services;

namespace POSpresso
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }                               // ServiceProvider is used to resolve services and forms
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
                {                                                                                           //Always register DbContext,Services, and Forms in the same order
                    // Register DbContext with config
                    services.AddDbContext<POSDbContext>();

                    // Register services
                    services.AddScoped<AuthService>();
                    services.AddScoped<ProductService>();
                    services.AddScoped<FormLoaderService>();
                    services.AddScoped<ManageUserService>();
                    services.AddScoped<ManageCategoryService>();
                    services.AddScoped<SaleService>();


                    //Interfaces
                    services.AddScoped<IAuthService, AuthService>();
                    services.AddScoped<IManageUserService, ManageUserService>();
                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<IManageCategoryService, ManageCategoryService>();
                    services.AddScoped<ISaleService, SaleService>();

                    // Register forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<AdminDashboard>();
                    services.AddTransient<CashierDashboard>();
                    services.AddTransient<ManageUserForm>();
                    services.AddTransient<ProductForm>();
                    services.AddTransient<POSForm>();
                    services.AddTransient<CategoryForm>();
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
                        Role = UserRole.Admin,
                        Status = UserStatus.Active
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
