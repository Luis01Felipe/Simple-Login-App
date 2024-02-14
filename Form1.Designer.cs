namespace Simple_Login_App
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button LoginButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.MailBox = new System.Windows.Forms.TextBox();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.SignupLabel = new System.Windows.Forms.Label();
            this.ViewpassCheckbox = new System.Windows.Forms.CheckBox();
            this.PasscheckImagelist = new System.Windows.Forms.ImageList(this.components);
            LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = System.Drawing.Color.Indigo;
            LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            LoginButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            LoginButton.Location = new System.Drawing.Point(374, 316);
            LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(84, 29);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Logar";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(264, 190);
            this.MailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(314, 26);
            this.MailBox.TabIndex = 0;
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntroLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.IntroLabel.Location = new System.Drawing.Point(169, 94);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(543, 20);
            this.IntroLabel.TabIndex = 1;
            this.IntroLabel.Text = "Olá, seja bem vindo ao meu app, por favor, faça login ou cadastre-se no app";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(264, 225);
            this.PassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(314, 26);
            this.PassBox.TabIndex = 2;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassEnterKey);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.BackColor = System.Drawing.Color.Transparent;
            this.MailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MailLabel.Location = new System.Drawing.Point(204, 194);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(57, 20);
            this.MailLabel.TabIndex = 3;
            this.MailLabel.Text = "E-mail:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PassLabel.Location = new System.Drawing.Point(202, 229);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(60, 20);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Senha:";
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SignupLabel.Location = new System.Drawing.Point(254, 272);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(344, 20);
            this.SignupLabel.TabIndex = 6;
            this.SignupLabel.Text = "Não tem uma conta? Clique aqui e cadastre-se.";
            this.SignupLabel.Click += new System.EventHandler(this.SignupLabel_Click);
            // 
            // ViewpassCheckbox
            // 
            this.ViewpassCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewpassCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ViewpassCheckbox.AutoSize = true;
            this.ViewpassCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ViewpassCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewpassCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewpassCheckbox.ImageIndex = 0;
            this.ViewpassCheckbox.ImageList = this.PasscheckImagelist;
            this.ViewpassCheckbox.Location = new System.Drawing.Point(586, 225);
            this.ViewpassCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewpassCheckbox.Name = "ViewpassCheckbox";
            this.ViewpassCheckbox.Size = new System.Drawing.Size(22, 22);
            this.ViewpassCheckbox.TabIndex = 7;
            this.ViewpassCheckbox.UseVisualStyleBackColor = false;
            this.ViewpassCheckbox.CheckedChanged += new System.EventHandler(this.ViewpassCheckbox_CheckedChanged);
            // 
            // PasscheckImagelist
            // 
            this.PasscheckImagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PasscheckImagelist.ImageStream")));
            this.PasscheckImagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.PasscheckImagelist.Images.SetKeyName(0, "ViewPassFalse (Personalizado).png");
            this.PasscheckImagelist.Images.SetKeyName(1, "ViewPassTrue (Personalizado).png");
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(826, 415);
            this.Controls.Add(this.ViewpassCheckbox);
            this.Controls.Add(this.SignupLabel);
            this.Controls.Add(LoginButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.MailBox);
            this.Location = new System.Drawing.Point(960, 540);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.CheckBox ViewpassCheckbox;
        public System.Windows.Forms.ImageList PasscheckImagelist;
    }
}

