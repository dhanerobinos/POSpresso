namespace POSpresso.Controls
{
    partial class ProductCategoryControl
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
            pbCategory = new PictureBox();
            lbCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCategory).BeginInit();
            SuspendLayout();
            // 
            // pbCategory
            // 
            pbCategory.Location = new Point(40, 3);
            pbCategory.Name = "pbCategory";
            pbCategory.Size = new Size(76, 70);
            pbCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pbCategory.TabIndex = 0;
            pbCategory.TabStop = false;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(3, 28);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(0, 15);
            lbCategory.TabIndex = 1;
            // 
            // ProductCategoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbCategory);
            Controls.Add(pbCategory);
            Name = "ProductCategoryControl";
            Size = new Size(142, 76);
            ((System.ComponentModel.ISupportInitialize)pbCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCategory;
        private Label lbCategory;
    }
}
