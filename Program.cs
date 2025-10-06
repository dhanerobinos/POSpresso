using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POSpresso.Data;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Forms;
using POSpresso.Forms.AdminForms;
using POSpresso.Forms.CashierForms;
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
                                                                                                            // Get connection string from appsettings.json
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                    // Register DbContext with config
                    services.AddDbContextFactory<POSDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Register services
                    services.AddScoped<AuthService>();
                    services.AddScoped<ProductService>();
                    services.AddScoped<FormLoaderService>();
                    services.AddScoped<ManageUserService>();
                    services.AddScoped<ManageCategoryService>();
                    services.AddScoped<SaleService>();
                    services.AddScoped<DashboardService>();
                    services.AddScoped<SettingsService>();


                    //Interfaces
                    services.AddScoped<IAuthService, AuthService>();
                    services.AddScoped<IManageUserService, ManageUserService>();
                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<IManageCategoryService, ManageCategoryService>();
                    services.AddScoped<ISaleService, SaleService>();
                    services.AddScoped<ISettingsService, SettingsService>();




                    // Register forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<AdminDashboard>();
                    services.AddTransient<CashierDashboard>();
                    services.AddTransient<ManageUserForm>();
                    services.AddTransient<ProductForm>();
                    services.AddTransient<POSForm>();
                    services.AddTransient<CategoryForm>();
                    services.AddTransient<SalesReportForm>();
                    services.AddTransient<DashboardForm>();
                    services.AddTransient<CashierDashboardForm>();
                    services.AddTransient<ProductStatusForm>();
                    services.AddTransient<SettingsForm>();
                    services.AddTransient<GeneralSettingsForm>();
                    services.AddTransient<PaymentMethodForm>();
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
