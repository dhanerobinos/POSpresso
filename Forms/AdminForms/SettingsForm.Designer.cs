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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            label1 = new Label();
            btnGeneralSettings = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
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
            btnGeneralSettings.BackColor = Color.Tan;
            btnGeneralSettings.FlatStyle = FlatStyle.Flat;
            btnGeneralSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneralSettings.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGeneralSettings.IconColor = Color.Black;
            btnGeneralSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGeneralSettings.Location = new Point(141, 15);
            btnGeneralSettings.Name = "btnGeneralSettings";
            btnGeneralSettings.Size = new Size(174, 40);
            btnGeneralSettings.TabIndex = 1;
            btnGeneralSettings.Text = "General";
            btnGeneralSettings.UseVisualStyleBackColor = false;
            btnGeneralSettings.Click += btnGeneralSettings_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 67);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnPaymentMethods);
            panel2.Controls.Add(btnGeneralSettings);
            panel2.Location = new Point(22, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 67);
            panel2.TabIndex = 3;
            // 
            // btnPaymentMethods
            // 
            btnPaymentMethods.BackColor = Color.PaleGreen;
            btnPaymentMethods.FlatStyle = FlatStyle.Flat;
            btnPaymentMethods.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentMethods.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPaymentMethods.IconColor = Color.Black;
            btnPaymentMethods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPaymentMethods.Location = new Point(374, 15);
            btnPaymentMethods.Name = "btnPaymentMethods";
            btnPaymentMethods.Size = new Size(174, 40);
            btnPaymentMethods.TabIndex = 2;
            btnPaymentMethods.Text = "Payment Methods";
            btnPaymentMethods.UseVisualStyleBackColor = false;
            btnPaymentMethods.Click += btnPaymentMethods_Click;
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
            BackColor = Color.Linen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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
        private FontAwesome.Sharp.IconButton btnPaymentMethods;
        private Panel SettingsMainPanel;
    }
}