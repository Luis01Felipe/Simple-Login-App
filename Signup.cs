using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Simple_Login_App
{
    public partial class Signup : Form
    {
        public string codigoVerificacao = GerarCodigoVerificacao();

        public Signup()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || MailBox.Text == "" || PassBox.Text == "")
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

                // Verifica se o e-mail ou telefone já estão cadastrados
                string checkSql = "SELECT * FROM cadastro WHERE Email = @Email OR Telefone = @Telefone;";
                MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@Email", MailBox.Text);
                checkCmd.Parameters.AddWithValue("@Telefone", TelephoneBox.Text);
                MySqlDataReader reader = checkCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("E-mail ou telefone já cadastrados.");
                    reader.Close();
                    MailBox.Clear();
                    TelephoneBox.Clear();
                    return;
                }
                reader.Close();

                // Enviando e-mail com código de verificação
                sendMail();

                CodVerifyBox codVerifyBox = new CodVerifyBox(this);
                codVerifyBox.ShowDialog();
                if (codVerifyBox.isCodeValid)
                {
                    // Insere o dados no banco de dados
                    string sql = "INSERT INTO cadastro (Nome, Sobrenome, Telefone, Nascimento, Email, Senha) VALUES (@Nome, @Sobrenome, @Telefone, @Nascimento, @Email, @Senha);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Nome", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Sobrenome", LastnameBox.Text);
                    cmd.Parameters.AddWithValue("@Telefone", TelephoneBox.Text);
                    string dataFormatada = BorndateDatepicker.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@Nascimento", dataFormatada);
                    cmd.Parameters.AddWithValue("@Email", MailBox.Text);
                    cmd.Parameters.AddWithValue("@Senha", PassBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            Login login = new Login();
            login.Show();
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

        public void sendMail()
        {
            try
            {
                //string codigoVerificacao = GerarCodigoVerificacao();

                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress("emailformyapps6@gmail.com");
                mm.To.Add(MailBox.Text);
                mm.Subject = "Cadastro no Simple-Login-App em andamento";
                mm.Body = $"Olá, vejo que está tentando cadastrar-se no app. aqui está seu codigo de verificação: {codigoVerificacao}, abra o app e o confirme por gentileza.";
                sc.Port = 587;
                sc.Credentials = new NetworkCredential("emailformyapps6@gmail.com", "kdwy rrye gkyc rzsd");
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show("Email sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        static string GerarCodigoVerificacao()
        {
            // Lógica para gerar um código de verificação (pode variar dependendo das suas necessidades)
            // Neste exemplo, estamos gerando um código de 6 dígitos aleatório
            Random CodVerify = new Random();
            return CodVerify.Next(100000, 999999).ToString();
        }

        private void MailBox_Leave(object sender, EventArgs e)
        {
            string email = MailBox.Text.Trim(); // Remove espaços em branco do início e do fim do texto
            if (!EmailValido(email))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.");
                MailBox.Clear();
            }
            else
            {
                MailBox.Text = email; // Atualiza o texto na caixa de e-mail com a versão sem espaços em branco
            }
        }

        public bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
