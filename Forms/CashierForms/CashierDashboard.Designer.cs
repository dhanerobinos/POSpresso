namespace POSpresso.Forms
{
    partial class CashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            cashierPanel = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnPOS = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            mainPanel = new Panel();
            panel1 = new Panel();
            lbTotal = new Label();
            lbTax = new Label();
            lbSubtotal = new Label();
            btnCheckout = new FontAwesome.Sharp.IconButton();
            fpReceipt = new FlowLayoutPanel();
            cashierPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cashierPanel
            // 
            cashierPanel.BackgroundImage = (Image)resources.GetObject("cashierPanel.BackgroundImage");
            cashierPanel.Controls.Add(btnLogout);
            cashierPanel.Controls.Add(btnPOS);
            cashierPanel.Controls.Add(btnDashboard);
            cashierPanel.Location = new Point(50, 58);
            cashierPanel.Name = "cashierPanel";
            cashierPanel.Size = new Size(181, 620);
            cashierPanel.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnLogout.IconColor = Color.Black;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 542);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 78);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPOS
            // 
            btnPOS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPOS.BackgroundImage = (Image)resources.GetObject("btnPOS.BackgroundImage");
            btnPOS.FlatStyle = FlatStyle.Popup;
            btnPOS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPOS.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPOS.IconColor = Color.Black;
            btnPOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOS.Location = new Point(0, 171);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(184, 78);
            btnPOS.TabIndex = 4;
            btnPOS.Text = "Take Order";
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = true;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 87);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 78);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(234, 58);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(765, 620);
            mainPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbTax);
            panel1.Controls.Add(lbSubtotal);
            panel1.Controls.Add(btnCheckout);
            panel1.Location = new Point(1005, 518);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 160);
            panel1.TabIndex = 11;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbTotal.Location = new Point(21, 82);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(56, 21);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "Total:";
            // 
            // lbTax
            // 
            lbTax.AutoSize = true;
            lbTax.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbTax.Location = new Point(21, 54);
            lbTax.Name = "lbTax";
            lbTax.Size = new Size(44, 21);
            lbTax.TabIndex = 7;
            lbTax.Text = "Tax:";
            // 
            // lbSubtotal
            // 
            lbSubtotal.AutoSize = true;
            lbSubtotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbSubtotal.Location = new Point(21, 22);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(86, 21);
            lbSubtotal.TabIndex = 6;
            lbSubtotal.Text = "Subtotal: ";
            // 
            // btnCheckout
            // 
            btnCheckout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCheckout.BackColor = Color.LightGreen;
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnCheckout.IconColor = Color.Black;
            btnCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCheckout.IconSize = 40;
            btnCheckout.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckout.Location = new Point(104, 117);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(148, 39);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // fpReceipt
            // 
            fpReceipt.Location = new Point(1005, 58);
            fpReceipt.Name = "fpReceipt";
            fpReceipt.Size = new Size(252, 454);
            fpReceipt.TabIndex = 12;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(fpReceipt);
            Controls.Add(panel1);
            Controls.Add(cashierPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierDashboard";
            Text = "CashierForm";
            cashierPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel cashierPanel;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnPOS;
        private Panel mainPanel;
        private Panel panel1;
        private Label lbTotal;
        private Label lbTax;
        private Label lbSubtotal;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private FlowLayoutPanel fpReceipt;
        private FontAwesome.Sharp.IconButton btnDashboard;
    }
}