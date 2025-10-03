namespace POSpresso.Forms.AdminForms
{
    partial class SettingsForm
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
            label1 = new Label();
            btnGeneralSettings = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnDiscounts = new FontAwesome.Sharp.IconButton();
            btnPaymentMethods = new FontAwesome.Sharp.IconButton();
            SettingsMainPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // btnGeneralSettings
            // 
            btnGeneralSettings.FlatStyle = FlatStyle.Flat;
            btnGeneralSettings.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGeneralSettings.IconColor = Color.Black;
            btnGeneralSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGeneralSettings.Location = new Point(27, 15);
            btnGeneralSettings.Name = "btnGeneralSettings";
            btnGeneralSettings.Size = new Size(99, 40);
            btnGeneralSettings.TabIndex = 1;
            btnGeneralSettings.Text = "General";
            btnGeneralSettings.UseVisualStyleBackColor = true;
            btnGeneralSettings.Click += btnGeneralSettings_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 67);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(btnDiscounts);
            panel2.Controls.Add(btnPaymentMethods);
            panel2.Controls.Add(btnGeneralSettings);
            panel2.Location = new Point(22, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 67);
            panel2.TabIndex = 3;
            // 
            // iconButton3
            // 
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(393, 15);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(99, 40);
            iconButton3.TabIndex = 4;
            iconButton3.Text = "General";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnDiscounts
            // 
            btnDiscounts.FlatStyle = FlatStyle.Flat;
            btnDiscounts.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDiscounts.IconColor = Color.Black;
            btnDiscounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDiscounts.Location = new Point(279, 15);
            btnDiscounts.Name = "btnDiscounts";
            btnDiscounts.Size = new Size(99, 40);
            btnDiscounts.TabIndex = 3;
            btnDiscounts.Text = "Discounts";
            btnDiscounts.UseVisualStyleBackColor = true;
            // 
            // btnPaymentMethods
            // 
            btnPaymentMethods.FlatStyle = FlatStyle.Flat;
            btnPaymentMethods.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPaymentMethods.IconColor = Color.Black;
            btnPaymentMethods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPaymentMethods.Location = new Point(155, 15);
            btnPaymentMethods.Name = "btnPaymentMethods";
            btnPaymentMethods.Size = new Size(99, 40);
            btnPaymentMethods.TabIndex = 2;
            btnPaymentMethods.Text = "Payment Methods";
            btnPaymentMethods.UseVisualStyleBackColor = true;
            // 
            // SettingsMainPanel
            // 
            SettingsMainPanel.Location = new Point(22, 158);
            SettingsMainPanel.Name = "SettingsMainPanel";
            SettingsMainPanel.Size = new Size(712, 438);
            SettingsMainPanel.TabIndex = 3;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(SettingsMainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnGeneralSettings;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnDiscounts;
        private FontAwesome.Sharp.IconButton btnPaymentMethods;
        private Panel SettingsMainPanel;
    }
}