
using System.Collections.ObjectModel;

namespace MauiAppTodolist

{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> tasks;



        public MainPage()
        {
            InitializeComponent();
            tasks = new ObservableCollection<string>();
            TasksListView.ItemsSource = tasks;
        }

        private void OnAddTaskClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
            {
                tasks.Add(TaskEntry.Text);
                TaskEntry.Text = string.Empty; 
            }
        }

        private void OnDeleteTaskClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var task = button.CommandParameter as string;
            tasks.Remove(task); 
        }

    }

}
