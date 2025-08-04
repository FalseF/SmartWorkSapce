using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWorkspace.Domain.Entities.Project;
using SmartWorkspace.Infrastructure;

namespace SmartWorkspace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public TasksController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("project/{projectId}")]
        public async Task<IActionResult> GetByProject(Guid projectId)
        {
            /*var tasks = await _db.Tasks
                .Where(t => t.ProjectId == projectId)
                .ToListAsync();*/

            //return Ok(tasks);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TaskItem request)
        {
            //_db.Tasks.Add(request);
            await _db.SaveChangesAsync();
            return Ok(request);
        }
    }
}
