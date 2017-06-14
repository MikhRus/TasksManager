using System;
using System.Collections.Generic;
using System.Text;

namespace TasksManager.ViewModels.Filters
{
   public class TaskFilter
    {
        public string Name { get; set; }
        public TaskStatus? Status { get; set; }
        public DateTime? CreatedDateForm { get; set; }
        public DateTime? CreatedDateTo { get; set; }
        public DateTime? DueDateForm { get; set; }
        public DateTime? DueDateTo { get; set; }
        public DateTime? CompletedDateForm { get; set; }
        public DateTime? CompletedDateTo { get; set; }
        public bool? HasDueDate { get; set; }
        public string Tag { get; set; }
        public int? ProjectId { get; set; }

    }
}
