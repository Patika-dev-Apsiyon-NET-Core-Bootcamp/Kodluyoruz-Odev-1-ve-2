using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Dto.Category;
using ETicaret.Application.Dto.Order;

namespace ETicaret.Application.Interfaces
{
    public interface IOrderService
    {
        Task Add(OrderAddDto entity);
        void Delete(OrderDeleteDto entity);
        void Update(OrderUpdateDto entity);
        Task<List<OrderViewDto>> GetAll();
        Task<List<OrderViewDto>> Get(Expression<Func<OrderViewDto, bool>> filter);
    }
}
