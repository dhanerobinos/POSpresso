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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnProducts = new FontAwesome.Sharp.IconButton();
            adminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // receiptPanel
            // 
            receiptPanel.Location = new Point(928, 58);
            receiptPanel.Name = "receiptPanel";
            receiptPanel.Size = new Size(244, 620);
            receiptPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(317, 58);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(605, 620);
            mainPanel.TabIndex = 1;
            // 
            // adminPanel
            // 
            adminPanel.BackgroundImage = (Image)resources.GetObject("adminPanel.BackgroundImage");
            adminPanel.Controls.Add(iconButton4);
            adminPanel.Controls.Add(iconButton1);
            adminPanel.Controls.Add(iconButton3);
            adminPanel.Controls.Add(iconButton2);
            adminPanel.Controls.Add(btnUsers);
            adminPanel.Controls.Add(btnProducts);
            adminPanel.Location = new Point(130, 58);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(181, 620);
            adminPanel.TabIndex = 2;
            // 
            // iconButton4
            // 
            iconButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton4.BackgroundImage = (Image)resources.GetObject("iconButton4.BackgroundImage");
            iconButton4.FlatStyle = FlatStyle.Popup;
            iconButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(3, 542);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(181, 78);
            iconButton4.TabIndex = 5;
            iconButton4.Text = "Logout";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(181, 78);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "POS";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton3.BackgroundImage = (Image)resources.GetObject("iconButton3.BackgroundImage");
            iconButton3.FlatStyle = FlatStyle.Popup;
            iconButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 336);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(181, 78);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Settings";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton2.BackgroundImage = (Image)resources.GetObject("iconButton2.BackgroundImage");
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(-3, 252);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(184, 78);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Report";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
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
            btnUsers.Size = new Size(181, 78);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "Users";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
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
            btnProducts.Size = new Size(181, 78);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Products";
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
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
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}