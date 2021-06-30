using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Comment;
using ETicaret.Application.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;

namespace ETicaret.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public CommentService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task Add(CommentAddDto entity)
        {
            await _unitofWork.Comment.Add(_mapper.Map<Comment>(entity));
            await _unitofWork.SaveChangesAsync();
        }

        public void Delete(CommentDeleteDto entity)
        {
            _unitofWork.Comment.Delete(_mapper.Map<Comment>(entity));
            _unitofWork.SaveChangesAsync();
        }

        public void Update(CommentUpdateDto entity)
        {
            _unitofWork.Comment.Update(_mapper.Map<Comment>(entity));
            _unitofWork.SaveChangesAsync();
        }

        public Task<List<CommentViewDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentViewDto>> Get(Expression<Func<CommentViewDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
