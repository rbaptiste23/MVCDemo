using MVCDemo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListVehicle()
        {

            List<IVehicle> vehicle = new List<IVehicle>();



            vehicle.Add(new CarModel { Make = "Chevy", Model = "Camero", Color = "Black", Year = 2022 });
            vehicle.Add(new CarModel { Make = "Chevy", Model = "Corvette", Color = "Brown", Year = 2021 });
            vehicle.Add(new TruckModel { Make = "Ford", Model = "F150", Color = "Green", Year = 2020 });
            vehicle.Add(new TruckModel { Make = "Dodge", Model = "Durango", Color = "Red", Year = 2019 });


            return View(vehicle);

        }
    }
}