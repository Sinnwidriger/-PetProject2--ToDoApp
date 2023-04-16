using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ToDoApp.ViewModels;

namespace ToDoApp.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}