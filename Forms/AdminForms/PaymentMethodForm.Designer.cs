namespace POSpresso.Forms
{
    partial class PaymentMethodForm
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
            label2 = new Label();
            tbCafeName = new TextBox();
            label3 = new Label();
            label5 = new Label();
            tbAddress = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lbLogo = new LinkLabel();
            btnSave = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 67);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 24;
            label2.Text = "Method Name:";
            // 
            // tbCafeName
            // 
            tbCafeName.Location = new Point(194, 67);
            tbCafeName.Name = "tbCafeName";
            tbCafeName.Size = new Size(152, 23);
            tbCafeName.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(44, 95);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 26;
            label3.Text = "Logo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 125);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 27;
            label5.Text = "Description:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(194, 125);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(152, 23);
            tbAddress.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 154);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(352, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 112);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.LinkColor = Color.DarkCyan;
            lbLogo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbLogo.Location = new Point(194, 103);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(88, 15);
            lbLogo.TabIndex = 32;
            lbLogo.TabStop = true;
            lbLogo.Text = " ( Browse here )";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(194, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 23);
            btnSave.TabIndex = 33;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lbLogo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbCafeName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(314, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 353);
            panel1.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 154);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 35;
            label6.Text = "Status:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(296, 353);
            dataGridView1.TabIndex = 24;
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
            // PaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentMethodForm";
            Text = "PaymentMethodForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tbCafeName;
        private Label label3;
        private Label label5;
        private TextBox tbAddress;
        private Label label4;
        private PictureBox pictureBox1;
        private LinkLabel lbLogo;
        private FontAwesome.Sharp.IconButton btnSave;
        private Panel panel1;
        private Label label6;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label7;
    }
}