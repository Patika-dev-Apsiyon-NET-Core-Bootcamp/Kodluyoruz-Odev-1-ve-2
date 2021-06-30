using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ETicaret.Application.Dto.Favorite;
using ETicaret.Application.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;

namespace ETicaret.Application.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public FavoriteService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task Add(FavoriteAddDto entity)
        {
            await _unitofWork.Favorite.Add(_mapper.Map<Favorite>(entity));
            await _unitofWork.SaveChangesAsync();
        }

        public void Delete(FavoriteDeleteDto entity)
        {
             _unitofWork.Favorite.Delete(_mapper.Map<Favorite>(entity));
             _unitofWork.SaveChangesAsync();
        }

        public void Update(FavoriteUpdateDto entity)
        {
            _unitofWork.Favorite.Update(_mapper.Map<Favorite>(entity));
            _unitofWork.SaveChangesAsync();
        }

        public Task<List<FavoriteViewDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<FavoriteViewDto>> Get(Expression<Func<FavoriteViewDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
