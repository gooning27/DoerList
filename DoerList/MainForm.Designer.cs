namespace DoerList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            progressBar = new ProgressBar();
            calendarTask = new MonthCalendar();
            lblProgress = new Label();
            btnMainToDaily = new Button();
            btnMainToProfile = new Button();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(857, 172);
            btnAddTask.Margin = new Padding(4, 5, 4, 5);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(107, 38);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(987, 172);
            btnRemoveTask.Margin = new Padding(4, 5, 4, 5);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(124, 38);
            btnRemoveTask.TabIndex = 3;
            btnRemoveTask.Text = "Remove Task";
            btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(808, 79);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(298, 45);
            progressBar.TabIndex = 4;
            // 
            // calendarTask
            // 
            calendarTask.Location = new Point(127, 14);
            calendarTask.Margin = new Padding(13, 15, 13, 15);
            calendarTask.Name = "calendarTask";
            calendarTask.TabIndex = 5;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(788, 14);
            lblProgress.Margin = new Padding(4, 0, 4, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(350, 60);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "Current Progress";
            // 
            // btnMainToDaily
            // 
            btnMainToDaily.Location = new Point(473, 90);
            btnMainToDaily.Name = "btnMainToDaily";
            btnMainToDaily.Size = new Size(151, 43);
            btnMainToDaily.TabIndex = 13;
            btnMainToDaily.Text = "Enter";
            btnMainToDaily.UseVisualStyleBackColor = true;
            // 
            // btnMainToProfile
            // 
            btnMainToProfile.BackgroundImage = (Image)resources.GetObject("btnMainToProfile.BackgroundImage");
            btnMainToProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnMainToProfile.Location = new Point(22, 54);
            btnMainToProfile.Name = "btnMainToProfile";
            btnMainToProfile.Size = new Size(70, 62);
            btnMainToProfile.TabIndex = 14;
            btnMainToProfile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 15;
            label1.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 42);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 16;
            label2.Text = "Set Up Daily Task";
            // 
            // listView1
            // 
            listView1.Location = new Point(545, 415);
            listView1.Name = "listView1";
            listView1.Size = new Size(573, 204);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(545, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(701, 315);
            button1.Name = "button1";
            button1.Size = new Size(51, 53);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(994, 352);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 20;
            button2.Text = "Clear All task";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(54, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 21;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 686);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMainToProfile);
            Controls.Add(btnMainToDaily);
            Controls.Add(lblProgress);
            Controls.Add(calendarTask);
            Controls.Add(progressBar);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoerList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTask;
        private Button btnRemoveTask;
        private ProgressBar progressBar;
        private MonthCalendar calendarTask;
        private Label lblProgress;
        private Button btnMainToDaily;
        private Button btnMainToProfile;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}
