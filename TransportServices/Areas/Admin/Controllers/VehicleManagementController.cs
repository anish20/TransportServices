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

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult ViewVehicle()
        {
            return View();
        }

        public IActionResult AddVehicle()
        {
            return View();
        }
    }
}