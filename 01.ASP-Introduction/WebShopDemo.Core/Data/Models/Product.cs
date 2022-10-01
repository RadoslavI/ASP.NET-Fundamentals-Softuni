using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDemo.Core.Data.Models
{
    [Comment("Products to sell")]
    public class Product
    {
        [Key]
        [Comment("Primary key")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("Product name")]
        public string Name { get; set; }

        [Comment("Product price")]
        [Required]
        public decimal Price { get; set; }

        [Comment("Products in stock")]
        [Required]
        public int Quantity { get; set; }

        [Comment("Product status")]
        public bool IsActive { get; set; } = true;
    }
}
