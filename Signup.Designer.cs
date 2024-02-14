namespace Simple_Login_App
{
    partial class Signup
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
            this.MailBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.SignupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BorndayBox = new System.Windows.Forms.TextBox();
            this.BornmonthBox = new System.Windows.Forms.TextBox();
            this.BornyearBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(208, 185);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(195, 26);
            this.MailBox.TabIndex = 0;
            this.MailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(208, 217);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(195, 26);
            this.PassBox.TabIndex = 1;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MailLabel.Location = new System.Drawing.Point(145, 188);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(57, 20);
            this.MailLabel.TabIndex = 2;
            this.MailLabel.Text = "E-mail:";
            this.MailLabel.Click += new System.EventHandler(this.MailLabel_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PassLabel.Location = new System.Drawing.Point(142, 220);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(60, 20);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Senha:";
            this.PassLabel.Click += new System.EventHandler(this.PassLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(145, 66);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Nome:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(208, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(195, 26);
            this.NameBox.TabIndex = 4;
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LastnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LastnameLabel.Location = new System.Drawing.Point(411, 66);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(96, 20);
            this.LastnameLabel.TabIndex = 7;
            this.LastnameLabel.Text = "Sobrenome:";
            this.LastnameLabel.Click += new System.EventHandler(this.LastnameLabel_Click);
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(513, 63);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(195, 26);
            this.LastnameBox.TabIndex = 6;
            this.LastnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.Transparent;
            this.SignupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignupButton.Location = new System.Drawing.Point(290, 391);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(300, 28);
            this.SignupButton.TabIndex = 8;
            this.SignupButton.Text = "Realizar Cadastro";
            this.SignupButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(414, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nascimento";
            // 
            // BorndayBox
            // 
            this.BorndayBox.Location = new System.Drawing.Point(513, 185);
            this.BorndayBox.MaxLength = 2;
            this.BorndayBox.Name = "BorndayBox";
            this.BorndayBox.Size = new System.Drawing.Size(38, 26);
            this.BorndayBox.TabIndex = 9;
            // 
            // BornmonthBox
            // 
            this.BornmonthBox.Location = new System.Drawing.Point(557, 185);
            this.BornmonthBox.MaxLength = 2;
            this.BornmonthBox.Name = "BornmonthBox";
            this.BornmonthBox.Size = new System.Drawing.Size(38, 26);
            this.BornmonthBox.TabIndex = 11;
            // 
            // BornyearBox
            // 
            this.BornyearBox.Location = new System.Drawing.Point(601, 185);
            this.BornyearBox.MaxLength = 4;
            this.BornyearBox.Name = "BornyearBox";
            this.BornyearBox.Size = new System.Drawing.Size(43, 26);
            this.BornyearBox.TabIndex = 12;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(25)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.BornyearBox);
            this.Controls.Add(this.BornmonthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BorndayBox);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.MailBox);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox MailBox;
        public System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label LastnameLabel;
        public System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox BorndayBox;
        public System.Windows.Forms.TextBox BornmonthBox;
        public System.Windows.Forms.TextBox BornyearBox;
    }
}