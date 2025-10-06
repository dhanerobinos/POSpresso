namespace POSpresso.Forms.AdminForms
{
    partial class GeneralSettingsForm
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
            label2 = new Label();
            tbCafeName = new TextBox();
            label3 = new Label();
            tbContactNo = new TextBox();
            label4 = new Label();
            tbAddress = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            lbLogo = new LinkLabel();
            btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "General Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 126);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "Cafe Name:";
            // 
            // tbCafeName
            // 
            tbCafeName.Location = new Point(179, 127);
            tbCafeName.Name = "tbCafeName";
            tbCafeName.Size = new Size(152, 23);
            tbCafeName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(67, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "Logo:";
            // 
            // tbContactNo
            // 
            tbContactNo.Location = new Point(179, 214);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(152, 23);
            tbContactNo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 213);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 7;
            label4.Text = "Contact No:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(179, 185);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(152, 23);
            tbAddress.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 184);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 5;
            label5.Text = "Address:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(337, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 112);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.LinkColor = Color.DarkCyan;
            lbLogo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbLogo.Location = new Point(179, 163);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(88, 15);
            lbLogo.TabIndex = 10;
            lbLogo.TabStop = true;
            lbLogo.Text = " ( Browse here )";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(179, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // GeneralSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 438);
            Controls.Add(btnSave);
            Controls.Add(lbLogo);
            Controls.Add(pictureBox1);
            Controls.Add(tbContactNo);
            Controls.Add(label4);
            Controls.Add(tbAddress);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(tbCafeName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneralSettingsForm";
            Text = "GeneralSettingsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbCafeName;
        private Label label3;
        private TextBox tbContactNo;
        private Label label4;
        private TextBox tbAddress;
        private Label label5;
        private PictureBox pictureBox1;
        private LinkLabel lbLogo;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}