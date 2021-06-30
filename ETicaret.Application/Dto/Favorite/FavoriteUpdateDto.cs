using System.Collections.Generic;
using ETicaret.Application.Dto.Category;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Favorite
{
    public class FavoriteUpdateDto
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
