namespace FormsApplication
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            supplierListTxtBox = new TextBox();
            suppliersList = new Label();
            SuspendLayout();
            // 
            // supplierListTxtBox
            // 
            supplierListTxtBox.BackColor = Color.WhiteSmoke;
            supplierListTxtBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            supplierListTxtBox.Location = new Point(12, 64);
            supplierListTxtBox.Margin = new Padding(3, 2, 3, 2);
            supplierListTxtBox.MaximumSize = new Size(373, 508);
            supplierListTxtBox.MinimumSize = new Size(373, 508);
            supplierListTxtBox.Multiline = true;
            supplierListTxtBox.Name = "supplierListTxtBox";
            supplierListTxtBox.ReadOnly = true;
            supplierListTxtBox.ScrollBars = ScrollBars.Vertical;
            supplierListTxtBox.Size = new Size(373, 508);
            supplierListTxtBox.TabIndex = 15;
            // 
            // suppliersList
            // 
            suppliersList.AutoSize = true;
            suppliersList.BackColor = Color.Transparent;
            suppliersList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            suppliersList.ForeColor = SystemColors.Control;
            suppliersList.Location = new Point(12, 43);
            suppliersList.Name = "suppliersList";
            suppliersList.Size = new Size(156, 21);
            suppliersList.TabIndex = 14;
            suppliersList.Text = "Лист с доставчици";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(402, 593);
            Controls.Add(supplierListTxtBox);
            Controls.Add(suppliersList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(418, 632);
            MinimumSize = new Size(418, 632);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox supplierListTxtBox;
        private Label suppliersList;
    }
}