using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Orders>? Orders { get; set; } = new List<Orders>();
       
        public virtual ICollection<Cart>? Carts { get; set; } = new List<Cart>();
        public virtual ICollection<WishList>? Wishlists { get; set; } = new List<WishList>();
        public virtual ICollection<Payment>? Payments { get; set; } = new List<Payment>();
        public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
        //public virtual ICollection<RefreshToken>? RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
