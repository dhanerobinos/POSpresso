using FontAwesome.Sharp;
using POSpresso.Domain.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Controls
{
    public partial class PaymentDisplayControl : UserControl
    {
        private PaymentMethodDTO? _payment;

        public event EventHandler<PaymentMethodDTO>? OnPaymentClicked;
        public PaymentDisplayControl()
        {
            InitializeComponent();
            this.Click += Card_Click;
            lbPaymentOption.Click += Card_Click;
        }
        public void SetPayment(PaymentMethodDTO payment)
        {
            _payment = payment;
            lbPaymentOption.Text = payment.MethodName; 
            if (payment.PaymentImage != null && payment.PaymentImage.Length > 0)
            {
                using var ms = new MemoryStream(payment.PaymentImage);
                pbPaymentLogo.Image = Image.FromStream(ms);
            }
            else
            {
                pbPaymentLogo.Image = null;
            }
            ;
        }
        private void Card_Click(object? sender, EventArgs e)
        {
            if (_payment != null)
                OnPaymentClicked?.Invoke(this, _payment);
        }
    }
}
