using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal_Website.Models;

namespace Personal_Website.Data
{
    public class Personal_WebsiteContext : DbContext
    {
        public Personal_WebsiteContext (DbContextOptions<Personal_WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Personal_Website.Models.BlogPost> BlogPost { get; set; } = default!;
    }
}
