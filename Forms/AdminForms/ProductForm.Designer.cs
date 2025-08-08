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
            ProductsPanel = new Panel();
            btnDelete = new FontAwesome.Sharp.IconButton();
            lbUploadImage = new LinkLabel();
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
            btnShowProductPanel = new FontAwesome.Sharp.IconButton();
            btnAddCategory = new FontAwesome.Sharp.IconButton();
            ProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).BeginInit();
            SuspendLayout();
            // 
            // ProductsPanel
            // 
            ProductsPanel.BackgroundImage = (Image)resources.GetObject("ProductsPanel.BackgroundImage");
            ProductsPanel.Controls.Add(btnDelete);
            ProductsPanel.Controls.Add(lbUploadImage);
            ProductsPanel.Controls.Add(btnClear);
            ProductsPanel.Controls.Add(btnSave);
            ProductsPanel.Controls.Add(pbProductImage);
            ProductsPanel.Controls.Add(label5);
            ProductsPanel.Controls.Add(cbStatus);
            ProductsPanel.Controls.Add(label4);
            ProductsPanel.Controls.Add(cbCategory);
            ProductsPanel.Controls.Add(label3);
            ProductsPanel.Controls.Add(tbPrice);
            ProductsPanel.Controls.Add(label2);
            ProductsPanel.Controls.Add(tbDescription);
            ProductsPanel.Controls.Add(label1);
            ProductsPanel.Controls.Add(tbProductName);
            ProductsPanel.Location = new Point(494, 12);
            ProductsPanel.Name = "ProductsPanel";
            ProductsPanel.Size = new Size(259, 596);
            ProductsPanel.TabIndex = 0;
            ProductsPanel.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(0, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(259, 33);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbUploadImage
            // 
            lbUploadImage.AutoSize = true;
            lbUploadImage.BackColor = Color.Transparent;
            lbUploadImage.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUploadImage.LinkColor = Color.FromArgb(0, 192, 192);
            lbUploadImage.Location = new Point(83, 101);
            lbUploadImage.Name = "lbUploadImage";
            lbUploadImage.Size = new Size(96, 17);
            lbUploadImage.TabIndex = 29;
            lbUploadImage.TabStop = true;
            lbUploadImage.Text = "Upload Image";
            lbUploadImage.LinkClicked += lbUploadImage_LinkClicked;
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
            btnClear.Size = new Size(259, 33);
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
            btnSave.Size = new Size(259, 33);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(94, 20);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(75, 78);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 25;
            pbProductImage.TabStop = false;
            pbProductImage.Click += pbProductImage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(5, 266);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 23;
            label5.Text = "Availability:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(111, 265);
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
            label4.Location = new Point(5, 237);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 21;
            label4.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(111, 236);
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
            label3.Location = new Point(5, 213);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 19;
            label3.Text = "Price:";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(111, 207);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(144, 23);
            tbPrice.TabIndex = 18;
            tbPrice.Enter += tbPrice_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 179);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 17;
            label2.Text = "Description:";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(111, 178);
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
            label1.Location = new Point(5, 150);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 15;
            label1.Text = "Product Name:";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(111, 149);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(144, 23);
            tbProductName.TabIndex = 14;
            // 
            // dtgvProducts
            // 
            dtgvProducts.AllowUserToAddRows = false;
            dtgvProducts.AllowUserToDeleteRows = false;
            dtgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProducts.Location = new Point(1, 71);
            dtgvProducts.Name = "dtgvProducts";
            dtgvProducts.ReadOnly = true;
            dtgvProducts.RowHeadersVisible = false;
            dtgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvProducts.Size = new Size(487, 534);
            dtgvProducts.TabIndex = 1;
            dtgvProducts.CellContentClick += dtgvProducts_CellContentClick;
            // 
            // btnShowProductPanel
            // 
            btnShowProductPanel.BackColor = Color.DarkSlateGray;
            btnShowProductPanel.FlatStyle = FlatStyle.Flat;
            btnShowProductPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowProductPanel.ForeColor = Color.White;
            btnShowProductPanel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnShowProductPanel.IconColor = Color.Beige;
            btnShowProductPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowProductPanel.Location = new Point(180, 32);
            btnShowProductPanel.Name = "btnShowProductPanel";
            btnShowProductPanel.Size = new Size(149, 33);
            btnShowProductPanel.TabIndex = 31;
            btnShowProductPanel.Text = "Add Products";
            btnShowProductPanel.UseVisualStyleBackColor = false;
            btnShowProductPanel.Click += btnAddProducts_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.DarkSlateGray;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddCategory.IconColor = Color.Beige;
            btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddCategory.Location = new Point(335, 32);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(149, 33);
            btnAddCategory.TabIndex = 32;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(btnAddCategory);
            Controls.Add(btnShowProductPanel);
            Controls.Add(dtgvProducts);
            Controls.Add(ProductsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ProductsPanel.ResumeLayout(false);
            ProductsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ProductsPanel;
        private DataGridView dtgvProducts;
        private LinkLabel lbUploadImage;
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
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnShowProductPanel;
        private FontAwesome.Sharp.IconButton btnAddCategory;
    }
}