using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public partial class TaskItemView : ReactiveUserControl<TaskItemViewModel>
{
    public TaskItemView()
    {
        InitializeComponent();
    }
}