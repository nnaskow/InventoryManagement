namespace FormsApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wlcmbackLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwLabel = new System.Windows.Forms.Label();
            this.usrnmLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.messageText = new System.Windows.Forms.Label();
            this.msgTxt2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "InventoryManagement";
            this.notifyIcon.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FormsApp.Properties.Resources.logistics;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(104, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wlcmbackLabel
            // 
            this.wlcmbackLabel.AutoSize = true;
            this.wlcmbackLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wlcmbackLabel.Location = new System.Drawing.Point(16, 148);
            this.wlcmbackLabel.Name = "wlcmbackLabel";
            this.wlcmbackLabel.Size = new System.Drawing.Size(328, 21);
            this.wlcmbackLabel.TabIndex = 1;
            this.wlcmbackLabel.Text = "Добре дошли! Моля влезте в системата.";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameInput.Location = new System.Drawing.Point(71, 185);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(189, 22);
            this.usernameInput.TabIndex = 3;
            // 
            // passwLabel
            // 
            this.passwLabel.AutoSize = true;
            this.passwLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwLabel.Location = new System.Drawing.Point(37, 222);
            this.passwLabel.Name = "passwLabel";
            this.passwLabel.Size = new System.Drawing.Size(30, 21);
            this.passwLabel.TabIndex = 4;
            this.passwLabel.Text = "🔒";
            // 
            // usrnmLabel
            // 
            this.usrnmLabel.AutoSize = true;
            this.usrnmLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usrnmLabel.Location = new System.Drawing.Point(37, 187);
            this.usrnmLabel.Name = "usrnmLabel";
            this.usrnmLabel.Size = new System.Drawing.Size(30, 21);
            this.usrnmLabel.TabIndex = 5;
            this.usrnmLabel.Text = "👤";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInput.Location = new System.Drawing.Point(71, 223);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(189, 22);
            this.passwordInput.TabIndex = 6;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.Location = new System.Drawing.Point(124, 251);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(80, 33);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Вход";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(269, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Покажи";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageText.Location = new System.Drawing.Point(100, 311);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(108, 21);
            this.messageText.TabIndex = 9;
            this.messageText.Text = "messageText";
            this.messageText.Visible = false;
            // 
            // msgTxt2
            // 
            this.msgTxt2.AutoSize = true;
            this.msgTxt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msgTxt2.Location = new System.Drawing.Point(67, 311);
            this.msgTxt2.Name = "msgTxt2";
            this.msgTxt2.Size = new System.Drawing.Size(72, 21);
            this.msgTxt2.TabIndex = 10;
            this.msgTxt2.Text = "msgtxt2";
            this.msgTxt2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(51, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 29);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(115, 292);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(93, 17);
            this.rememberMeCheckBox.TabIndex = 13;
            this.rememberMeCheckBox.Text = "Запомни ме";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rememberMeCheckBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.msgTxt2);
            this.panel2.Controls.Add(this.messageText);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btnLogIn);
            this.panel2.Controls.Add(this.passwordInput);
            this.panel2.Controls.Add(this.usrnmLabel);
            this.panel2.Controls.Add(this.passwLabel);
            this.panel2.Controls.Add(this.usernameInput);
            this.panel2.Controls.Add(this.wlcmbackLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(356, 385);
            this.panel2.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 463);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wlcmbackLabel;
        public System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label passwLabel;
        private System.Windows.Forms.Label usrnmLabel;
        public System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.Label msgTxt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Panel panel2;
    }
}

