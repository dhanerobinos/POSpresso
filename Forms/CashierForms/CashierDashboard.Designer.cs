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
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            mainPanel = new Panel();
            receiptPanel = new Panel();
            cashierPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cashierPanel
            // 
            cashierPanel.BackgroundImage = (Image)resources.GetObject("cashierPanel.BackgroundImage");
            cashierPanel.Controls.Add(iconButton5);
            cashierPanel.Controls.Add(iconButton6);
            cashierPanel.Controls.Add(iconButton10);
            cashierPanel.Location = new Point(119, 50);
            cashierPanel.Name = "cashierPanel";
            cashierPanel.Size = new Size(181, 620);
            cashierPanel.TabIndex = 10;
            // 
            // iconButton5
            // 
            iconButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton5.BackgroundImage = (Image)resources.GetObject("iconButton5.BackgroundImage");
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 542);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(181, 78);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "Logout";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            iconButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton6.BackgroundImage = (Image)resources.GetObject("iconButton6.BackgroundImage");
            iconButton6.FlatStyle = FlatStyle.Popup;
            iconButton6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 171);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(184, 78);
            iconButton6.TabIndex = 4;
            iconButton6.Text = "Take Order";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton10
            // 
            iconButton10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton10.BackgroundImage = (Image)resources.GetObject("iconButton10.BackgroundImage");
            iconButton10.FlatStyle = FlatStyle.Popup;
            iconButton10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            iconButton10.IconColor = Color.Black;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(0, 87);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(184, 78);
            iconButton10.TabIndex = 0;
            iconButton10.Text = "Dashboard";
            iconButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton10.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(306, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(605, 620);
            mainPanel.TabIndex = 8;
            // 
            // receiptPanel
            // 
            receiptPanel.Location = new Point(917, 50);
            receiptPanel.Name = "receiptPanel";
            receiptPanel.Size = new Size(244, 620);
            receiptPanel.TabIndex = 7;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(cashierPanel);
            Controls.Add(mainPanel);
            Controls.Add(receiptPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierForm";
            Text = "CashierForm";
            cashierPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel cashierPanel;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton10;
        private Panel mainPanel;
        private Panel receiptPanel;
    }
}