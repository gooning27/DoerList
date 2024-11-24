using static DoerList.TaskItem;

namespace DoerList
{
    public partial class MainForm : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private NotificationWindow notification;
        public MainForm()
        {
            InitializeComponent();
            notification = new NotificationWindow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxNewTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTaskList();
            UpdateProgressBar();
        }

        private void btnMainToProfile_Click(object sender, EventArgs e)
        {
            ProfileUI profileForm = new ProfileUI();
            profileForm.ShowDialog();
        }

        private void btnMainToDaily_Click(object sender, EventArgs e)
        {
            DailyTaskUI dailyTaskForm = new DailyTaskUI(tasks);
            dailyTaskForm.TaskUpdated += (s, args) =>
            {

                UpdateTaskList();
                UpdateProgressBar();
                HighlightTaskDates();
            };
            dailyTaskForm.ShowDialog();
        }

        private void UpdateTaskList()
        {
            listViewTask.Items.Clear();
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    ListViewItem item = new ListViewItem(task.Name);
                    item.SubItems.Add(task.DueDate.ToShortDateString());
                    listViewTask.Items.Add(item);
                }
            }
        }
        private void UpdateProgressBar()
        {
            int totalTasks = tasks.Count;
            int completedTasks = tasks.FindAll(t => t.IsCompleted).Count;

            progressBar.Value = totalTasks > 0 ? (completedTasks * 100) / totalTasks : 0;
        }
        private void HighlightTaskDates()
        {
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    monthCalendar.AddBoldedDate(task.DueDate);
                }
            }
            monthCalendar.UpdateBoldedDates();
        }

        private void btnAddTaskMain_Click(object sender, EventArgs e)
        {
            string newTask = Microsoft.VisualBasic.Interaction.InputBox(
               "Enter Task Details:", "Add Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                tasks.Add(new TaskItem(newTask, DateTime.Now.AddDays(1))); 
                UpdateTaskList();
                ShowNotification("Task added successfully!", NotificationType.Success);
            }
            else
            {
                ShowNotification("Task cannot be empty!", NotificationType.Warning);
            }
        }

        private void btnRemoveTaskMain_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTask.SelectedItems)
                {
                    tasks.RemoveAll(t => t.Name == selectedItem.Text);
                    listViewTask.Items.Remove(selectedItem);
                }
                ShowNotification("Selected task(s) removed successfully!", NotificationType.Success);
                UpdateProgressBar();
            }
            else
            {
                ShowNotification("Please select a task to remove!", NotificationType.Warning);
            }
        }

        private void btnClearAllMain_Click(object sender, EventArgs e)
        {
            if (tasks.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to clear all tasks?",
                    "Confirm Clear All",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    tasks.Clear();
                    UpdateTaskList();
                    UpdateProgressBar();
                    ShowNotification("All tasks cleared successfully!", NotificationType.Success);
                }
            }
            else
            {
                ShowNotification("No tasks to clear!", NotificationType.Info);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//btnSearch
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter search term:", "Search Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                foreach (ListViewItem item in listViewTask.Items)
                {
                    item.Selected = item.Text.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                }

                int selectedCount = listViewTask.SelectedItems.Count;
                if (selectedCount > 0)
                {
                    ShowNotification($"Found {selectedCount} matching task(s).", NotificationType.Info);
                }
                else
                {
                    ShowNotification($"No tasks found matching \"{searchTerm}\".", NotificationType.Info);
                }
            }
            else
            {
                ShowNotification("Search term cannot be empty!", NotificationType.Warning);
            }
        }

        private void ShowNotification(string message, NotificationType type)
        {
            notification.CaptionText = "Task Manager";
            notification.ContentText = message;
            notification.Show(type);
        }

        public enum NotificationType
        {
            Success,
            Warning,
            Error,
            Info
        }
        public class TaskItem
        {
            public string Name { get; set; }
            public DateTime DueDate { get; set; }
            public bool IsCompleted { get; set; }

            public TaskItem(string name, DateTime dueDate, bool isCompleted = false)
            {
                Name = name;
                DueDate = dueDate;
                IsCompleted = isCompleted;
            }

        }

         

    }
}
