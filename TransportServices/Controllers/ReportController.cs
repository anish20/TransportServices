using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportServices.Models;

namespace TransportServices.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult index()
        {
            return View();
        }


    }
}