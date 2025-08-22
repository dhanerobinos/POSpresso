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
            lbProduct = new Label();
            lbPrice = new Label();
            pbProductImage = new PictureBox();
            lbQty = new Label();
            lbSubTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(73, 19);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(38, 15);
            lbProduct.TabIndex = 0;
            lbProduct.Text = "label1";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(73, 45);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(38, 15);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "label2";
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(17, 10);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(50, 50);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 2;
            pbProductImage.TabStop = false;
            // 
            // lbQty
            // 
            lbQty.AutoSize = true;
            lbQty.Location = new Point(127, 45);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(38, 15);
            lbQty.TabIndex = 3;
            lbQty.Text = "label2";
            // 
            // lbSubTotal
            // 
            lbSubTotal.AutoSize = true;
            lbSubTotal.Location = new Point(208, 45);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(38, 15);
            lbSubTotal.TabIndex = 4;
            lbSubTotal.Text = "label2";
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbSubTotal);
            Controls.Add(lbQty);
            Controls.Add(pbProductImage);
            Controls.Add(lbPrice);
            Controls.Add(lbProduct);
            Name = "CartItemControl";
            Size = new Size(273, 133);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProduct;
        private Label lbPrice;
        private PictureBox pbProductImage;
        private Label lbQty;
        private Label lbSubTotal;
    }
}
