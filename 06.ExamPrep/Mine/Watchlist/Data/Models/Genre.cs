using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
#nullable disable
namespace Watchlist.Data.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
