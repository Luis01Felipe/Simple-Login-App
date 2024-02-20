using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Login_App
{
    public partial class CodVerifyBox : Form
    {
        public bool isCodeValid = false;
        private Signup signup;

        public CodVerifyBox(Signup signup)
        {
            InitializeComponent();
            this.signup = signup;
        }

        private void ConfirmverifycodeButton_Click(object sender, EventArgs e)
        {
            if (signup.codigoVerificacao == VerifycodeBox.Text)
            {
                isCodeValid = true;
                MessageBox.Show("Código válido.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Código inválido.");
            }
        }

        private void SendnewcodeButton_Click(object sender, EventArgs e)
        {
            signup.sendMail();
        }
    }
}
