using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain_Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public string? ProductDescription { get; set; }
        [Required]
        public string? ProductImage { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public double Rating { get; set; }
        public virtual ICollection<ProductInShoppingCart>? AllShoppingCarts { get; set; }

    }
}
