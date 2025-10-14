namespace POSpresso.Forms
{
    partial class ConfirmPaymentForm
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
            label3 = new Label();
            btnConfirm = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            lbTotal = new Label();
            lbPaymentMethod = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(421, 21);
            label1.TabIndex = 0;
            label1.Text = " \"Customer will scan the GCash QR code at the counter.\" ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 77);
            label2.Name = "label2";
            label2.Size = new Size(284, 15);
            label2.TabIndex = 1;
            label2.Text = "\"Click 'Confirm Payment' after payment is received.\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 17);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 2;
            label3.Text = "Confirm Payment";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.MediumSpringGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConfirm.IconColor = Color.Black;
            btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirm.Location = new Point(232, 188);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 50);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(69, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 50);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(98, 111);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(38, 15);
            lbTotal.TabIndex = 16;
            lbTotal.Text = "label4";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.Location = new Point(98, 133);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(38, 15);
            lbPaymentMethod.TabIndex = 17;
            lbPaymentMethod.Text = "label4";
            // 
            // ConfirmPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 288);
            Controls.Add(lbPaymentMethod);
            Controls.Add(lbTotal);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmPaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmPaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Label lbTotal;
        private Label lbPaymentMethod;
    }
}