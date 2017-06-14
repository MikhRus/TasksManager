using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TasksManager.ViewModels.Request
{
    public class UpdateProjectRequest
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; }
    }
}
