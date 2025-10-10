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
        private void SetupDataGridView()
        {
            dtgvPaymentMethods.Columns.Clear();
            dtgvPaymentMethods.AutoGenerateColumns = false;
            dtgvPaymentMethods.AllowUserToAddRows = false;
            dtgvPaymentMethods.ReadOnly = true;

            dtgvPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                Visible = false
            });

            dtgvPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colMethodName", 
                HeaderText = "Method Name", 
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
            });
            dtgvPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIsEnabled",
                HeaderText = "Status",
                Width = 100
            });

            dtgvPaymentMethods.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colEdit",
                HeaderText = "",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 70
            });

            dtgvPaymentMethods.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 70
            });
        }

        private async void PaymentMethodForm_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new string[] { "Active", "Inactive" }); 

            SetupDataGridView();
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
            cbStatus.SelectedIndex = -1;

            btnSave.Text = "Save";
        }



        private async void dtgvPaymentMethods_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    cbStatus.Text = method.IsEnabled ? "Active" : "Inactive"; // ✅ Load status
                    btnSave.Text = "Update";
                }
            }
            else if (dtgvPaymentMethods.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show("Delete this payment method?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _paymentMethodService.DeleteAsync(id);
                    await LoadPaymentMethodsAsync();
                    ResetEditor();
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPaymentName.Text) || cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new PaymentMethodDTO
            {
                Id = _editingId ?? 0,
                MethodName = tbPaymentName.Text.Trim(),
                IsEnabled = cbStatus.Text == "Active" // ✅ Save status
            };

            if (_editingId == null)
                await _paymentMethodService.AddAsync(dto);
            else
                await _paymentMethodService.UpdateAsync(dto);

            await LoadPaymentMethodsAsync();
            ResetEditor();

            MessageBox.Show("Payment method saved successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
