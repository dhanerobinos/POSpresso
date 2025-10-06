using Microsoft.Extensions.DependencyInjection;
using POSpresso.Forms.AdminForms;
using POSpresso.Services;


namespace POSpresso.Forms.AdminForms
{
    public partial class SettingsForm : Form
    {
        private readonly FormLoaderService _formLoader;
        private readonly SettingsService _settingsService;  
        public SettingsForm(FormLoaderService formLoader)
        {
            InitializeComponent();
            _formLoader = formLoader;
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(SettingsMainPanel, Program.ServiceProvider.GetRequiredService<GeneralSettingsForm>());
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(SettingsMainPanel, Program.ServiceProvider.GetRequiredService<PaymentMethodForm>());
        }
    }
}
