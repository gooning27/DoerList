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
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
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
            // ProfileUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 518);
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
    }
}