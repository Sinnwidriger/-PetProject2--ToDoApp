using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public interface ITaskItemService
    {
        IEnumerable<TaskItem> GetTaskItems();
    }

    public class TaskItemService : ITaskItemService
    {
        private static List<TaskItem> _samples = new()
        {
            new TaskItem("Task #1", false),
            new TaskItem("Task #2", false),
            new TaskItem("Task #3", false),
            new TaskItem("Task #4", false)
        };

        public IEnumerable<TaskItem> GetTaskItems()
        {
            return _samples;
        }
    }
}
