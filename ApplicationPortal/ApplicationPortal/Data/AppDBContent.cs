using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationPortal.Data.Models;

namespace ApplicationPortal.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> _options) : base(options: _options)
        {
        }

        public DbSet<Car> Car { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
