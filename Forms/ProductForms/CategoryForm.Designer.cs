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
            label1 = new Label();
            cbCategoryStatus = new ComboBox();
            pbCategoryImage = new FontAwesome.Sharp.IconPictureBox();
            btnHide = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            cbFilterStatus = new ComboBox();
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
            btnSave.Location = new Point(55, 217);
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
            dtgvCategory.Location = new Point(46, 65);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.ReadOnly = true;
            dtgvCategory.RowHeadersVisible = false;
            dtgvCategory.Size = new Size(255, 361);
            dtgvCategory.TabIndex = 5;
            dtgvCategory.CellContentClick += dtgvCategory_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbCategoryStatus);
            panel1.Controls.Add(pbCategoryImage);
            panel1.Controls.Add(btnHide);
            panel1.Controls.Add(tbCategoryName);
            panel1.Controls.Add(lbUploadCategoryImage);
            panel1.Controls.Add(lbCategoryName);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(368, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 361);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 169);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 8;
            label1.Text = "Category Status:";
            // 
            // cbCategoryStatus
            // 
            cbCategoryStatus.FormattingEnabled = true;
            cbCategoryStatus.Location = new Point(99, 166);
            cbCategoryStatus.Name = "cbCategoryStatus";
            cbCategoryStatus.Size = new Size(117, 23);
            cbCategoryStatus.TabIndex = 7;
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
            // btnHide
            // 
            btnHide.BackColor = Color.Brown;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHide.ForeColor = Color.White;
            btnHide.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHide.IconColor = Color.Black;
            btnHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHide.Location = new Point(55, 257);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(130, 31);
            btnHide.TabIndex = 5;
            btnHide.Text = "Hide Category";
            btnHide.UseVisualStyleBackColor = false;
  
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Brown;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 30;
            btnExit.Location = new Point(602, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(35, 31);
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.FormattingEnabled = true;
            cbFilterStatus.Location = new Point(184, 36);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(117, 23);
            cbFilterStatus.TabIndex = 9;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(635, 454);
            Controls.Add(cbFilterStatus);
            Controls.Add(btnExit);
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
        private FontAwesome.Sharp.IconButton btnHide;
        private FontAwesome.Sharp.IconPictureBox pbCategoryImage;
        private FontAwesome.Sharp.IconButton btnExit;
        private Label label1;
        private ComboBox cbCategoryStatus;
        private ComboBox cbFilterStatus;
    }
}