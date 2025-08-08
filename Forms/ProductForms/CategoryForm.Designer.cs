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
            textBox1 = new TextBox();
            lbCategoryName = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            lbUploadCategoryImage = new LinkLabel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 0;
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
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(56, 177);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(130, 23);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Save";
            iconButton1.UseVisualStyleBackColor = true;
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
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbUploadCategoryImage);
            panel1.Controls.Add(lbCategoryName);
            panel1.Controls.Add(iconButton1);
            panel1.Location = new Point(279, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 402);
            panel1.TabIndex = 6;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(56, 206);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(130, 23);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Save";
            iconButton2.UseVisualStyleBackColor = true;
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

        private TextBox textBox1;
        private Label lbCategoryName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private LinkLabel lbUploadCategoryImage;
        private DataGridView dataGridView1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}