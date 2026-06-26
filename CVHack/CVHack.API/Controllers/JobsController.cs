using CVHack.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVHack.API
{
    [Route("api/jobs")]
    [ApiController]
    [Authorize]   // any logged-in user can browse jobs
    public class JobsController : ControllerBase
    {
        private readonly IJobManager _jobManager;

        public JobsController(IJobManager jobManager)
        {
            _jobManager = jobManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _jobManager.GetAllJobsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _jobManager.GetJobByIdAsync(id);
            return StatusCode(result.StatusCode, result);
        }
    }
}