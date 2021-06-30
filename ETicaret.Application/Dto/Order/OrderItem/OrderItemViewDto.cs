using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Order.OrderItem
{
    public class OrderItemViewDto
    {
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}