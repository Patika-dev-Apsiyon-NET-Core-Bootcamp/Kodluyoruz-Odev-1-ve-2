using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Category;
using ETicaret.Application.Dto.Comment;
using ETicaret.Application.Dto.Favorite;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Profiles
{
    public class FavoriteProfile : Profile
    {
        public FavoriteProfile()
        {
            CreateMap<FavoriteAddDto, Favorite>().ReverseMap();
            CreateMap<FavoriteDeleteDto, Favorite>().ReverseMap();
            CreateMap<FavoriteUpdateDto, Favorite>().ReverseMap();
            CreateMap<FavoriteViewDto, Favorite>().ReverseMap();

        }
    }
}
