using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ETicaret.Application.Dto.Comment;

namespace ETicaret.Application.Interfaces
{
    public interface ICommentService
    {
        Task Add(CommentAddDto entity);
        void Delete(CommentDeleteDto entity);
        void Update(CommentUpdateDto entity);
        Task<List<CommentViewDto>> GetAll();
        Task<List<CommentViewDto>> Get(Expression<Func<CommentViewDto, bool>> filter);
    }
}
