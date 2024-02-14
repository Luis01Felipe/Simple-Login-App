using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Simple_Login_App
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text == "" || LastnameBox.Text == "" || TelephoneBox.Text == "" || MailBox.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            Console.WriteLine("Connecting to MySQL...");
            string connStr = "Server=sql10.freemysqlhosting.net;Port=3306;Database=sql10683041;User ID=sql10683041;Password=vFT6IDUSbb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Conferindo cadastro...");
                conn.Open();

                string sql = "INSERT INTO cadastro (Nome, Sobrenome, Telefone, Nascimento, Email, Senha) VALUES (@Nome, @Sobrenome, @Telefone, @Nascimento, @Email, @Senha);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", NameBox.Text);
                cmd.Parameters.AddWithValue("@Sobrenome", LastnameBox.Text);
                cmd.Parameters.AddWithValue("@Telefone", TelephoneBox.Text);
                string dataFormatada = BorndateDatepicker.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@Nascimento", dataFormatada); // Certifique-se de que este é um DateTime
                cmd.Parameters.AddWithValue("@Email", MailBox.Text);
                cmd.Parameters.AddWithValue("@Senha", PassBox.Text);
                cmd.ExecuteNonQuery(); // Use ExecuteNonQuery para consultas de inserção
                MessageBox.Show("Cadastro efetuado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }

        private void TelephoneBox_Leave(object sender, EventArgs e)
        {
            Regex ex = new Regex("^[1-9]{2}[0-9]{9}$");
            bool isValid = ex.IsMatch(TelephoneBox.Text);

            if (!isValid)
            {
                MessageBox.Show("Número de telefone não compativel, por favor utilize o formato de 11 números.");
                TelephoneBox.Clear();
            }
        }

        private void TelephoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere é uma letra, um controle (como backspace) ou uma letra acentuada
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(Convert.ToChar(e.KeyChar.ToString().Normalize(NormalizationForm.FormD).FirstOrDefault(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark))))
            {
                e.Handled = true;  // Cancela o evento
            }
        }

        private void LastnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NameBox_KeyPress(sender, e);
        }
    }
}
