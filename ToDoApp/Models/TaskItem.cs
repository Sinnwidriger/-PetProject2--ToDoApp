using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class TaskItem
    {
        public TaskItem() { }
        public TaskItem(string name, bool completed = false)
        {
            this.Name = name;
            this.Completed = completed;
        }

        public string Name { get; set; } = "";
        public bool Completed { get; set; } = false;
    }
}
