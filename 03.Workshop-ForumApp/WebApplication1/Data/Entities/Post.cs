using System.ComponentModel.DataAnnotations;
using static ForumApp.Data.DataConstants;

namespace WebApplication1.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }
        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }
    }
}
