using AutoMapper;
using HR_Management_API.Models.Domain;
using HR_Management_API.Models.DTO;
using HR_Management_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeController(IEmployeeRepository _employeeRepository, IMapper _mapper)
        {
            employeeRepository = _employeeRepository;
            mapper = _mapper;
        }


        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAll()
        {
            var employeeDomain = await employeeRepository.GetAllAsync();
            return Ok(mapper.Map<List<EmployeeDTO>>(employeeDomain));
        }

        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult> GetById(int id)
        {
            var employeeDomain = await employeeRepository.GetEmployeeById(id);
            if(employeeDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<EmployeeDTO>(employeeDomain));
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(AddEmployeeDTO addEmployeeDTO)
        {
            var employeeDomain = mapper.Map<Employee>(addEmployeeDTO);
            await employeeRepository.AddEmployee(employeeDomain);
            return Ok(mapper.Map<EmployeeDTO>(employeeDomain));
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO, int id)
        {
            var employeeDomain = mapper.Map<Employee>(updateEmployeeDTO);
            employeeDomain = await employeeRepository.UpdateEmployeeById(id, employeeDomain);
            if(employeeDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<EmployeeDTO>(employeeDomain));
            
        }
    }
}
