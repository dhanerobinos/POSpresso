namespace POSpresso.Forms.CashierForms
{
    partial class CashierDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboardForm));
            panel3 = new Panel();
            lbRevenue = new Label();
            lbTransactions = new Label();
            lbTotalSales = new Label();
            BestSellerPanel = new Panel();
            salesChartPanel = new Panel();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(lbRevenue);
            panel3.Controls.Add(lbTransactions);
            panel3.Controls.Add(lbTotalSales);
            panel3.Location = new Point(1, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 92);
            panel3.TabIndex = 10;
            // 
            // lbRevenue
            // 
            lbRevenue.AutoSize = true;
            lbRevenue.BackColor = Color.Transparent;
            lbRevenue.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lbRevenue.ForeColor = SystemColors.ControlLightLight;
            lbRevenue.Location = new Point(480, 59);
            lbRevenue.Name = "lbRevenue";
            lbRevenue.Size = new Size(87, 21);
            lbRevenue.TabIndex = 4;
            lbRevenue.Text = "Revenue:";
            // 
            // lbTransactions
            // 
            lbTransactions.AutoSize = true;
            lbTransactions.BackColor = Color.Transparent;
            lbTransactions.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lbTransactions.ForeColor = SystemColors.ControlLightLight;
            lbTransactions.Location = new Point(248, 59);
            lbTransactions.Name = "lbTransactions";
            lbTransactions.Size = new Size(127, 21);
            lbTransactions.TabIndex = 3;
            lbTransactions.Text = "Transactions:";
            // 
            // lbTotalSales
            // 
            lbTotalSales.AutoSize = true;
            lbTotalSales.BackColor = Color.Transparent;
            lbTotalSales.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lbTotalSales.ForeColor = SystemColors.ControlLightLight;
            lbTotalSales.Location = new Point(23, 59);
            lbTotalSales.Name = "lbTotalSales";
            lbTotalSales.Size = new Size(113, 21);
            lbTotalSales.TabIndex = 2;
            lbTotalSales.Text = "Total Sales:";
            // 
            // BestSellerPanel
            // 
            BestSellerPanel.BackgroundImage = (Image)resources.GetObject("BestSellerPanel.BackgroundImage");
            BestSellerPanel.Location = new Point(400, 217);
            BestSellerPanel.Name = "BestSellerPanel";
            BestSellerPanel.Size = new Size(336, 349);
            BestSellerPanel.TabIndex = 9;
            // 
            // salesChartPanel
            // 
            salesChartPanel.BackgroundImage = (Image)resources.GetObject("salesChartPanel.BackgroundImage");
            salesChartPanel.Location = new Point(11, 217);
            salesChartPanel.Name = "salesChartPanel";
            salesChartPanel.Size = new Size(370, 349);
            salesChartPanel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(218, 15);
            label1.Name = "label1";
            label1.Size = new Size(279, 29);
            label1.TabIndex = 8;
            label1.Text = "Today's Sale Overview";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(109, 182);
            label3.Name = "label3";
            label3.Size = new Size(146, 29);
            label3.TabIndex = 12;
            label3.Text = "Item's Sold";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(431, 182);
            label2.Name = "label2";
            label2.Size = new Size(271, 29);
            label2.TabIndex = 11;
            label2.Text = "Best Selling Products";
            // 
            // CashierDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(749, 581);
            Controls.Add(panel3);
            Controls.Add(BestSellerPanel);
            Controls.Add(salesChartPanel);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierDashboardForm";
            Text = "DashboardForm";
            Load += CashierDashboardForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label lbRevenue;
        private Label lbTransactions;
        private Label lbTotalSales;
        private Panel BestSellerPanel;
        private Panel salesChartPanel;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private Label label2;
    }
}