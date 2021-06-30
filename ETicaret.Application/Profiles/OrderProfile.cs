using AutoMapper;
using ETicaret.Application.Dto;
using ETicaret.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Dto.Basket;
using ETicaret.Application.Dto.Order;
using ETicaret.Application.Dto.Order.OrderItem;

namespace ETicaret.Application.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderAddDto, Order>().ReverseMap();
            CreateMap<OrderUpdateDto, Order>().ReverseMap();
            CreateMap<OrderDeleteDto, Order>().ReverseMap();
            CreateMap<OrderViewDto, Order>().ReverseMap();

            CreateMap<OrderItemAddDto, OrderItem>().ReverseMap();
            CreateMap<OrderItemUpdateDto, OrderItem>().ReverseMap();
            CreateMap<OrderItemViewDto, OrderItem>().ReverseMap();
        }
    }
}
