using System;
using System.Collections.Generic;
using ETicaret.Application.Dto.Order.OrderItem;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Order
{
    public class OrderAddDto
    {
        public virtual User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TotalPrice { get; set; }
        public virtual ICollection<OrderItemViewDto> OrderItems { get; set; }
        public string Address { get; set; }
    }
}
