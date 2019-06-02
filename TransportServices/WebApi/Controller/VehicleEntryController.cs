using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportServices.Data;
using TransportServices.Data.AdminDbModels;
using TransportServices.WebApi.Repository;

namespace TransportServices.WebApi.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Area("Admin")]
    public class VehicleEntryController : ControllerBase
    {
        public readonly VehicleEntryRepository _vehicleEntryRepository;
        public VehicleEntryController(TransportDbContext dbContext)
        {
            _vehicleEntryRepository = new VehicleEntryRepository(dbContext);
        }
        //get all
        [HttpGet]
        public async Task<IActionResult> GetReport()
        {
            try
            {
              List<VehicleModel> obj= await _vehicleEntryRepository.GetAll();
                if (obj != null)
                {
                    return Ok(obj);
                }
                else
                {
                   return NotFound("not found");
                }
            }
            catch (Exception)
            {
                return NotFound("throwing exp");
            }
        }

        // Get Report by Vehicle No
        [HttpGet]
        public async Task<IActionResult> GetReportByID(string vehicleNo)
        {
            try
            {
                var obj = await _vehicleEntryRepository.GetByVehicleNo(vehicleNo);
                if (obj != null)
                {
                    return Ok(obj);
                }
                else
                {
                    return NotFound("not found");
                }
            }
            catch (Exception)
            {
                return NotFound("throwing exp");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewVehicleEntry(VehicleModel vehicleModel)
        {
            try
            {
                var obj = await _vehicleEntryRepository.AddNew(vehicleModel);
                if (obj != false)
                {
                    return Ok(obj);
                }
                else
                {
                    return NotFound("not found");
                }
            }
            catch (Exception)
            {
                return NotFound("throwing exp");
            }
        }
    }

}