using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workstatic.Data;

namespace Workstatic.Controllers
{
    [Route("api/jobposting")]
    [ApiController]
    public class ApiJobPosting : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ApiJobPosting(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")] // GetAll : eigener Endpunkt Name 
        public IActionResult GetAll()
        {
            var allJobPostings = _context.JobPostings.ToArray();
            return Ok(allJobPostings);
        }
    }
}
