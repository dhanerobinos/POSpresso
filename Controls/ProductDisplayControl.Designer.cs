namespace POSpresso
{
    partial class ProductDisplayControl
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
            pbProduct = new PictureBox();
            lblProductName = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(23, 20);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(100, 100);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            pbProduct.Click += pictureBox1_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(35, 123);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(74, 21);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product:";
            lblProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(48, 144);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 21);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // ProductDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(pbProduct);
            Name = "ProductDisplayControl";
            Size = new Size(160, 200);
            Load += ProductDisplayControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProduct;
        private Label lblProductName;
        private Label lblPrice;
    }
}
