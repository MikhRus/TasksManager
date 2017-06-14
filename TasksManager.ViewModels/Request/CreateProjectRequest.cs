using System.ComponentModel.DataAnnotations;

namespace TasksManager.ViewModels.Request
{
    public class CreateProjectRequest
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; } //описание проекта

    }
}
