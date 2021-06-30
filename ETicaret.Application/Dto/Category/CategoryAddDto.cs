using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Dto.Category
{
    public class CategoryAddDto
    {
        public string Name { get; set; }
        public virtual CategoryViewDto ParentCategory { get; set; }
    
        public ICollection<CategoryViewDto> SubCategories { get; set; }
    }

    public class CategoryViewDto
    {
        public string Name { get; set; }
        public CategoryViewDto ParentCategory { get; set; }
        public ICollection<CategoryViewDto> SubCategories { get; set; }
    }
}
