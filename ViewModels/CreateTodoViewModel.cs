using System.ComponentModel.DataAnnotations;

namespace MeuToDo.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}