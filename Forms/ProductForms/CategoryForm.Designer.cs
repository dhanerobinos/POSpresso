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
            pictureBox1 = new PictureBox();
            lbUploadCategoryImage = new LinkLabel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(71, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 78);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(248, 402);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbCategoryName);
            panel1.Controls.Add(lbUploadCategoryImage);
            panel1.Controls.Add(lbCategoryName);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(279, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 402);
            panel1.TabIndex = 6;
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
            ClientSize = new Size(519, 455);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.Manual;
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbCategoryName;
        private Label lbCategoryName;
        private FontAwesome.Sharp.IconButton btnSave;
        private PictureBox pictureBox1;
        private LinkLabel lbUploadCategoryImage;
        private DataGridView dataGridView1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}