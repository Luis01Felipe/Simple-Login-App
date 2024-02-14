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
            this.BorndateLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.BorndateDatepicker = new System.Windows.Forms.DateTimePicker();
            this.TelephoneBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(186, 167);
            this.MailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MailBox.MaxLength = 50;
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(180, 22);
            this.MailBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(186, 193);
            this.PassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassBox.MaxLength = 20;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(180, 22);
            this.PassBox.TabIndex = 1;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MailLabel.Location = new System.Drawing.Point(133, 170);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(48, 16);
            this.MailLabel.TabIndex = 2;
            this.MailLabel.Text = "E-mail:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PassLabel.Location = new System.Drawing.Point(131, 196);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(49, 16);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Senha:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(133, 65);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Nome:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(186, 62);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(180, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LastnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LastnameLabel.Location = new System.Drawing.Point(99, 91);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(81, 16);
            this.LastnameLabel.TabIndex = 7;
            this.LastnameLabel.Text = "Sobrenome:";
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(186, 88);
            this.LastnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastnameBox.MaxLength = 50;
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(180, 22);
            this.LastnameBox.TabIndex = 6;
            this.LastnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastnameBox_KeyPress);
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.Brown;
            this.SignupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignupButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignupButton.Location = new System.Drawing.Point(242, 231);
            this.SignupButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(124, 38);
            this.SignupButton.TabIndex = 8;
            this.SignupButton.Text = "Realizar Cadastro";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // BorndateLabel
            // 
            this.BorndateLabel.AutoSize = true;
            this.BorndateLabel.BackColor = System.Drawing.Color.Transparent;
            this.BorndateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BorndateLabel.Location = new System.Drawing.Point(98, 117);
            this.BorndateLabel.Name = "BorndateLabel";
            this.BorndateLabel.Size = new System.Drawing.Size(82, 16);
            this.BorndateLabel.TabIndex = 10;
            this.BorndateLabel.Text = "Nascimento:";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TelephoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TelephoneLabel.Location = new System.Drawing.Point(116, 144);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(64, 16);
            this.TelephoneLabel.TabIndex = 13;
            this.TelephoneLabel.Text = "Telefone:";
            // 
            // BorndateDatepicker
            // 
            this.BorndateDatepicker.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.BorndateDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BorndateDatepicker.Location = new System.Drawing.Point(186, 114);
            this.BorndateDatepicker.Name = "BorndateDatepicker";
            this.BorndateDatepicker.Size = new System.Drawing.Size(100, 22);
            this.BorndateDatepicker.TabIndex = 14;
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.Location = new System.Drawing.Point(186, 141);
            this.TelephoneBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TelephoneBox.MaxLength = 11;
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Size = new System.Drawing.Size(180, 22);
            this.TelephoneBox.TabIndex = 15;
            this.TelephoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneBox_KeyPress);
            this.TelephoneBox.Leave += new System.EventHandler(this.TelephoneBox_Leave);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Brown;
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnButton.Location = new System.Drawing.Point(101, 231);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(124, 38);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Voltar";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(482, 333);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.BorndateDatepicker);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.BorndateLabel);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.MailBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signup";
            this.Text = "Signup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Signup_FormClosed);
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
        private System.Windows.Forms.Label BorndateLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.DateTimePicker BorndateDatepicker;
        public System.Windows.Forms.TextBox TelephoneBox;
        private System.Windows.Forms.Button ReturnButton;
    }
}