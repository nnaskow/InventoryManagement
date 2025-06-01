
namespace FormsApplication
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            notifyIcon = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            wlcmbackLabel = new Label();
            usernameInput = new TextBox();
            passwLabel = new Label();
            usrnmLabel = new Label();
            passwordInput = new TextBox();
            btnLogIn = new Button();
            checkBox1 = new CheckBox();
            messageText = new Label();
            msgTxt2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            rememberMeCheckBox = new CheckBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "InventoryManagement";
            notifyIcon.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.recycle1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(34, 40);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // wlcmbackLabel
            // 
            wlcmbackLabel.AutoSize = true;
            wlcmbackLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            wlcmbackLabel.Location = new Point(258, 55);
            wlcmbackLabel.Margin = new Padding(4, 0, 4, 0);
            wlcmbackLabel.Name = "wlcmbackLabel";
            wlcmbackLabel.Size = new Size(145, 21);
            wlcmbackLabel.TabIndex = 1;
            wlcmbackLabel.Text = "Вход в системата";
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            usernameInput.Location = new Point(223, 79);
            usernameInput.Margin = new Padding(4, 3, 4, 3);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(229, 22);
            usernameInput.TabIndex = 3;
            // 
            // passwLabel
            // 
            passwLabel.AutoSize = true;
            passwLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwLabel.Location = new Point(198, 119);
            passwLabel.Margin = new Padding(4, 0, 4, 0);
            passwLabel.Name = "passwLabel";
            passwLabel.Size = new Size(30, 21);
            passwLabel.TabIndex = 4;
            passwLabel.Text = "🔒";
            // 
            // usrnmLabel
            // 
            usrnmLabel.AutoSize = true;
            usrnmLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            usrnmLabel.Location = new Point(198, 79);
            usrnmLabel.Margin = new Padding(4, 0, 4, 0);
            usrnmLabel.Name = "usrnmLabel";
            usrnmLabel.Size = new Size(30, 21);
            usrnmLabel.TabIndex = 5;
            usrnmLabel.Text = "👤";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordInput.Location = new Point(223, 122);
            passwordInput.Margin = new Padding(4, 3, 4, 3);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(229, 22);
            passwordInput.TabIndex = 6;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogIn.Location = new Point(286, 150);
            btnLogIn.Margin = new Padding(4, 3, 4, 3);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(81, 33);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Вход";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(460, 127);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 17);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Покажи";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // messageText
            // 
            messageText.AutoSize = true;
            messageText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            messageText.Location = new Point(262, 185);
            messageText.Margin = new Padding(4, 0, 4, 0);
            messageText.Name = "messageText";
            messageText.Size = new Size(108, 21);
            messageText.TabIndex = 9;
            messageText.Text = "messageText";
            messageText.Visible = false;
            // 
            // msgTxt2
            // 
            msgTxt2.AutoSize = true;
            msgTxt2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            msgTxt2.Location = new Point(228, 185);
            msgTxt2.Margin = new Padding(4, 0, 4, 0);
            msgTxt2.Name = "msgTxt2";
            msgTxt2.Size = new Size(72, 21);
            msgTxt2.TabIndex = 10;
            msgTxt2.Text = "msgtxt2";
            msgTxt2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(277, 185);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 11;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(198, 189);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 33);
            panel1.TabIndex = 12;
            panel1.Visible = false;
            // 
            // rememberMeCheckBox
            // 
            rememberMeCheckBox.AutoSize = true;
            rememberMeCheckBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rememberMeCheckBox.Location = new Point(375, 166);
            rememberMeCheckBox.Margin = new Padding(4, 3, 4, 3);
            rememberMeCheckBox.Name = "rememberMeCheckBox";
            rememberMeCheckBox.Size = new Size(93, 17);
            rememberMeCheckBox.TabIndex = 13;
            rememberMeCheckBox.Text = "Запомни ме";
            rememberMeCheckBox.UseVisualStyleBackColor = true;
            rememberMeCheckBox.CheckedChanged += rememberMeCheckBox_CheckedChanged;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(usernameInput);
            panel2.Controls.Add(rememberMeCheckBox);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(msgTxt2);
            panel2.Controls.Add(messageText);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(btnLogIn);
            panel2.Controls.Add(passwordInput);
            panel2.Controls.Add(usrnmLabel);
            panel2.Controls.Add(passwLabel);
            panel2.Controls.Add(wlcmbackLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(13, 12);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2);
            panel2.Size = new Size(552, 229);
            panel2.TabIndex = 14;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(576, 248);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.InactiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryManagement";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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