using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Category;
using ETicaret.Application.Dto.Comment;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentAddDto, Comment>().ReverseMap();
            CreateMap<CommentUpdateDto, Comment>().ReverseMap();
            CreateMap<CommentDeleteDto, Comment>().ReverseMap();
            CreateMap<CommentViewDto, Comment>().ReverseMap();

        }
    }
}
