using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartWorkspace.Domain.Entities.Identity;

namespace SmartWorkspace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        public UsersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userManager.Users
                .Select(u => new { u.Id, u.UserName, u.FullName, u.Email, u.IsActive })
                .ToList();

            return Ok(users);
        }

        [HttpPut("{id}/activate")]
        public async Task<IActionResult> Activate(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.IsActive = true;
            await _userManager.UpdateAsync(user);
            return Ok();
        }

        [HttpPut("{id}/deactivate")]
        public async Task<IActionResult> Deactivate(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.IsActive = false;
            await _userManager.UpdateAsync(user);
            return Ok();
        }
    }
}
