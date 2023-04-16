using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class TaskItemViewModel : ReactiveObject
    {
        public TaskItemViewModel() { }
        public TaskItemViewModel(string name, bool completed = false)
        {
            Name = name;
            Completed = completed;
        }
        public TaskItemViewModel(TaskItem model)
        {
            Name = model.Name;
            Completed = model.Completed;
        }

        private string _name = "";
        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        private bool _completed = false;
        public bool Completed
        {
            get => _completed;
            set => this.RaiseAndSetIfChanged(ref _completed, value);
        }
    }
}
