namespace DoerList
{
    partial class PassForm
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
            lblCurrentPassword = new Label();
            txtBoxCurrentPassword = new TextBox();
            txtBoxNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtBoxConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            btnChangePassword = new Button();
            SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(29, 33);
            lblCurrentPassword.Margin = new Padding(4, 0, 4, 0);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(150, 25);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password";
            // 
            // txtBoxCurrentPassword
            // 
            txtBoxCurrentPassword.Location = new Point(180, 33);
            txtBoxCurrentPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxCurrentPassword.Name = "txtBoxCurrentPassword";
            txtBoxCurrentPassword.Size = new Size(211, 31);
            txtBoxCurrentPassword.TabIndex = 1;
            // 
            // txtBoxNewPassword
            // 
            txtBoxNewPassword.Location = new Point(180, 97);
            txtBoxNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxNewPassword.Name = "txtBoxNewPassword";
            txtBoxNewPassword.PasswordChar = '*';
            txtBoxNewPassword.Size = new Size(211, 31);
            txtBoxNewPassword.TabIndex = 3;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(51, 97);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password";
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.Location = new Point(180, 162);
            txtBoxConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.PasswordChar = '*';
            txtBoxConfirmPassword.Size = new Size(211, 31);
            txtBoxConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(23, 162);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 25);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(180, 232);
            btnChangePassword.Margin = new Padding(4, 5, 4, 5);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(119, 38);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // PassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 307);
            Controls.Add(btnChangePassword);
            Controls.Add(txtBoxConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtBoxNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtBoxCurrentPassword);
            Controls.Add(lblCurrentPassword);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PassForm";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPassword;
        private TextBox txtBoxCurrentPassword;
        private TextBox txtBoxNewPassword;
        private Label lblNewPassword;
        private TextBox txtBoxConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnChangePassword;
    }
}