using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.Task;

namespace TaskBoardApp.Models.Tasks
{
    public class TaskFormModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(MaxTaskTitle, MinimumLength = MinTaskTitle,
            ErrorMessage = "Title should be at least {2} characters long.")]
        public string Title { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(MaxTaskDescription, MinimumLength = MinTaskDescription,
            ErrorMessage = "Description should be at least {2} characters long.")]
        public string Description { get; set; }

        [Display(Name = "Board")]
        public int BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; }
    }
}
