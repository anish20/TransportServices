using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportServices.Data;
using TransportServices.Data.AdminDbModels;

namespace TransportServices.WebApi.Repository
{
    
    public class VehicleEntryRepository
    {
        public readonly TransportDbContext _dbContext;
        public VehicleEntryRepository(TransportDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //getall 
        public async Task<List<VehicleModel>> GetAll()
        {
            try
            {
                return await _dbContext.VehicleModels.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Get By Vehicle ID
        public async Task<VehicleModel> GetByVehicleNo(string vehicleNo)
        {
            try
            {
                VehicleModel obj = await _dbContext.VehicleModels.Where(a => a.VehicleNo == vehicleNo).FirstOrDefaultAsync();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Add new

        public async Task<bool> AddNew(VehicleModel vehicleModel)
        {
            try
            {
                _dbContext.VehicleModels.Add(vehicleModel);
                int i = await _dbContext.SaveChangesAsync();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
