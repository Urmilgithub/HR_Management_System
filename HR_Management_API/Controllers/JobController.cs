using AutoMapper;
using HR_Management_API.Models.DTO;
using HR_Management_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository jobRepository;
        private readonly IMapper mapper;

        public JobController(IJobRepository _jobRepository, IMapper _mapper)
        {
            jobRepository = _jobRepository;
            mapper = _mapper;
        }

        [HttpGet("GetAllJobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobDomain = await jobRepository.GetAllJobs();
            return Ok(mapper.Map<JobDTO>(jobDomain));
        }

        [HttpGet("GetJobBy_Id")]
        public async Task<IActionResult> GetJobbyId(int id)
        {
            var jobDomain = await jobRepository.GetJobById(id);
            if(jobDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<JobDTO>(jobDomain));
        }
    }
}
