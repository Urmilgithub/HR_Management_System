using AutoMapper;
using HR_Management_API.Models.DTO;
using HR_Management_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DepartmentController(IDepartmentRepository _departmentRepository, IMapper _mapper)
        {
            departmentRepository = _departmentRepository;
            mapper = _mapper;
        }

        [HttpGet("GetAllDepartmentList")]
        public async Task<IActionResult> GetDeptList()
        {
            var deptDomain = await departmentRepository.GetDepartmentListAsync();
            return Ok(mapper.Map<DepartmentDTO>(deptDomain));
        }

        [HttpGet("GetDepartmentById")]
        public async Task<IActionResult> GetDeptById(int id)
        {
            var deptDomain = await departmentRepository.GetDepartmentById(id);
            return Ok(mapper.Map<DepartmentDTO>(deptDomain));
        }
    }
}
