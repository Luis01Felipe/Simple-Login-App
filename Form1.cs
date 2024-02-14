using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connecting to MySQL...");
            string connStr = "Server=sql10.freemysqlhosting.net;Port=3306;Database=sql10683041;User ID=sql10683041;Password=vFT6IDUSbb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Conferindo cadastro...");
                conn.Open();

                string sql = "SELECT Senha FROM cadastro WHERE Email = @Email";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", MailBox.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MessageBox.Show("Email não registrado!");
                }
                rdr.Read();
                string senhaRetornada = rdr["Senha"].ToString();

                if (senhaRetornada == PassBox.Text)
                {
                    MessageBox.Show("Login efetuado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Senha incorreta!");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
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
            if (ViewpassCheckbox.Checked)
            {
                PassBox.PasswordChar = '\0';
                ViewpassCheckbox.Text = "Esconder senha";
            }
            else
            {
                PassBox.PasswordChar = '•';
                ViewpassCheckbox.Text = "Mostrar senha";
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
