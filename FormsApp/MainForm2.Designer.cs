namespace FormsApp
{
    partial class MainForm2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.welcomeTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.productsBar = new System.Windows.Forms.ProgressBar();
            this.summaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.AutoSize = true;
            this.welcomeTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeTxt.Location = new System.Drawing.Point(18, 11);
            this.welcomeTxt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(102, 21);
            this.welcomeTxt.TabIndex = 0;
            this.welcomeTxt.Text = "welcomeTxt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "InventoryManagement";
            this.notifyIcon.Visible = true;
            // 
            // summaryPanel
            // 
            this.summaryPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.summaryPanel.Controls.Add(this.productsBar);
            this.summaryPanel.Controls.Add(this.welcomeTxt);
            this.summaryPanel.Location = new System.Drawing.Point(14, 35);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(505, 439);
            this.summaryPanel.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(857, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 17);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.Visible = false;
            // 
            // productsBar
            // 
            this.productsBar.Location = new System.Drawing.Point(58, 158);
            this.productsBar.Maximum = 2500;
            this.productsBar.Name = "productsBar";
            this.productsBar.Size = new System.Drawing.Size(337, 23);
            this.productsBar.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(927, 486);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar productsBar;
    }
}