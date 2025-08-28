namespace POSpresso.Forms
{
    partial class CartItemControl
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
            pbProductImage = new PictureBox();
            lbDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(3, 3);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(35, 35);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 2;
            pbProductImage.TabStop = false;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Location = new Point(44, 13);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(42, 15);
            lbDetails.TabIndex = 3;
            lbDetails.Text = "Details";
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbDetails);
            Controls.Add(pbProductImage);
            Name = "CartItemControl";
            Size = new Size(263, 40);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbProductImage;
        private Label lbDetails;
    }
}
