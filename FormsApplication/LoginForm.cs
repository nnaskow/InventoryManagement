using InventoryManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormsApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Username => usernameInput.Text;
        public string username1 = "nikolay";
        public string username2 = "mihail";
        public string password1 = "Nikolay123!";
        public string password2 = "Mihail123!";
        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.BackColor = Color.FromArgb(45, 137, 239);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLogIn.Cursor = Cursors.Hand;
            passwordInput.UseSystemPasswordChar = true;

            if (Properties.Settings.Default.RememberMe)
            {
                usernameInput.Text = Properties.Settings.Default.Username;
                passwordInput.Text = Properties.Settings.Default.Password;
                rememberMeCheckBox.Checked = true;
            }
        }
      
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passwordInput.UseSystemPasswordChar = false;
            }
            else { passwordInput.UseSystemPasswordChar = true; }
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            if ((usernameInput.Text == "nikolay" && passwordInput.Text == "Nikolay123!") ||
           (usernameInput.Text == "mihail" && passwordInput.Text == "Mihail123!"))
            {
                label1.Visible = true;
                label1.ForeColor = Color.Black;
                label1.Text = "Проверка..";
                await Task.Delay(2000);
                label1.Visible = false;
                messageText.Visible = true;
                messageText.ForeColor = Color.Green;
                messageText.Text = "Успешен логин.";
                await Task.Delay(1000);
                MainForm m = new MainForm(usernameInput.Text);
                m.Show();
                this.Hide();
            }
            else
            {
                msgTxt2.Visible = true;
                msgTxt2.ForeColor = Color.Red;
                msgTxt2.Text = "Грешно въведени данни.";
                await Task.Delay(2500);
                msgTxt2.Visible = false;
            }
            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = usernameInput.Text;
                Properties.Settings.Default.Password = passwordInput.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
 
