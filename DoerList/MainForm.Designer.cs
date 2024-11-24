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
            btnAddTaskMain = new Button();
            btnRemoveTaskMain = new Button();
            progressBar = new ProgressBar();
            monthCalendar = new MonthCalendar();
            lblProgress = new Label();
            btnMainToDaily = new Button();
            btnMainToProfile = new Button();
            label1 = new Label();
            label2 = new Label();
            listViewTask = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            textBox1 = new TextBox();
            button1 = new Button();
            btnClearAllMain = new Button();
            lblPendingTasks = new Label();
            SuspendLayout();
            // 
            // btnAddTaskMain
            // 
            btnAddTaskMain.Location = new Point(900, 306);
            btnAddTaskMain.Margin = new Padding(4, 5, 4, 5);
            btnAddTaskMain.Name = "btnAddTaskMain";
            btnAddTaskMain.Size = new Size(107, 38);
            btnAddTaskMain.TabIndex = 2;
            btnAddTaskMain.Text = "Add Task";
            btnAddTaskMain.UseVisualStyleBackColor = true;
            btnAddTaskMain.Click += btnAddTaskMain_Click;
            // 
            // btnRemoveTaskMain
            // 
            btnRemoveTaskMain.Location = new Point(1030, 306);
            btnRemoveTaskMain.Margin = new Padding(4, 5, 4, 5);
            btnRemoveTaskMain.Name = "btnRemoveTaskMain";
            btnRemoveTaskMain.Size = new Size(124, 38);
            btnRemoveTaskMain.TabIndex = 3;
            btnRemoveTaskMain.Text = "Remove Task";
            btnRemoveTaskMain.UseVisualStyleBackColor = true;
            btnRemoveTaskMain.Click += btnRemoveTaskMain_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(843, 31);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(298, 45);
            progressBar.TabIndex = 4;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(127, 14);
            monthCalendar.Margin = new Padding(13, 15, 13, 15);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;
            // 
            // lblProgress
            // 
            lblProgress.AccessibleRole = AccessibleRole.None;
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(843, 90);
            lblProgress.Margin = new Padding(4, 0, 4, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(203, 60);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "Progress:";
            // 
            // btnMainToDaily
            // 
            btnMainToDaily.Location = new Point(473, 90);
            btnMainToDaily.Name = "btnMainToDaily";
            btnMainToDaily.Size = new Size(151, 43);
            btnMainToDaily.TabIndex = 13;
            btnMainToDaily.Text = "Enter";
            btnMainToDaily.UseVisualStyleBackColor = true;
            btnMainToDaily.Click += btnMainToDaily_Click;
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
            btnMainToProfile.Click += btnMainToProfile_Click;
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
            // listViewTask
            // 
            listViewTask.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewTask.Location = new Point(581, 413);
            listViewTask.Name = "listViewTask";
            listViewTask.Size = new Size(573, 204);
            listViewTask.TabIndex = 17;
            listViewTask.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Task";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Due Date";
            columnHeader2.Width = 150;
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
            button1.Click += button1_Click;
            // 
            // btnClearAllMain
            // 
            btnClearAllMain.Location = new Point(1042, 363);
            btnClearAllMain.Name = "btnClearAllMain";
            btnClearAllMain.Size = new Size(112, 34);
            btnClearAllMain.TabIndex = 20;
            btnClearAllMain.Text = "Clear All task";
            btnClearAllMain.UseVisualStyleBackColor = true;
            btnClearAllMain.Click += btnClearAllMain_Click;
            // 
            // lblPendingTasks
            // 
            lblPendingTasks.AccessibleRole = AccessibleRole.None;
            lblPendingTasks.AutoSize = true;
            lblPendingTasks.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingTasks.Location = new Point(831, 178);
            lblPendingTasks.Margin = new Padding(4, 0, 4, 0);
            lblPendingTasks.Name = "lblPendingTasks";
            lblPendingTasks.Size = new Size(306, 60);
            lblPendingTasks.TabIndex = 21;
            lblPendingTasks.Text = "Pending Tasks:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 686);
            Controls.Add(lblPendingTasks);
            Controls.Add(btnClearAllMain);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listViewTask);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMainToProfile);
            Controls.Add(btnMainToDaily);
            Controls.Add(lblProgress);
            Controls.Add(monthCalendar);
            Controls.Add(progressBar);
            Controls.Add(btnRemoveTaskMain);
            Controls.Add(btnAddTaskMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoerList";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTaskMain;
        private Button btnRemoveTaskMain;
        private ProgressBar progressBar;
        private MonthCalendar monthCalendar;
        private Label lblProgress;
        private Button btnMainToDaily;
        private Button btnMainToProfile;
        private Label label1;
        private Label label2;
        private ListView listViewTask;
        private TextBox textBox1;
        private Button button1;
        private Button btnClearAllMain;
        private Label lblPendingTasks;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
