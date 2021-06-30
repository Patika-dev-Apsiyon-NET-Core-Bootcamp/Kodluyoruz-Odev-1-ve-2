using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Category;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewDto, Category>().ReverseMap();
            CreateMap<CategoryAddDto, Category>().ReverseMap();
            CreateMap<CategoryDeleteDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();

        }
    }
}
