using POSpresso.Controls;
using POSpresso.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly IPaymentMethodService _paymentService;
        public int? SelectedPaymentMethodId { get; private set; }
        public PaymentForm(IPaymentMethodService paymentMethodService)
        {
            InitializeComponent();
            _paymentService = paymentMethodService;
        }

        private async void PaymentForm_Load(object sender, EventArgs e)
        {
            var methods = await _paymentService.GetAllAsync();

            foreach (var method in methods)
            {
                var control = new PaymentDisplayControl();
                control.SetPayment(method); // assign the payment to the control
                control.OnPaymentClicked += (s, p) =>
                {
                    SelectedPaymentMethodId = p.PaymentMethodId;
                    this.DialogResult = DialogResult.OK; // closes the form
                };
                flpPayment.Controls.Add(control);
            }
        }
    }
}
