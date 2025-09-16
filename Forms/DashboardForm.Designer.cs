namespace POSpresso.Forms
{
    partial class DashboardForm
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
            salesChartPanel = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            lbRevenue = new Label();
            lbTransactions = new Label();
            lbTotalSales = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            salesChartPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // salesChartPanel
            // 
            salesChartPanel.Controls.Add(label3);
            salesChartPanel.Location = new Point(2, 185);
            salesChartPanel.Name = "salesChartPanel";
            salesChartPanel.Size = new Size(424, 395);
            salesChartPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(154, 4);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 6;
            label3.Text = "Sales Chart:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(423, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 395);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(124, 4);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 5;
            label2.Text = "Top Products:";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbRevenue);
            panel3.Controls.Add(lbTransactions);
            panel3.Controls.Add(lbTotalSales);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 177);
            panel3.TabIndex = 2;
            // 
            // lbRevenue
            // 
            lbRevenue.AutoSize = true;
            lbRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbRevenue.Location = new Point(477, 87);
            lbRevenue.Name = "lbRevenue";
            lbRevenue.Size = new Size(80, 21);
            lbRevenue.TabIndex = 4;
            lbRevenue.Text = "Revenue:";
            // 
            // lbTransactions
            // 
            lbTransactions.AutoSize = true;
            lbTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbTransactions.Location = new Point(245, 87);
            lbTransactions.Name = "lbTransactions";
            lbTransactions.Size = new Size(109, 21);
            lbTransactions.TabIndex = 3;
            lbTransactions.Text = "Transactions:";
            // 
            // lbTotalSales
            // 
            lbTotalSales.AutoSize = true;
            lbTotalSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbTotalSales.Location = new Point(20, 87);
            lbTotalSales.Name = "lbTotalSales";
            lbTotalSales.Size = new Size(95, 21);
            lbTotalSales.TabIndex = 2;
            lbTotalSales.Text = "Total Sales:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(535, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 581);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(salesChartPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            salesChartPanel.ResumeLayout(false);
            salesChartPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel salesChartPanel;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label lbRevenue;
        private Label lbTransactions;
        private Label lbTotalSales;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private Label label2;
    }
}