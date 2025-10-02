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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(btnGeneralSettings);
            panel2.Location = new Point(22, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 67);
            panel2.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(155, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(99, 40);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "General";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(279, 15);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(99, 40);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "General";
            iconButton2.UseVisualStyleBackColor = true;
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
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(22, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(712, 438);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 16);
            label2.Name = "label2";
            label2.Size = new Size(141, 45);
            label2.TabIndex = 1;
            label2.Text = "Settings";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnGeneralSettings;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private Label label2;
    }
}