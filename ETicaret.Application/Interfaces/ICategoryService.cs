using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ETicaret.Application.Dto.Category;

namespace ETicaret.Application.Interfaces
{
    public interface ICategoryService
    {
        Task Add(CategoryAddDto entity);
        void Delete(CategoryDeleteDto entity);
        void Update(CategoryUpdateDto entity);
        Task<List<CategoryViewDto>> GetAll();
        Task<List<CategoryViewDto>> Get(Expression<Func<CategoryViewDto, bool>> filter);
    }
}
