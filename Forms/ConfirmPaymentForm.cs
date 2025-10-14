using System;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class ConfirmPaymentForm : Form
    {
        public bool IsConfirmed { get; private set; }

        public ConfirmPaymentForm(decimal totalAmount, string paymentMethod)
        {
            InitializeComponent();
            lbTotal.Text = $"Total: ₱{totalAmount:F2}";
            lbPaymentMethod.Text = $"Payment Method: {paymentMethod}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();
        }
    }
}
