using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Dto.Favorite;

namespace ETicaret.Application.Interfaces
{
    public interface IFavoriteService
    {
        Task Add(FavoriteAddDto entity);
        void Delete(FavoriteDeleteDto entity);
        void Update(FavoriteUpdateDto entity);
        Task<List<FavoriteViewDto>> GetAll();
        Task<List<FavoriteViewDto>> Get(Expression<Func<FavoriteViewDto, bool>> filter);
    }
}
