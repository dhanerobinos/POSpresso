namespace POSpresso.Forms
{
    partial class CategoryForm
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
            tbCategoryName = new TextBox();
            lbCategoryName = new Label();
            btnSave = new FontAwesome.Sharp.IconButton();
            lbUploadCategoryImage = new LinkLabel();
            dtgvCategory = new DataGridView();
            panel1 = new Panel();
            pbCategoryImage = new FontAwesome.Sharp.IconPictureBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCategoryImage).BeginInit();
            SuspendLayout();
            // 
            // tbCategoryName
            // 
            tbCategoryName.Location = new Point(99, 137);
            tbCategoryName.Name = "tbCategoryName";
            tbCategoryName.Size = new Size(117, 23);
            tbCategoryName.TabIndex = 0;
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(3, 142);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(93, 15);
            lbCategoryName.TabIndex = 1;
            lbCategoryName.Text = "Category Name:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSpringGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(56, 177);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbUploadCategoryImage
            // 
            lbUploadCategoryImage.AutoSize = true;
            lbUploadCategoryImage.Location = new Point(71, 97);
            lbUploadCategoryImage.Name = "lbUploadCategoryImage";
            lbUploadCategoryImage.Size = new Size(81, 15);
            lbUploadCategoryImage.TabIndex = 4;
            lbUploadCategoryImage.TabStop = true;
            lbUploadCategoryImage.Text = "Upload Image";
            lbUploadCategoryImage.LinkClicked += lbUploadCategoryImage_LinkClicked;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AllowUserToAddRows = false;
            dtgvCategory.AllowUserToDeleteRows = false;
            dtgvCategory.AllowUserToResizeColumns = false;
            dtgvCategory.AllowUserToResizeRows = false;
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.BackgroundColor = Color.AntiqueWhite;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(46, 24);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.ReadOnly = true;
            dtgvCategory.RowHeadersVisible = false;
            dtgvCategory.Size = new Size(255, 402);
            dtgvCategory.TabIndex = 5;
            dtgvCategory.CellContentClick += dtgvCategory_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbCategoryImage);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(tbCategoryName);
            panel1.Controls.Add(lbUploadCategoryImage);
            panel1.Controls.Add(lbCategoryName);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(368, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 402);
            panel1.TabIndex = 6;
            // 
            // pbCategoryImage
            // 
            pbCategoryImage.BackColor = Color.SeaShell;
            pbCategoryImage.ForeColor = SystemColors.ControlText;
            pbCategoryImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            pbCategoryImage.IconColor = SystemColors.ControlText;
            pbCategoryImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbCategoryImage.IconSize = 80;
            pbCategoryImage.Location = new Point(71, 14);
            pbCategoryImage.Name = "pbCategoryImage";
            pbCategoryImage.Size = new Size(81, 80);
            pbCategoryImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCategoryImage.TabIndex = 6;
            pbCategoryImage.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(56, 217);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 31);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(635, 454);
            Controls.Add(panel1);
            Controls.Add(dtgvCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCategoryImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbCategoryName;
        private Label lbCategoryName;
        private FontAwesome.Sharp.IconButton btnSave;
        private LinkLabel lbUploadCategoryImage;
        private DataGridView dtgvCategory;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconPictureBox pbCategoryImage;
    }
}