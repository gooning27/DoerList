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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
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
            dateTimePicker1.Location = new Point(595, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(957, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 33);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(959, 102);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(712, 102);
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
            listBoxTasks.Location = new Point(42, 304);
            listBoxTasks.Margin = new Padding(4, 5, 4, 5);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(300, 204);
            listBoxTasks.TabIndex = 9;
            // 
            // chkDaily
            // 
            chkDaily.AutoSize = true;
            chkDaily.Location = new Point(712, 143);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 12;
            label2.Text = "Task Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(366, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 105);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 14;
            label3.Text = "Description:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(366, 102);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 63);
            textBox2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 204);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 16;
            label4.Text = "Priority: ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(366, 201);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 33);
            comboBox2.TabIndex = 17;
            // 
            // DailyTaskUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 632);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox2;
    }
}
