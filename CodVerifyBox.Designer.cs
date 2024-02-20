namespace Simple_Login_App
{
    partial class CodVerifyBox
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
            this.ConfirmverifycodeButton = new System.Windows.Forms.Button();
            this.VerifycodeBox = new System.Windows.Forms.TextBox();
            this.InsertcodeLabel = new System.Windows.Forms.Label();
            this.SendnewcodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmverifycodeButton
            // 
            this.ConfirmverifycodeButton.Location = new System.Drawing.Point(116, 101);
            this.ConfirmverifycodeButton.Name = "ConfirmverifycodeButton";
            this.ConfirmverifycodeButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmverifycodeButton.TabIndex = 0;
            this.ConfirmverifycodeButton.Text = "Confirmar";
            this.ConfirmverifycodeButton.UseVisualStyleBackColor = true;
            this.ConfirmverifycodeButton.Click += new System.EventHandler(this.ConfirmverifycodeButton_Click);
            // 
            // VerifycodeBox
            // 
            this.VerifycodeBox.Location = new System.Drawing.Point(70, 75);
            this.VerifycodeBox.Name = "VerifycodeBox";
            this.VerifycodeBox.Size = new System.Drawing.Size(169, 20);
            this.VerifycodeBox.TabIndex = 1;
            // 
            // InsertcodeLabel
            // 
            this.InsertcodeLabel.AutoSize = true;
            this.InsertcodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsertcodeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InsertcodeLabel.Location = new System.Drawing.Point(67, 50);
            this.InsertcodeLabel.Name = "InsertcodeLabel";
            this.InsertcodeLabel.Size = new System.Drawing.Size(172, 13);
            this.InsertcodeLabel.TabIndex = 2;
            this.InsertcodeLabel.Text = "Ensira o código enviado por e-mail.";
            // 
            // SendnewcodeButton
            // 
            this.SendnewcodeButton.Location = new System.Drawing.Point(70, 130);
            this.SendnewcodeButton.Name = "SendnewcodeButton";
            this.SendnewcodeButton.Size = new System.Drawing.Size(169, 23);
            this.SendnewcodeButton.TabIndex = 3;
            this.SendnewcodeButton.Text = "Enviar novo código";
            this.SendnewcodeButton.UseVisualStyleBackColor = true;
            this.SendnewcodeButton.Click += new System.EventHandler(this.SendnewcodeButton_Click);
            // 
            // CodVerifyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(304, 203);
            this.Controls.Add(this.SendnewcodeButton);
            this.Controls.Add(this.InsertcodeLabel);
            this.Controls.Add(this.VerifycodeBox);
            this.Controls.Add(this.ConfirmverifycodeButton);
            this.Name = "CodVerifyBox";
            this.Text = "CodVerifyBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmverifycodeButton;
        private System.Windows.Forms.TextBox VerifycodeBox;
        private System.Windows.Forms.Label InsertcodeLabel;
        private System.Windows.Forms.Button SendnewcodeButton;
    }
}