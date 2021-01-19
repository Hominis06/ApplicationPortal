using ApplicationPortal.Data.Interfaces;
using ApplicationPortal.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationPortal.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent _appDBContent)
        {
            this.appDBContent = _appDBContent;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return appDBContent.Category;
            }
        }

    }
}
