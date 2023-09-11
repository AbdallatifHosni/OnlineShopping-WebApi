using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineShopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  byte [] image { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }


    }
}
