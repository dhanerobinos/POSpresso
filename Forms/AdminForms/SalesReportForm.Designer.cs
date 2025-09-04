namespace POSpresso.Forms.AdminForms
{
    partial class SalesReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFrom = new Label();
            dtpFrom = new DateTimePicker();
            btnGenerateReport = new FontAwesome.Sharp.IconButton();
            dtpTo = new DateTimePicker();
            label1 = new Label();
            dgvReport = new DataGridView();
            panel1 = new Panel();
            lbSubtotal = new Label();
            lbTax = new Label();
            lbTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new Point(38, 51);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(38, 15);
            lbFrom.TabIndex = 0;
            lbFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(82, 45);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(209, 23);
            dtpFrom.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGenerateReport.IconColor = Color.Black;
            btnGenerateReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerateReport.Location = new Point(557, 45);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(121, 25);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(342, 45);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(209, 23);
            dtpTo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 51);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 3;
            label1.Text = "To:";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(81, 88);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(597, 414);
            dgvReport.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbTax);
            panel1.Controls.Add(lbSubtotal);
            panel1.Location = new Point(82, 508);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 100);
            panel1.TabIndex = 6;
            // 
            // lbSubtotal
            // 
            lbSubtotal.AutoSize = true;
            lbSubtotal.Location = new Point(16, 26);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(54, 15);
            lbSubtotal.TabIndex = 1;
            lbSubtotal.Text = "Subtotal:";
            // 
            // lbTax
            // 
            lbTax.AutoSize = true;
            lbTax.Location = new Point(155, 26);
            lbTax.Name = "lbTax";
            lbTax.Size = new Size(27, 15);
            lbTax.TabIndex = 2;
            lbTax.Text = "Tax:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(361, 26);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(36, 15);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "Total:";
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(panel1);
            Controls.Add(dgvReport);
            Controls.Add(dtpTo);
            Controls.Add(label1);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpFrom);
            Controls.Add(lbFrom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesReportForm";
            Text = "SalesReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFrom;
        private DateTimePicker dtpFrom;
        private FontAwesome.Sharp.IconButton btnGenerateReport;
        private DateTimePicker dtpTo;
        private Label label1;
        private DataGridView dgvReport;
        private Panel panel1;
        private Label lbTotal;
        private Label lbTax;
        private Label lbSubtotal;
    }
}