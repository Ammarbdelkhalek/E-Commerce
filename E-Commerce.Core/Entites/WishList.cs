using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
    public class WishList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
        
        public virtual ICollection<WishListItems>? wishlistItems { get; set; } = new List<WishListItems>();

    }
}
