using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Category;
using ETicaret.Application.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;

namespace ETicaret.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task Add(CategoryAddDto entity)
        {
           await _unitofWork.Category.Add(_mapper.Map<Category>(entity));
           await _unitofWork.SaveChangesAsync();
        }

        public void Delete(CategoryDeleteDto entity)
        {
            _unitofWork.Category.Delete(_mapper.Map<Category>(entity));
            _unitofWork.SaveChangesAsync();
        }

        public void Update(CategoryUpdateDto entity)
        {
             _unitofWork.Category.Update(_mapper.Map<Category>(entity));
             _unitofWork.SaveChangesAsync();
        }

        public Task<List<CategoryViewDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryViewDto>> Get(Expression<Func<CategoryViewDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
