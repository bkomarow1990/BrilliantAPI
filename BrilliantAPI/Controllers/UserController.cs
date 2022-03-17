using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Exceptions;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrilliantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        [HttpPut("Add")]
        public async Task<IActionResult> Add(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new HttpException("Invalid name", System.Net.HttpStatusCode.BadRequest);
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                {
                    return Ok("Successfully added Role");
                }
                else
                {
                    return BadRequest();
                }
            
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<IdentityRole>>> GetAll()
        {
            return await _roleManager.Roles.ToListAsync();
        }

}
}
