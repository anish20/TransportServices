using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportServices.Data.AdminDbModels;

namespace TransportServices.Data
{
    public class TransportDbContext: DbContext
    {
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public TransportDbContext(DbContextOptions<TransportDbContext> options) : base(options)
        {

        }
    }

}
