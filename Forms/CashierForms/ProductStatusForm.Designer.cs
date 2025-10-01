namespace POSpresso.Forms.CashierForms
{
    partial class ProductStatusForm
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
            flpProducts = new FlowLayoutPanel();
            flpCategories = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpProducts
            // 
            flpProducts.Location = new Point(152, 0);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(612, 620);
            flpProducts.TabIndex = 3;
            // 
            // flpCategories
            // 
            flpCategories.Location = new Point(1, 0);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(145, 620);
            flpCategories.TabIndex = 2;
            // 
            // ProductStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(flpProducts);
            Controls.Add(flpCategories);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductStatusForm";
            Text = "ProductStatusForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProducts;
        private FlowLayoutPanel flpCategories;
    }
}