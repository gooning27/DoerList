namespace DoerList
{
    partial class RegistrationUI
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
            btnRegister = new Button();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            txtBoxUsername = new TextBox();
            lblUsername = new Label();
            txtBoxCfmPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(247, 240);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 38);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(207, 100);
            txtBoxPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(177, 31);
            txtBoxPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 103);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(207, 36);
            txtBoxUsername.Margin = new Padding(4, 5, 4, 5);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(177, 31);
            txtBoxUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(43, 36);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // txtBoxCfmPassword
            // 
            txtBoxCfmPassword.Location = new Point(207, 179);
            txtBoxCfmPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxCfmPassword.Name = "txtBoxCfmPassword";
            txtBoxCfmPassword.PasswordChar = '*';
            txtBoxCfmPassword.Size = new Size(177, 31);
            txtBoxCfmPassword.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 179);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 12;
            label1.Text = "Confirm Password";
            // 
            // RegistrationUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 316);
            Controls.Add(txtBoxCfmPassword);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(lblUsername);
            Name = "RegistrationUI";
            Text = "RegistrationUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private TextBox txtBoxUsername;
        private Label lblUsername;
        private TextBox txtBoxCfmPassword;
        private Label label1;
    }
}