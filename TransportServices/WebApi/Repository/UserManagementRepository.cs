using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransportServices.Data;
using TransportServices.Data.AdminDbModels;
using TransportServices.WebApi.Repository;

namespace TransportServices.WebApi.Repository
{
    public class UserManagementRepository
    {
        public readonly TransportDbContext _dbContext;
        public UserManagementRepository(TransportDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserModel>> GetAllUser()
        {
            try
            {
                return await _dbContext.UserModels.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
