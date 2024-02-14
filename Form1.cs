using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simple_Login_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            Signup cadastro = new Signup();
            cadastro.Show();
            cadastro.MailBox.Text = MailBox.Text;
            cadastro.PassBox.Text = PassBox.Text;
            //this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (MailBox.Text == "admin" && PassBox.Text == "admin")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void PassEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(this, new EventArgs());
            }
        }

        private void ViewpassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PassBox.PasswordChar = ViewpassCheckbox.Checked ? '\0' : '*';
            ViewpassCheckbox.ImageIndex = ViewpassCheckbox.Checked ? 1 : 0;
        }
    }
}
