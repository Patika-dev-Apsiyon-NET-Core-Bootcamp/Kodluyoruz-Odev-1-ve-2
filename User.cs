using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RoleManagement
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public IdentityRole Role { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
