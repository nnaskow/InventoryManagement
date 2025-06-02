namespace FormsApplication
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            categoriesListTxtBox = new TextBox();
            categoriesList = new Label();
            SuspendLayout();
            // 
            // categoriesListTxtBox
            // 
            categoriesListTxtBox.BackColor = Color.WhiteSmoke;
            categoriesListTxtBox.Location = new Point(12, 59);
            categoriesListTxtBox.Multiline = true;
            categoriesListTxtBox.Name = "categoriesListTxtBox";
            categoriesListTxtBox.ReadOnly = true;
            categoriesListTxtBox.ScrollBars = ScrollBars.Vertical;
            categoriesListTxtBox.Size = new Size(413, 560);
            categoriesListTxtBox.TabIndex = 13;
            // 
            // categoriesList
            // 
            categoriesList.AutoSize = true;
            categoriesList.Location = new Point(28, 33);
            categoriesList.Name = "categoriesList";
            categoriesList.Size = new Size(153, 23);
            categoriesList.TabIndex = 12;
            categoriesList.Text = "Лист с категории";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 652);
            Controls.Add(categoriesListTxtBox);
            Controls.Add(categoriesList);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox categoriesListTxtBox;
        private Label categoriesList;
    }
}