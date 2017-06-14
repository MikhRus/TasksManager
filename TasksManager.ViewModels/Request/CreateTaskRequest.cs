using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.ViewModels.Request
{
    public class CreateTaskRequest
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(4096)]
        public string Description { get; set; }

        public DateTime? DueData { get; set; }
        
        public string [] Tags { get; set; }

        [Required]
        public int ProjectId { get; set; }


    }
}
