using System;
using System.Collections.Generic;
using System.Text;

namespace TasksManager.ViewModels.Request
{
   public class UpdateTaskRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public TaskStatus Status { get; set; }
        public string[] Tags { get; set; }
    }
}

