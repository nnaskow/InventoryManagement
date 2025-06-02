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
            supplierListTxtBox.Location = new Point(12, 54);
            supplierListTxtBox.Multiline = true;
            supplierListTxtBox.Name = "supplierListTxtBox";
            supplierListTxtBox.ReadOnly = true;
            supplierListTxtBox.ScrollBars = ScrollBars.Vertical;
            supplierListTxtBox.Size = new Size(413, 560);
            supplierListTxtBox.TabIndex = 15;
            // 
            // suppliersList
            // 
            suppliersList.AutoSize = true;
            suppliersList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            suppliersList.Location = new Point(40, 31);
            suppliersList.Name = "suppliersList";
            suppliersList.Size = new Size(166, 23);
            suppliersList.TabIndex = 14;
            suppliersList.Text = "Лист с доставчици";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 652);
            Controls.Add(supplierListTxtBox);
            Controls.Add(suppliersList);
            Icon = (Icon)resources.GetObject("$this.Icon");
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