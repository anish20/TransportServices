using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TransportServices.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VehicleManagementController : Controller
    {
        public IActionResult VehicleIn()
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult VehicleOut()
=======
        public IActionResult Report()
        {
            return View();
        }

        public IActionResult ViewVehicle()
        {
            return View();
        }

        public IActionResult AddVehicle()
>>>>>>> 084ec3d57de57b20e505b6b62feb9ad14e1bd89d
        {
            return View();
        }
    }
}