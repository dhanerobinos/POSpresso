using POSpresso.Services;
using POSpresso.Domain.DTO;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class PaymentMethodForm : Form
    {
        private readonly PaymentMethodService _paymentMethodService;
        private int? _editingId = null;

        public PaymentMethodForm(PaymentMethodService paymentMethodService)
        {
            InitializeComponent();
            _paymentMethodService = paymentMethodService;
            this.Load += PaymentMethodForm_Load;
        }

        private async void PaymentMethodForm_Load(object sender, EventArgs e)
        {
            cbType.Items.Clear();
            cbType.Items.AddRange(new string[]
            {
                "Cash",
                "GCash",
                "Credit Card",
                "Debit Card",
                "Online Banking",
                "Other"
            });

            await LoadPaymentMethodsAsync();
        }

        private async Task LoadPaymentMethodsAsync()
        {
            var methods = await _paymentMethodService.GetAllAsync();
            dtgvPaymentMethods.Rows.Clear();

            foreach (var m in methods)
            {
                dtgvPaymentMethods.Rows.Add(
                    m.Id,
                    m.MethodName,
                    m.Type,
                    m.IsEnabled ? "Active" : "Inactive",
                    m.IsDefault ? "✔️" : "",
                    "Edit",
                    "Delete"
                );
            }
        }

        private void ResetEditor()
        {
            _editingId = null;
            tbPaymentName.Clear();
            cbType.SelectedIndex = -1;
            
            btnSave.Text = "Save";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPaymentName.Text) || cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new PaymentMethodDTO
            {
                Id = _editingId ?? 0,
                MethodName = tbPaymentName.Text.Trim(),
                Type = cbType.Text,
                
            };

            if (_editingId == null)
                await _paymentMethodService.AddAsync(dto);
            else
                await _paymentMethodService.UpdateAsync(dto);

            await LoadPaymentMethodsAsync();
            ResetEditor();

            MessageBox.Show("Payment method saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void dgvPaymentMethods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = (int)dtgvPaymentMethods.Rows[e.RowIndex].Cells["colId"].Value;

            if (dtgvPaymentMethods.Columns[e.ColumnIndex].Name == "colEdit")
            {
                var method = await _paymentMethodService.GetByIdAsync(id);
                if (method != null)
                {
                    _editingId = id;
                    tbPaymentName.Text = method.MethodName;
                    cbType.Text = method.Type;
                   
                    btnSave.Text = "Update";
                }
            }
            else if (dtgvPaymentMethods.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show("Delete this payment method?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _paymentMethodService.DeleteAsync(id);
                    await LoadPaymentMethodsAsync();
                    ResetEditor();
                }
            }
        }
    }
}
