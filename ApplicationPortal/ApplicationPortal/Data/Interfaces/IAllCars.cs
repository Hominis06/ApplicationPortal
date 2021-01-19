using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationPortal.Data.Models;

namespace ApplicationPortal.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavouriteCars { get; }
        Car GetObjectCar(int _carId);
    }
}
