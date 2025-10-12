namespace POSpresso.Forms
{
    partial class ManagePaymentMethodForm
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
            dtgvPaymentMethods = new DataGridView();
            label7 = new Label();
            label2 = new Label();
            tbPaymentName = new TextBox();
            label5 = new Label();
            tbAddress = new TextBox();
            label4 = new Label();
            btnSave = new FontAwesome.Sharp.IconButton();
            cbStatus = new ComboBox();
            label6 = new Label();
            panel1 = new Panel();
            lbLogo = new LinkLabel();
            pbLogo = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvPaymentMethods).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // dtgvPaymentMethods
            // 
            dtgvPaymentMethods.AllowUserToAddRows = false;
            dtgvPaymentMethods.AllowUserToDeleteRows = false;
            dtgvPaymentMethods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPaymentMethods.Location = new Point(12, 70);
            dtgvPaymentMethods.Name = "dtgvPaymentMethods";
            dtgvPaymentMethods.ReadOnly = true;
            dtgvPaymentMethods.RowHeadersVisible = false;
            dtgvPaymentMethods.Size = new Size(329, 353);
            dtgvPaymentMethods.TabIndex = 24;
            dtgvPaymentMethods.CellContentClick += dtgvPaymentMethods_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(245, 9);
            label7.Name = "label7";
            label7.Size = new Size(220, 32);
            label7.TabIndex = 36;
            label7.Text = "Payment Methods";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 24;
            label2.Text = "Method Name:";
            // 
            // tbPaymentName
            // 
            tbPaymentName.Location = new Point(156, 82);
            tbPaymentName.Name = "tbPaymentName";
            tbPaymentName.Size = new Size(152, 23);
            tbPaymentName.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 120);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 27;
            label5.Text = "Description:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(156, 120);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(152, 23);
            tbAddress.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 169);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 29;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(156, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 23);
            btnSave.TabIndex = 33;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(156, 154);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(152, 23);
            cbStatus.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 149);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 35;
            label6.Text = "Status:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbLogo);
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbPaymentName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(347, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 353);
            panel1.TabIndex = 23;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.LinkColor = Color.DarkCyan;
            lbLogo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbLogo.Location = new Point(186, 246);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(88, 15);
            lbLogo.TabIndex = 38;
            lbLogo.TabStop = true;
            lbLogo.Text = " ( Browse here )";
            lbLogo.LinkClicked += lbLogo_LinkClicked;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(192, 183);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(82, 60);
            pbLogo.TabIndex = 37;
            pbLogo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(8, 196);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 36;
            label3.Text = "Logo:";
            // 
            // ManagePaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(label7);
            Controls.Add(dtgvPaymentMethods);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagePaymentMethodForm";
            Text = "PaymentMethodForm";
            Load += PaymentMethodForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvPaymentMethods).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgvPaymentMethods;
        private Label label7;
        private Label label2;
        private TextBox tbPaymentName;
        private Label label5;
        private TextBox tbAddress;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnSave;
        private ComboBox cbStatus;
        private Label label6;
        private Panel panel1;
        private LinkLabel lbLogo;
        private PictureBox pbLogo;
        private Label label3;
    }
}