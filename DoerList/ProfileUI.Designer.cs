namespace DoerList
{
    partial class ProfileUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileUI));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BtnChangeProfile = new Button();
            BtnChangePass = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(38, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 43);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // BtnChangeProfile
            // 
            BtnChangeProfile.Location = new Point(38, 188);
            BtnChangeProfile.Name = "BtnChangeProfile";
            BtnChangeProfile.Size = new Size(171, 34);
            BtnChangeProfile.TabIndex = 2;
            BtnChangeProfile.Text = "Change profile";
            BtnChangeProfile.UseVisualStyleBackColor = true;
            BtnChangeProfile.Click += button1_Click;
            // 
            // BtnChangePass
            // 
            BtnChangePass.Location = new Point(38, 249);
            BtnChangePass.Name = "BtnChangePass";
            BtnChangePass.Size = new Size(171, 34);
            BtnChangePass.TabIndex = 3;
            BtnChangePass.Text = "Change Password";
            BtnChangePass.UseVisualStyleBackColor = true;
            BtnChangePass.Click += BtnChangePass_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 97);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 4;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 149);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 5;
            label3.Text = "Phone:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(351, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(814, 428);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(681, 428);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProfileUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 518);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnChangePass);
            Controls.Add(BtnChangeProfile);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ProfileUI";
            Text = "ProfileUI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnChangeProfile;
        private Button BtnChangePass;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}