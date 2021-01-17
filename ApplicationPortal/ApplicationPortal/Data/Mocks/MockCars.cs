using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationPortal.Data.Interfaces;
using ApplicationPortal.Data.Models;

namespace ApplicationPortal.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{Name = "Tesla", ShortDesc = "Mask", LongDesc = "Ilon Mask", Img = "/img/Tesla.jpg", Price = 45000, IsFavourite = true, Available = true, Id = 1, Category = categoryCars.AllCategories.ElementAt(0)},
                    new Car{Name = "Ford", ShortDesc = "FordShort", LongDesc = "FordLong", Img = "/img/Ford.jpg", Price = 65000, IsFavourite = false, Available = true, Id = 2, Category = categoryCars.AllCategories.ElementAt(2)},
                    new Car{Name = "Lada", ShortDesc = "KALINA", LongDesc = "TIKAI S GORODU", Img = "/img/Kalina.jpg", Price = 5000, IsFavourite = false, Available = true, Id = 3, Category = categoryCars.AllCategories.ElementAt(1)}
                };
            }
        }
        public IEnumerable<Car> GetFavouriteCars { get; set; }

        public Car GetObjectCar(int _carId)
        {
            throw new NotImplementedException();
        }
    }
}
