namespace DoerList
{
    partial class DailyTaskUI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            txtTask = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnRemoveAll = new Button();
            listBoxTasks = new ListBox();
            chkDaily = new CheckBox();
            btnReloadDailyTasks = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(161, 45);
            label1.TabIndex = 0;
            label1.Text = "Daily task";
            // 
            // button1
            // 
            button1.Location = new Point(973, 532);
            button1.Name = "button1";
            button1.Size = new Size(149, 60);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(861, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 33);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(863, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(476, 148);
            txtTask.Margin = new Padding(4, 5, 4, 5);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(141, 31);
            txtTask.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 532);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 60);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(193, 532);
            btnRemove.Margin = new Padding(4, 5, 4, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(149, 60);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(367, 532);
            btnRemoveAll.Margin = new Padding(4, 5, 4, 5);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(149, 60);
            btnRemoveAll.TabIndex = 8;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 25;
            listBoxTasks.Location = new Point(36, 240);
            listBoxTasks.Margin = new Padding(4, 5, 4, 5);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(300, 204);
            listBoxTasks.TabIndex = 9;
            // 
            // chkDaily
            // 
            chkDaily.AutoSize = true;
            chkDaily.Location = new Point(476, 214);
            chkDaily.Margin = new Padding(4, 5, 4, 5);
            chkDaily.Name = "chkDaily";
            chkDaily.Size = new Size(121, 29);
            chkDaily.TabIndex = 10;
            chkDaily.Text = "checkBox1";
            chkDaily.UseVisualStyleBackColor = true;
            // 
            // btnReloadDailyTasks
            // 
            btnReloadDailyTasks.Location = new Point(524, 532);
            btnReloadDailyTasks.Margin = new Padding(4, 5, 4, 5);
            btnReloadDailyTasks.Name = "btnReloadDailyTasks";
            btnReloadDailyTasks.Size = new Size(149, 60);
            btnReloadDailyTasks.TabIndex = 11;
            btnReloadDailyTasks.Text = "Relaod Dailys";
            btnReloadDailyTasks.UseVisualStyleBackColor = true;
            btnReloadDailyTasks.Click += btnReloadDailyTasks_Click;
            // 
            // DailyTaskUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 632);
            Controls.Add(btnReloadDailyTasks);
            Controls.Add(chkDaily);
            Controls.Add(listBoxTasks);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "DailyTaskUI";
            Text = "DailyTaskUI";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTask;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnRemoveAll;
        private ListBox listBoxTasks;
        private CheckBox chkDaily;
        private Button btnReloadDailyTasks;
    }
}
