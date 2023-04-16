using Avalonia;
using Avalonia.Controls.Mixins;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.ViewModels
{
    public class TaskListViewModel : ReactiveObject
    {
        private ITaskItemService? _taskItemService;
        public TaskListViewModel()
        {
            _taskItemService = AvaloniaLocator.Current.GetService<ITaskItemService>();

            var items = _taskItemService?.GetTaskItems();

            _taskList.Edit(list =>
            {
                list.Clear();
                list.AddRange(items.Select(x => new TaskItemViewModel(x)));
            });

            _taskList
                .Connect()
                .AutoRefresh(task => task.Completed)
                .Filter(task => !task.Completed)
                .Bind(out _uncompletedTasks)
                .Subscribe();

            _taskList
                .Connect()
                .AutoRefresh(task => task.Completed)
                .Filter(task => task.Completed)
                .Bind(out _completedTasks)
                .Subscribe();

            AddNewTaskCommand = ReactiveCommand.Create(() =>
            {
                _taskList.Add(new TaskItemViewModel(NewTaskName));
                NewTaskName = string.Empty;
            });
        }

        private SourceList<TaskItemViewModel> _taskList = new();

        private ReadOnlyObservableCollection<TaskItemViewModel> _uncompletedTasks;
        public ReadOnlyObservableCollection<TaskItemViewModel> UncompletedTasks => _uncompletedTasks;

        private ReadOnlyObservableCollection<TaskItemViewModel> _completedTasks;
        public ReadOnlyObservableCollection<TaskItemViewModel> CompletedTasks => _completedTasks;

        private string _newTaskName = "";
        public string NewTaskName
        {
            get => _newTaskName;
            set => this.RaiseAndSetIfChanged(ref _newTaskName, value);
        }

        ReactiveCommand<Unit, Unit> AddNewTaskCommand { get; }
    }
}
