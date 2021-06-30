using System;
using System.Collections.Generic;

namespace ETicaret.Application.Dto.Basket
{
    public class BasketUpdateDto
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public List<BasketItemUpdateDto> Items { get; set; }
    }
}
