using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain_Models
{
    public class ProductInShoppingCart
    {
        [Key]
        public Guid Id { get; set; }
        public string? ProductId { get; set; }
        public Product? AddedProduct { get; set; }
        public string? ShoppingCartId { get; set; }
        public ShoppingCart? AddedShoppingCart { get; set; }
        public int Quantity { get; set; }
    }
}
