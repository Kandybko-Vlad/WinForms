using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json; // Для сучасного збереження у JSON
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        // Список усіх завдань
        private List<UserTask> allTasks = new List<UserTask>();
        private readonly string filePath = "tasks.json";

        public Form1()
        {
            InitializeComponent();
            SetupComponents();
            LoadData();
            RefreshListView(allTasks);
        }

        private void SetupComponents()
        {
            // Налаштування ListView (на всякий випадок)
            lvTasks.View = View.Details;
            lvTasks.FullRowSelect = true;

            // Наповнення випадаючих списків
            cmbPriority.Items.AddRange(new string[] { "Низький", "Середній", "Високий" });
            cmbPriority.SelectedIndex = 1;

            cmbFilterStatus.Items.AddRange(new string[] { "Всі", "Нове", "В роботі", "Виконано" });
            cmbFilterStatus.SelectedIndex = 0;
        }

        // КНОПКА "ДОДАТИ ЗАВДАННЯ"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введіть назву завдання!");
                return;
            }

            var newTask = new UserTask
            {
                Title = txtTitle.Text,
                Description = txtDesc.Text,
                DueDate = dtpDate.Value,
                Priority = (cmbPriority.SelectedItem?.ToString()) ?? "Середній",
                Status = "Нове"
            };

            allTasks.Add(newTask);
            SaveData();
            ApplyFilters();

            // Очищення полів після додавання
            txtTitle.Clear();
            txtDesc.Clear();
        }

        // ОНОВЛЕННЯ ТАБЛИЦІ (З ПІДСВІЧУВАННЯМ)
        private void RefreshListView(List<UserTask> tasks)
        {
            lvTasks.Items.Clear();
            foreach (var task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Title);
                item.SubItems.Add(task.Description);
                item.SubItems.Add(task.DueDate.ToShortDateString());
                item.SubItems.Add(task.Priority);
                item.SubItems.Add(task.Status);

                // ПІДСВІЧУВАННЯ: якщо дата минула і не виконано - червоний
                if (task.DueDate.Date < DateTime.Now.Date && task.Status != "Виконано")
                {
                    item.BackColor = Color.LightPink;
                }
                // Якщо виконано - сірий колір тексту
                if (task.Status == "Виконано")
                {
                    item.ForeColor = Color.Gray;
                }

                item.Tag = task; // зберігаємо посилання на об'єкт
                lvTasks.Items.Add(item);
            }
        }

        // ПОШУК ТА ФІЛЬТРАЦІЯ
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string search = txtSearch.Text.ToLower();
            string statusFilter = cmbFilterStatus.SelectedItem?.ToString() ?? "Всі";

            var filtered = allTasks.Where(t =>
                (string.IsNullOrEmpty(search) || t.Title.ToLower().Contains(search)) &&
                (statusFilter == "Всі" || t.Status == statusFilter)
            ).ToList();

            RefreshListView(filtered);
        }

        // ЗМІНА СТАТУСУ (Подвійний клік по рядку)
        private void lvTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                var task = (UserTask)lvTasks.SelectedItems[0].Tag;

                if (task.Status == "Нове") task.Status = "В роботі";
                else if (task.Status == "В роботі") task.Status = "Виконано";
                else task.Status = "Нове";

                SaveData();
                ApplyFilters();
            }
        }

        // ЗБЕРЕЖЕННЯ ТА ЗАВАНТАЖЕННЯ
        private void SaveData()
        {
            string json = JsonSerializer.Serialize(allTasks);
            File.WriteAllText(filePath, json);
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                allTasks = JsonSerializer.Deserialize<List<UserTask>>(json) ?? new List<UserTask>();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterStatus.SelectedIndex = 0;
            ApplyFilters();
        }
    }

    // Клас даних
    public class UserTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}