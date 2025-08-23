namespace POSpresso.Forms
{
    partial class ProductOptions
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
            pbProduct = new PictureBox();
            lbProductName = new Label();
            lnMedium = new Label();
            lbLarge = new Label();
            btnMediumMinus = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnAddtoCart = new FontAwesome.Sharp.IconButton();
            lbPrice = new Label();
            lblMeduinQty = new Label();
            lblLargeQty = new Label();
            btnLargeMinus = new FontAwesome.Sharp.IconButton();
            btnMediumAdd = new FontAwesome.Sharp.IconButton();
            btnLargeAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(143, 47);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(120, 120);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductName.Location = new Point(167, 170);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(74, 21);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product:";
            // 
            // lnMedium
            // 
            lnMedium.AutoSize = true;
            lnMedium.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnMedium.Location = new Point(105, 239);
            lnMedium.Name = "lnMedium";
            lnMedium.Size = new Size(78, 21);
            lnMedium.TabIndex = 5;
            lnMedium.Text = "Medium:";
            // 
            // lbLarge
            // 
            lbLarge.AutoSize = true;
            lbLarge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLarge.Location = new Point(105, 289);
            lbLarge.Name = "lbLarge";
            lbLarge.Size = new Size(56, 21);
            lbLarge.TabIndex = 6;
            lbLarge.Text = "Large:";
            // 
            // btnMediumMinus
            // 
            btnMediumMinus.BackColor = Color.Transparent;
            btnMediumMinus.BackgroundImageLayout = ImageLayout.None;
            btnMediumMinus.FlatAppearance.BorderColor = SystemColors.Control;
            btnMediumMinus.FlatAppearance.BorderSize = 0;
            btnMediumMinus.FlatStyle = FlatStyle.Flat;
            btnMediumMinus.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnMediumMinus.IconColor = Color.Brown;
            btnMediumMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMediumMinus.Location = new Point(177, 228);
            btnMediumMinus.Name = "btnMediumMinus";
            btnMediumMinus.Size = new Size(47, 47);
            btnMediumMinus.TabIndex = 8;
            btnMediumMinus.UseVisualStyleBackColor = false;
            btnMediumMinus.Click += btnMediumMinus_Click;
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
            btnCancel.Location = new Point(48, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 50);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.SpringGreen;
            btnAddtoCart.FlatStyle = FlatStyle.Flat;
            btnAddtoCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoCart.ForeColor = Color.White;
            btnAddtoCart.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddtoCart.IconColor = Color.Black;
            btnAddtoCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddtoCart.Location = new Point(211, 358);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(140, 50);
            btnAddtoCart.TabIndex = 13;
            btnAddtoCart.Text = "ADD TO CART";
            btnAddtoCart.UseVisualStyleBackColor = false;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrice.ForeColor = Color.Green;
            lbPrice.Location = new Point(177, 191);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(50, 21);
            lbPrice.TabIndex = 14;
            lbPrice.Text = "Price:";
            // 
            // lblMeduinQty
            // 
            lblMeduinQty.AutoSize = true;
            lblMeduinQty.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeduinQty.Location = new Point(230, 239);
            lblMeduinQty.Name = "lblMeduinQty";
            lblMeduinQty.Size = new Size(23, 25);
            lblMeduinQty.TabIndex = 15;
            lblMeduinQty.Text = "0";
            // 
            // lblLargeQty
            // 
            lblLargeQty.AutoSize = true;
            lblLargeQty.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLargeQty.Location = new Point(230, 289);
            lblLargeQty.Name = "lblLargeQty";
            lblLargeQty.Size = new Size(23, 25);
            lblLargeQty.TabIndex = 16;
            lblLargeQty.Text = "0";
            // 
            // btnLargeMinus
            // 
            btnLargeMinus.BackColor = Color.Transparent;
            btnLargeMinus.BackgroundImageLayout = ImageLayout.None;
            btnLargeMinus.FlatAppearance.BorderColor = SystemColors.Control;
            btnLargeMinus.FlatAppearance.BorderSize = 0;
            btnLargeMinus.FlatStyle = FlatStyle.Flat;
            btnLargeMinus.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnLargeMinus.IconColor = Color.Brown;
            btnLargeMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLargeMinus.Location = new Point(177, 281);
            btnLargeMinus.Name = "btnLargeMinus";
            btnLargeMinus.Size = new Size(47, 47);
            btnLargeMinus.TabIndex = 17;
            btnLargeMinus.UseVisualStyleBackColor = false;
            btnLargeMinus.Click += btnLargeMinus_Click;
            // 
            // btnMediumAdd
            // 
            btnMediumAdd.BackColor = Color.Transparent;
            btnMediumAdd.BackgroundImageLayout = ImageLayout.None;
            btnMediumAdd.FlatAppearance.BorderColor = SystemColors.Control;
            btnMediumAdd.FlatAppearance.BorderSize = 0;
            btnMediumAdd.FlatStyle = FlatStyle.Flat;
            btnMediumAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnMediumAdd.IconColor = Color.SeaGreen;
            btnMediumAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMediumAdd.Location = new Point(259, 228);
            btnMediumAdd.Name = "btnMediumAdd";
            btnMediumAdd.Size = new Size(47, 47);
            btnMediumAdd.TabIndex = 18;
            btnMediumAdd.UseVisualStyleBackColor = false;
            btnMediumAdd.Click += btnMediumAdd_Click;
            // 
            // btnLargeAdd
            // 
            btnLargeAdd.BackColor = Color.Transparent;
            btnLargeAdd.BackgroundImageLayout = ImageLayout.None;
            btnLargeAdd.FlatAppearance.BorderColor = SystemColors.Control;
            btnLargeAdd.FlatAppearance.BorderSize = 0;
            btnLargeAdd.FlatStyle = FlatStyle.Flat;
            btnLargeAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnLargeAdd.IconColor = Color.SeaGreen;
            btnLargeAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLargeAdd.Location = new Point(259, 281);
            btnLargeAdd.Name = "btnLargeAdd";
            btnLargeAdd.Size = new Size(47, 47);
            btnLargeAdd.TabIndex = 19;
            btnLargeAdd.UseVisualStyleBackColor = false;
            btnLargeAdd.Click += btnLargeAdd_Click;
            // 
            // ProductOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(400, 420);
            Controls.Add(btnLargeAdd);
            Controls.Add(btnMediumAdd);
            Controls.Add(btnLargeMinus);
            Controls.Add(lblLargeQty);
            Controls.Add(lblMeduinQty);
            Controls.Add(lbPrice);
            Controls.Add(btnAddtoCart);
            Controls.Add(btnCancel);
            Controls.Add(btnMediumMinus);
            Controls.Add(lbLarge);
            Controls.Add(lnMedium);
            Controls.Add(lbProductName);
            Controls.Add(pbProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductOptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductOptions";
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProduct;
        private Label lbProductName;
        private Label lnMedium;
        private Label lbLarge;
        private FontAwesome.Sharp.IconButton btnMediumMinus;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAddtoCart;
        private Label lbPrice;
        private Label lblMeduinQty;
        private Label lblLargeQty;
        private FontAwesome.Sharp.IconButton btnLargeMinus;
        private FontAwesome.Sharp.IconButton btnMediumAdd;
        private FontAwesome.Sharp.IconButton btnLargeAdd;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}