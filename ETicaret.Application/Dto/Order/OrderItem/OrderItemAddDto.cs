using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Order.OrderItem
{
    public class OrderItemAddDto
    {
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}
