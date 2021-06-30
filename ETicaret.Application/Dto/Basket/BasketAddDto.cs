using System;
using System.Collections.Generic;

namespace ETicaret.Application.Dto.Basket
{
    public class BasketAddDto
    {
        public Guid UserId { get; set; }
        public  List<BasketItemAddDto> Items { get; set; }
    }

    public class BasketViewDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public Guid UserId { get; set; }
        public List<BasketItemViewDto> Items { get; set; }
    }
}
