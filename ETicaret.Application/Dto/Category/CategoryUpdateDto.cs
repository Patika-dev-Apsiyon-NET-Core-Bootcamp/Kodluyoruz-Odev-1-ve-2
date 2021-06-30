using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Dto.Category
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual CategoryViewDto ParentCategory { get; set; }

        public ICollection<CategoryViewDto> SubCategories { get; set; }
    }
}
