using ReactiveUI;

namespace ToDoApp.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public string Greeting => "Welcome to Avalonia!";
    }
}