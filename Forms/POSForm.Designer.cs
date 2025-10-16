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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            flpCategories = new FlowLayoutPanel();
            flpProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpCategories
            // 
            flpCategories.BackColor = Color.Linen;
            flpCategories.Location = new Point(12, 12);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(133, 596);
            flpCategories.TabIndex = 0;
            // 
            // flpProducts
            // 
            flpProducts.BackColor = Color.Linen;
            flpProducts.Location = new Point(151, 12);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(602, 596);
            flpProducts.TabIndex = 1;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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