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
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        //[HttpPut("Add")]
        //public async Task<IActionResult> Add(string login, )
        //{
        //    if (string.IsNullOrEmpty(name)) throw new HttpException("Invalid name", System.Net.HttpStatusCode.BadRequest);
        //        IdentityResult result = await _userManager.CreateAsync(new User{ UserName = ""});
        //        if (result.Succeeded)
        //        {
        //            return Ok("Successfully added User");
        //        }
        //        else
        //        {
        //            return BadRequest();
        //        }
            
        //}
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            return await _userManager.Users.ToListAsync();
        }

}
}
