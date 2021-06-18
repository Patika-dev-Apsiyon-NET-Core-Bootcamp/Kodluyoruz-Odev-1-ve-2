using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsService.Data
{
    public class SmsDbContext : IdentityDbContext
    {
        public SmsDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
