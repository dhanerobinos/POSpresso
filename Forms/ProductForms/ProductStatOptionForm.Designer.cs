namespace POSpresso.Forms.ProductForms
{
    partial class ProductStatOptionForm
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
            btnAvailable = new FontAwesome.Sharp.IconButton();
            btnUnavailable = new FontAwesome.Sharp.IconButton();
            lbProductName = new Label();
            pbProduct = new PictureBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // btnAvailable
            // 
            btnAvailable.BackColor = Color.SpringGreen;
            btnAvailable.FlatStyle = FlatStyle.Flat;
            btnAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvailable.ForeColor = Color.White;
            btnAvailable.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAvailable.IconColor = Color.Black;
            btnAvailable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAvailable.Location = new Point(214, 281);
            btnAvailable.Name = "btnAvailable";
            btnAvailable.Size = new Size(140, 50);
            btnAvailable.TabIndex = 26;
            btnAvailable.Text = "Available";
            btnAvailable.UseVisualStyleBackColor = false;
            btnAvailable.Click += btnAvailable_Click;
            // 
            // btnUnavailable
            // 
            btnUnavailable.BackColor = Color.Tomato;
            btnUnavailable.FlatStyle = FlatStyle.Flat;
            btnUnavailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnavailable.ForeColor = Color.White;
            btnUnavailable.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUnavailable.IconColor = Color.Black;
            btnUnavailable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUnavailable.Location = new Point(51, 281);
            btnUnavailable.Name = "btnUnavailable";
            btnUnavailable.Size = new Size(140, 50);
            btnUnavailable.TabIndex = 25;
            btnUnavailable.Text = "Unavailable";
            btnUnavailable.UseVisualStyleBackColor = false;
            btnUnavailable.Click += btnUnavailable_Click;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductName.Location = new Point(162, 212);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(74, 21);
            lbProductName.TabIndex = 21;
            lbProductName.Text = "Product:";
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(139, 89);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(120, 120);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 20;
            pbProduct.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Maroon;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(51, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(303, 50);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 25);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 28;
            label1.Text = "Mark Product ";
            // 
            // ProductStatOptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 420);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAvailable);
            Controls.Add(btnUnavailable);
            Controls.Add(lbProductName);
            Controls.Add(pbProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductStatOptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductStatOptionForm";
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAvailable;
        private FontAwesome.Sharp.IconButton btnUnavailable;
        private Label lbProductName;
        private PictureBox pbProduct;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Label label1;
    }
}