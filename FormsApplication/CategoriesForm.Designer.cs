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
            categoriesListTxtBox.MaximumSize = new Size(373, 508);
            categoriesListTxtBox.MinimumSize = new Size(373, 508);
            categoriesListTxtBox.Multiline = true;
            categoriesListTxtBox.Name = "categoriesListTxtBox";
            categoriesListTxtBox.ReadOnly = true;
            categoriesListTxtBox.ScrollBars = ScrollBars.Vertical;
            categoriesListTxtBox.Size = new Size(373, 508);
            categoriesListTxtBox.TabIndex = 13;
            // 
            // categoriesList
            // 
            categoriesList.AutoSize = true;
            categoriesList.BackColor = Color.Transparent;
            categoriesList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            categoriesList.ForeColor = SystemColors.Control;
            categoriesList.Location = new Point(12, 37);
            categoriesList.Name = "categoriesList";
            categoriesList.Size = new Size(144, 21);
            categoriesList.TabIndex = 12;
            categoriesList.Text = "Лист с категории";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(402, 593);
            Controls.Add(categoriesListTxtBox);
            Controls.Add(categoriesList);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(418, 632);
            MinimumSize = new Size(418, 632);
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