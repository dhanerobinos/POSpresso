using Microsoft.Extensions.DependencyInjection;
using POSpresso.Forms.CashierForms;
using POSpresso.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms.AdminForms
{
    public partial class SettingsForm : Form
    {
        private readonly FormLoaderService _formLoader;
        public SettingsForm(FormLoaderService formLoader)
        {
            InitializeComponent();
            _formLoader = formLoader;
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            _formLoader.LoadForm(SettingsMainPanel, Program.ServiceProvider.GetRequiredService<GeneralSettingsForm>());
        }
    }
}
