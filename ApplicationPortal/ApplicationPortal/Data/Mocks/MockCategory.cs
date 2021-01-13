using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationPortal.Data.Interfaces;
using ApplicationPortal.Data.Models;

namespace ApplicationPortal.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        { 
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Электромобили", Desc = "Соврменный вид транспорта", Id = 1},
                    new Category{CategoryName = "Классические автомобили", Desc = "Обычные машины, которые у всех на виду", Id = 2},
                    new Category{CategoryName = "Спортивные автомобили", Desc = "Машины, способные развивать очень большую скорость", Id = 3 }
                };
            }

        }
    }
}
