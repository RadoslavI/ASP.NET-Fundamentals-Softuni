using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Library.Data.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } 
            = new List<Book>();
    }
}