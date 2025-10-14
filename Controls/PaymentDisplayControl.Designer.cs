namespace POSpresso.Controls
{
    partial class PaymentDisplayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbPaymentOption = new Label();
            pbPaymentLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPaymentLogo).BeginInit();
            SuspendLayout();
            // 
            // lbPaymentOption
            // 
            lbPaymentOption.AutoSize = true;
            lbPaymentOption.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPaymentOption.Location = new Point(85, 28);
            lbPaymentOption.Name = "lbPaymentOption";
            lbPaymentOption.Size = new Size(72, 30);
            lbPaymentOption.TabIndex = 0;
            lbPaymentOption.Text = "label1";
            // 
            // pbPaymentLogo
            // 
            pbPaymentLogo.Location = new Point(5, 7);
            pbPaymentLogo.Name = "pbPaymentLogo";
            pbPaymentLogo.Size = new Size(74, 68);
            pbPaymentLogo.TabIndex = 1;
            pbPaymentLogo.TabStop = false;
            // 
            // PaymentDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbPaymentLogo);
            Controls.Add(lbPaymentOption);
            Name = "PaymentDisplayControl";
            Size = new Size(200, 80);
            ((System.ComponentModel.ISupportInitialize)pbPaymentLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPaymentOption;
        private PictureBox pbPaymentLogo;
    }
}
