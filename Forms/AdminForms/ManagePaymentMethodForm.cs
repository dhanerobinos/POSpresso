using POSpresso.Services;
using POSpresso.Domain.DTO;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSpresso.Forms
{
    public partial class ManagePaymentMethodForm : Form
    {
        private readonly PaymentMethodService _paymentMethodService;
        private int? _editingId = null;
        private byte[]? selectedPaymentImage = null;

        public ManagePaymentMethodForm(PaymentMethodService paymentMethodService)
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

            // ID column (hidden)
            dtgvPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                Visible = false
            });

            // Logo (image) column
            dtgvPaymentMethods.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colLogo",
                HeaderText = "Logo",
                Width = 50,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            // Method name
            dtgvPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMethodName",
                HeaderText = "Method Name",
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Status
            dtgvPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIsEnabled",
                HeaderText = "Status",
                Width = 50
            });

            // Edit button
            dtgvPaymentMethods.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colEdit",
                HeaderText = "",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 50
            });

            // Delete button
            dtgvPaymentMethods.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 50
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
                Image? paymentImage = null;

                // Convert byte[] to Image if exists
                if (m.PaymentImage != null && m.PaymentImage.Length > 0)
                {
                    using var ms = new MemoryStream(m.PaymentImage);
                    paymentImage = Image.FromStream(ms);
                }

                dtgvPaymentMethods.Rows.Add(
                    m.PaymentMethodId,
                    paymentImage,
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
                    cbStatus.Text = method.IsEnabled ? "Active" : "Inactive"; //  Load status
                    btnSave.Text = "Update";
                    selectedPaymentImage = method.PaymentImage;
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
                PaymentMethodId = _editingId ?? 0,
                MethodName = tbPaymentName.Text.Trim(),
                IsEnabled = cbStatus.Text == "Active",          //Save status
                PaymentImage = selectedPaymentImage
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

        private void lbLogo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the image bytes for saving to DB
                    selectedPaymentImage = File.ReadAllBytes(openFileDialog.FileName);

                    // Display the image preview
                    using var stream = new MemoryStream(selectedPaymentImage);
                    pbLogo.Image = Image.FromStream(stream);
                }
            }
        }
    }
}
