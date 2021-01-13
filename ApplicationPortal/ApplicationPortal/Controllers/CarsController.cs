using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationPortal.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ApplicationPortal.ViewModels;

namespace ApplicationPortal.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory allCategories;

        public CarsController(IAllCars _iAllCars, ICarsCategory _iCarsCategory)
        {
            allCars = _iAllCars;
            allCategories = _iCarsCategory;
        }

        public ViewResult List()
        {
            CarsListViewModels carListNewModel = new CarsListViewModels();

            ViewBag.Title = "Страница с автомобилями";
            carListNewModel.AllCars = allCars.Cars;
            carListNewModel.CurrentCategory = "Автомобили";
            return View(carListNewModel);
        }
    }
}
