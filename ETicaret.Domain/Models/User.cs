
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Order> Orders { get; set; }
        public virtual Basket Basket { get; set; }
    }
}
