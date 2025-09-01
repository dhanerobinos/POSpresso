namespace POSpresso.Forms
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            rtbReceipt = new RichTextBox();
            btnPrintReceipt = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // rtbReceipt
            // 
            rtbReceipt.Location = new Point(12, 12);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Size = new Size(214, 472);
            rtbReceipt.TabIndex = 0;
            rtbReceipt.Text = "";
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.FromArgb(128, 255, 128);
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrintReceipt.IconColor = Color.Black;
            btnPrintReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrintReceipt.IconSize = 30;
            btnPrintReceipt.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintReceipt.Location = new Point(12, 488);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(214, 35);
            btnPrintReceipt.TabIndex = 1;
            btnPrintReceipt.Text = "Print";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(238, 528);
            Controls.Add(btnPrintReceipt);
            Controls.Add(rtbReceipt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReceiptForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbReceipt;
        private FontAwesome.Sharp.IconButton btnPrintReceipt;
    }
}