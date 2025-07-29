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
            receiptPanel = new Panel();
            mainPanel = new Panel();
            adminPanel = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnPOS = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnReport = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnProducts = new FontAwesome.Sharp.IconButton();
            adminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // receiptPanel
            // 
            receiptPanel.Location = new Point(986, 58);
            receiptPanel.Name = "receiptPanel";
            receiptPanel.Size = new Size(244, 620);
            receiptPanel.TabIndex = 0;
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
            btnPOS.Location = new Point(0, 0);
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
            btnSettings.Location = new Point(0, 336);
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
            btnReport.Location = new Point(-3, 252);
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
            btnUsers.Location = new Point(0, 168);
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
            btnProducts.Location = new Point(0, 84);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(159, 78);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Products";
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(adminPanel);
            Controls.Add(mainPanel);
            Controls.Add(receiptPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            adminPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel receiptPanel;
        private Panel mainPanel;
        private Panel adminPanel;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnPOS;
    }
}