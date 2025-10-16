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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            lbFrom = new Label();
            dtpStart = new DateTimePicker();
            btnGenerateReport = new FontAwesome.Sharp.IconButton();
            dtpEnd = new DateTimePicker();
            label1 = new Label();
            dtgvSalesReport = new DataGridView();
            panel1 = new Panel();
            lbTransactions = new Label();
            lbTotal = new Label();
            lbTax = new Label();
            lbSubtotal = new Label();
            btnExport = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dtgvSalesReport).BeginInit();
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
            // dtpStart
            // 
            dtpStart.Location = new Point(82, 45);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(209, 23);
            dtpStart.TabIndex = 1;
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
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(342, 45);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(209, 23);
            dtpEnd.TabIndex = 4;
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
            // dtgvSalesReport
            // 
            dtgvSalesReport.BackgroundColor = Color.Linen;
            dtgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSalesReport.Location = new Point(81, 88);
            dtgvSalesReport.Name = "dtgvSalesReport";
            dtgvSalesReport.Size = new Size(597, 414);
            dtgvSalesReport.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTransactions);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbTax);
            panel1.Controls.Add(lbSubtotal);
            panel1.Location = new Point(82, 508);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 100);
            panel1.TabIndex = 6;
            // 
            // lbTransactions
            // 
            lbTransactions.AutoSize = true;
            lbTransactions.Location = new Point(12, 10);
            lbTransactions.Name = "lbTransactions";
            lbTransactions.Size = new Size(76, 15);
            lbTransactions.TabIndex = 4;
            lbTransactions.Text = "Transactions:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(422, 46);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(36, 15);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "Total:";
            // 
            // lbTax
            // 
            lbTax.AutoSize = true;
            lbTax.Location = new Point(216, 46);
            lbTax.Name = "lbTax";
            lbTax.Size = new Size(27, 15);
            lbTax.TabIndex = 2;
            lbTax.Text = "Tax:";
            // 
            // lbSubtotal
            // 
            lbSubtotal.AutoSize = true;
            lbSubtotal.Location = new Point(77, 46);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(54, 15);
            lbSubtotal.TabIndex = 1;
            lbSubtotal.Text = "Subtotal:";
            // 
            // btnExport
            // 
            btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExport.IconColor = Color.Black;
            btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExport.Location = new Point(557, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(121, 25);
            btnExport.TabIndex = 7;
            btnExport.Text = "Export Report";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(765, 620);
            Controls.Add(btnExport);
            Controls.Add(panel1);
            Controls.Add(dtgvSalesReport);
            Controls.Add(dtpEnd);
            Controls.Add(label1);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpStart);
            Controls.Add(lbFrom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesReportForm";
            Text = "SalesReportForm";
            ((System.ComponentModel.ISupportInitialize)dtgvSalesReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFrom;
        private DateTimePicker dtpStart;
        private FontAwesome.Sharp.IconButton btnGenerateReport;
        private DateTimePicker dtpEnd;
        private Label label1;
        private DataGridView dtgvSalesReport;
        private Panel panel1;
        private Label lbTotal;
        private Label lbTax;
        private Label lbSubtotal;
        private Label lbTransactions;
        private FontAwesome.Sharp.IconButton btnExport;
    }
}