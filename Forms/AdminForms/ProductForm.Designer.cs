namespace POSpresso.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panel1 = new Panel();
            lbUploadImage = new LinkLabel();
            label6 = new Label();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            pbProductImage = new PictureBox();
            label5 = new Label();
            cbStatus = new ComboBox();
            label4 = new Label();
            cbCategory = new ComboBox();
            label3 = new Label();
            tbPrice = new TextBox();
            label2 = new Label();
            tbDescription = new TextBox();
            label1 = new Label();
            tbProductName = new TextBox();
            dtgvProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lbUploadImage);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(pbProductImage);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbPrice);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbDescription);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbProductName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 596);
            panel1.TabIndex = 0;
            // 
            // lbUploadImage
            // 
            lbUploadImage.AutoSize = true;
            lbUploadImage.BackColor = Color.Transparent;
            lbUploadImage.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUploadImage.LinkColor = Color.FromArgb(0, 192, 192);
            lbUploadImage.Location = new Point(186, 109);
            lbUploadImage.Name = "lbUploadImage";
            lbUploadImage.Size = new Size(96, 17);
            lbUploadImage.TabIndex = 29;
            lbUploadImage.TabStop = true;
            lbUploadImage.Text = "Upload Image";
            lbUploadImage.LinkClicked += lbUploadImage_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 12);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 28;
            label6.Text = "Add Products";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(3, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(279, 33);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Beige;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(3, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(279, 33);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(198, 28);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(75, 78);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 25;
            pbProductImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 264);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 23;
            label5.Text = "Availability:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(118, 263);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(144, 23);
            cbStatus.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 21;
            label4.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(118, 234);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(144, 23);
            cbCategory.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 19;
            label3.Text = "Price:";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(118, 205);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(144, 23);
            tbPrice.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 17;
            label2.Text = "Description:";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(118, 176);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(144, 23);
            tbDescription.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 15;
            label1.Text = "Product Name:";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(118, 147);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(144, 23);
            tbProductName.TabIndex = 14;
            // 
            // dtgvProducts
            // 
            dtgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProducts.Location = new Point(313, 12);
            dtgvProducts.Name = "dtgvProducts";
            dtgvProducts.Size = new Size(280, 596);
            dtgvProducts.TabIndex = 1;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 620);
            Controls.Add(dtgvProducts);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            Text = "ProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvProducts;
        private LinkLabel lbUploadImage;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnSave;
        private PictureBox pbProductImage;
        private Label label5;
        private ComboBox cbStatus;
        private Label label4;
        private ComboBox cbCategory;
        private Label label3;
        private TextBox tbPrice;
        private Label label2;
        private TextBox tbDescription;
        private Label label1;
        private TextBox tbProductName;
    }
}