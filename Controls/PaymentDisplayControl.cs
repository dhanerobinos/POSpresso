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
        private void Card_Click(object? sender, EventArgs e)
        {
            if (_payment != null)
                OnPaymentClicked?.Invoke(this, _payment);
        }
    }
}
