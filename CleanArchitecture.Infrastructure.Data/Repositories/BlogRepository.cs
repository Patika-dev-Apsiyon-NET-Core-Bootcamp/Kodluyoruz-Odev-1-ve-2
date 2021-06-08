using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class BlogRepository : Repository<Blog> , IBlogRepository
    {

        public BlogRepository(BlogDbContext context):base(context)
        {
        }

        public List<Blog> GetAllByCategory(int categoryId)
        {
            return _context.Blogs.Where(x => x.Categories.Any(y => y.Id == categoryId && y.Status)).ToList();
        }

        public async Task AddWithCategories(Blog blog)
        {
            _context.Categories.AttachRange(blog.Categories);
            await base.Add(blog);
        }

        public List<Blog> GetAllByTag(int tagId)
        {
            return _context.Blogs.Where(x => x.Tags.Any(y => y.Id == tagId )).ToList();
        }

        public async Task AddWithTags(Blog blog)
        {
            _context.Tags.AttachRange(blog.Tags);
            await base.Add(blog);
        }
    }
}
