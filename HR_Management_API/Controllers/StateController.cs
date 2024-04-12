using AutoMapper;
using HR_Management_API.Models.DTO;
using HR_Management_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;

        public StateController(IStateRepository _stateRepository, IMapper _mapper)
        {
            this.stateRepository = _stateRepository;
            mapper = _mapper;
        }

        [HttpGet("Get_All_State_List")]
        public async Task<IActionResult> GetAllState()
        {
            var stateDomain = await stateRepository.GetAllStates();
            return Ok(mapper.Map<List<StateDTO>>(stateDomain));
        }
    }
}
