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
            SuspendLayout();
            // 
            // lbPaymentOption
            // 
            lbPaymentOption.AutoSize = true;
            lbPaymentOption.Location = new Point(43, 26);
            lbPaymentOption.Name = "lbPaymentOption";
            lbPaymentOption.Size = new Size(38, 15);
            lbPaymentOption.TabIndex = 0;
            lbPaymentOption.Text = "label1";
            // 
            // PaymentDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbPaymentOption);
            Name = "PaymentDisplayControl";
            Size = new Size(131, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPaymentOption;
    }
}
