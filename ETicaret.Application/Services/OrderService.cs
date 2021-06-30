using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Order;
using ETicaret.Application.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;

namespace ETicaret.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task Add(OrderAddDto entity)
        {
           await _unitofWork.Order.Add(_mapper.Map<Order>(entity));
           await _unitofWork.SaveChangesAsync();
        }

        public void Delete(OrderDeleteDto entity)
        {
             _unitofWork.Order.Delete(_mapper.Map<Order>(entity));
             _unitofWork.SaveChangesAsync();
        }

        public void Update(OrderUpdateDto entity)
        {
            _unitofWork.Order.Update(_mapper.Map<Order>(entity));
            _unitofWork.SaveChangesAsync();
        }

        public Task<List<OrderViewDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderViewDto>> Get(Expression<Func<OrderViewDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
