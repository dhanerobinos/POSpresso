namespace POSpresso.Forms
{
    partial class POSForm
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
            flpCategories = new FlowLayoutPanel();
            flpProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpCategories
            // 
            flpCategories.Location = new Point(0, 0);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(145, 620);
            flpCategories.TabIndex = 0;
            // 
            // flpProducts
            // 
            flpProducts.Location = new Point(151, 0);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(612, 620);
            flpProducts.TabIndex = 1;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(flpProducts);
            Controls.Add(flpCategories);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POSForm";
            Text = "POSForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpCategories;
        private FlowLayoutPanel flpProducts;
    }
}