using POSpresso.Domain.DTO;
using POSpresso.Interfaces;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms.AdminForms
{
    public partial class GeneralSettingsForm : Form
    {
        private readonly ISettingsService _settingsService;
        private SettingsDTO? _currentSettings;

        public GeneralSettingsForm(ISettingsService settingsService)
        {
            InitializeComponent();
            _settingsService = settingsService;
            this.Load += GeneralSettingsForm_Load;
        }

        private async void GeneralSettingsForm_Load(object? sender, EventArgs e)
        {
            _currentSettings = await _settingsService.GetSettingsAsync();

            if (_currentSettings != null)
            {
                tbCafeName.Text = _currentSettings.CafeName;
                tbAddress.Text = _currentSettings.Address;
                tbContactNo.Text = _currentSettings.Contact;
               
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var dto = new SettingsDTO
            {
                CafeName = tbCafeName.Text,
                Address = tbAddress.Text,
                Contact = tbContactNo.Text,
              
            };

            await _settingsService.SaveSettingsAsync(dto);

            MessageBox.Show("Settings saved successfully!", "Settings",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
