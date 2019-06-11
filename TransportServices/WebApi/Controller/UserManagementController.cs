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
    public class UserManagementController : ControllerBase
    {
        public readonly UserManagementRepository _userManagementRepository;
        public UserManagementController(TransportDbContext dbContext)
        {
            _userManagementRepository = new UserManagementRepository(dbContext);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserList()
        {
            try
            {
                List<UserModel> obj = await _userManagementRepository.GetAllUser();
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
    }
}