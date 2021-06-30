using System;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Favorite
{
    public class FavoriteViewDto
    {
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
