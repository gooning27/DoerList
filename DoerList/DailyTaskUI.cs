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
            label1.Location = new Point(8, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Daily task";
            // 
            // button1
            // 
            button1.Location = new Point(681, 319);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(104, 36);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 95);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(603, 20);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(604, 58);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(333, 89);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(100, 23);
            txtTask.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(135, 319);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(104, 36);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(257, 319);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(104, 36);
            btnRemoveAll.TabIndex = 8;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(25, 144);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(211, 124);
            listBoxTasks.TabIndex = 9;
            // 
            // chkDaily
            // 
            chkDaily.AutoSize = true;
            chkDaily.Location = new Point(333, 135);
            chkDaily.Name = "chkDaily";
            chkDaily.Size = new Size(83, 19);
            chkDaily.TabIndex = 10;
            chkDaily.Text = "checkBox1";
            chkDaily.UseVisualStyleBackColor = true;
            // 
            // btnReloadDailyTasks
            // 
            btnReloadDailyTasks.Location = new Point(367, 319);
            btnReloadDailyTasks.Name = "btnReloadDailyTasks";
            btnReloadDailyTasks.Size = new Size(104, 36);
            btnReloadDailyTasks.TabIndex = 11;
            btnReloadDailyTasks.Text = "Relaod Dailys";
            btnReloadDailyTasks.UseVisualStyleBackColor = true;
            btnReloadDailyTasks.Click += btnReloadDailyTasks_Click;
            // 
            // DailyTaskUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 379);
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
            Margin = new Padding(2);
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
