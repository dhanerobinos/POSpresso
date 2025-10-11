namespace POSpresso.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            mainPanel = new Panel();
            adminPanel = new Panel();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnPOS = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnReport = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnProducts = new FontAwesome.Sharp.IconButton();
            fpReceipt = new FlowLayoutPanel();
            btnCheckout = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lbTotal = new Label();
            lbTax = new Label();
            lbSubtotal = new Label();
            adminPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(215, 58);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(765, 620);
            mainPanel.TabIndex = 1;
            // 
            // adminPanel
            // 
            adminPanel.BackgroundImage = (Image)resources.GetObject("adminPanel.BackgroundImage");
            adminPanel.Controls.Add(btnDashboard);
            adminPanel.Controls.Add(btnLogout);
            adminPanel.Controls.Add(btnPOS);
            adminPanel.Controls.Add(btnSettings);
            adminPanel.Controls.Add(btnReport);
            adminPanel.Controls.Add(btnUsers);
            adminPanel.Controls.Add(btnProducts);
            adminPanel.Location = new Point(50, 58);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(161, 620);
            adminPanel.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 30;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(1, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(159, 78);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
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
            btnLogout.Location = new Point(3, 542);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(159, 78);
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
            btnPOS.Location = new Point(3, 89);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(159, 78);
            btnPOS.TabIndex = 4;
            btnPOS.Text = "POS";
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = true;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnSettings
            // 
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.FlatStyle = FlatStyle.Popup;
            btnSettings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnSettings.IconColor = Color.Black;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 425);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(159, 78);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReport
            // 
            btnReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReport.BackgroundImage = (Image)resources.GetObject("btnReport.BackgroundImage");
            btnReport.FlatStyle = FlatStyle.Popup;
            btnReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnReport.IconColor = Color.Black;
            btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 341);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(162, 78);
            btnReport.TabIndex = 2;
            btnReport.Text = "Report";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnUsers
            // 
            btnUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsers.BackgroundImage = (Image)resources.GetObject("btnUsers.BackgroundImage");
            btnUsers.FlatStyle = FlatStyle.Popup;
            btnUsers.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsers.IconColor = Color.Black;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 257);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(159, 78);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "Users";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnProducts
            // 
            btnProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProducts.BackgroundImage = (Image)resources.GetObject("btnProducts.BackgroundImage");
            btnProducts.FlatStyle = FlatStyle.Popup;
            btnProducts.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            btnProducts.IconColor = Color.Black;
            btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(3, 173);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(159, 78);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Products";
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // fpReceipt
            // 
            fpReceipt.Location = new Point(986, 58);
            fpReceipt.Name = "fpReceipt";
            fpReceipt.Size = new Size(256, 463);
            fpReceipt.TabIndex = 3;
            fpReceipt.Paint += fpReceipt_Paint;
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
            btnCheckout.Location = new Point(21, 117);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(231, 40);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbTax);
            panel1.Controls.Add(lbSubtotal);
            panel1.Controls.Add(btnCheckout);
            panel1.Location = new Point(986, 518);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 160);
            panel1.TabIndex = 7;
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
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(fpReceipt);
            Controls.Add(adminPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            adminPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private Panel adminPanel;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnPOS;
        private FlowLayoutPanel fpReceipt;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label lbSubtotal;
        private Label lbTotal;
        private Label lbTax;
        private FontAwesome.Sharp.IconButton btnDashboard;
    }
}