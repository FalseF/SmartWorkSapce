using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWorkspace.Domain.Entities.Project;
using SmartWorkspace.Infrastructure;

namespace SmartWorkspace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ProjectsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            /*var projects = await _db.Projects
                .Select(p => new { p.Id, p.Name, p.Description, p.CreatedAt })
                .ToListAsync();*/

            //return Ok(projects);
            return Ok(string.Empty.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Project request)
        {
            //_db.Projects.Add(request);
            await _db.SaveChangesAsync();
            return Ok(request);
        }
    }
}
