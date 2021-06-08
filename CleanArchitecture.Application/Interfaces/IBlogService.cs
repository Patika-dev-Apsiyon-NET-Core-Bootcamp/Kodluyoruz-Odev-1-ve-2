using CleanArchitecture.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBlogService : IService<BlogViewModel>
    {
        List<BlogViewModel> GetAllByCategory(int categoryId);

        Task AddWithCategories(BlogViewModel blog);

        List<BlogViewModel> GetAllByTag(int tagId);

        Task AddWithTags(BlogViewModel blog);
    }
}
