using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public User User { get; set; }
        public virtual ICollection<BasketItem> Items { get; set; }
    }

    public class BasketItem
    {
        public int Id { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}
