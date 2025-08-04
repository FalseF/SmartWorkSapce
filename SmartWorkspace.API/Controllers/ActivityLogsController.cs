using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWorkspace.Infrastructure;

namespace SmartWorkspace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityLogsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ActivityLogsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            /*var logs = await _db.ActivityLogs
                .OrderByDescending(l => l.CreatedAt)
                .ToListAsync();*/

            //return Ok(logs);
            return Ok();
        }
    }
}
