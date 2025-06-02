namespace FormsApplication
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            productsList = new Label();
            productsListTxtBox = new TextBox();
            SuspendLayout();
            // 
            // productsList
            // 
            productsList.AutoSize = true;
            productsList.Location = new Point(28, 30);
            productsList.Name = "productsList";
            productsList.Size = new Size(147, 23);
            productsList.TabIndex = 0;
            productsList.Text = "Лист с продукти";
            // 
            // productsListTxtBox
            // 
            productsListTxtBox.BackColor = Color.WhiteSmoke;
            productsListTxtBox.Location = new Point(12, 56);
            productsListTxtBox.Multiline = true;
            productsListTxtBox.Name = "productsListTxtBox";
            productsListTxtBox.ReadOnly = true;
            productsListTxtBox.ScrollBars = ScrollBars.Vertical;
            productsListTxtBox.Size = new Size(413, 560);
            productsListTxtBox.TabIndex = 11;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(437, 652);
            Controls.Add(productsListTxtBox);
            Controls.Add(productsList);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productsList;
        private TextBox productsListTxtBox;
    }
}