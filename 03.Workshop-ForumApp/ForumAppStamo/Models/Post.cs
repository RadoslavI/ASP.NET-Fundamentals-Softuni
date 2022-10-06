using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ForumAppStamo.Constants.DataConstants.Post;

namespace ForumAppStamo.Models
{
    public class Post
    {
        [Key]
        [Comment("Post Identifier")]
        public int Id { get; set; }

        [Comment("Post title")]
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Comment("Content")]
        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;
    }
}
