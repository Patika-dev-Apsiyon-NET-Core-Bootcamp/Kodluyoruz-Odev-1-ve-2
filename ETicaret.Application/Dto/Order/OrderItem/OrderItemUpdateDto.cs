using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Order.OrderItem
{
    public class OrderItemUpdateDto
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public int Piece { get; set; }
    }
}