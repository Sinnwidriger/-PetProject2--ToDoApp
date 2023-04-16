using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ToDoApp.ViewModels;
using ReactiveMarbles.ObservableEvents;

namespace ToDoApp.Views;

public partial class TaskListView : ReactiveUserControl<TaskListViewModel>
{
    public TaskListView()
    {
        InitializeComponent();
        this.DataContext = new TaskListViewModel();
        
    }
}