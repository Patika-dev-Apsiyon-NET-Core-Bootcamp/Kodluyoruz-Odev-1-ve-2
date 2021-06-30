using ETicaret.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Dto.Basket;

namespace ETicaret.Application.Interfaces
{
    public interface IBasketService
    {
        Task Add(BasketAddDto entity);
        void Delete(BasketDeleteDto entity);
        void Update(BasketUpdateDto entity);
        Task<List<BasketViewDto>> GetAll();
        Task<List<BasketViewDto>> Get(Expression<Func<BasketViewDto, bool>> filter);

    }
}
