﻿using AutoMapper;
using HR_Management_API.Models.Domain;
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

        [HttpGet("GetAllStateList")]
        public async Task<IActionResult> GetAllState()
        {
            var stateDomain = await stateRepository.GetAllStates();
            return Ok(mapper.Map<List<StateDTO>>(stateDomain));
        }

        [HttpGet("GetStateById")]
        public async Task<IActionResult> GetStateById(int id)
        {
            var stateDomain = await stateRepository.GetStateById(id);
            if (stateDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<StateDTO>(stateDomain));
        }

        [HttpPost("AddState")]
        public async Task<IActionResult> AddState(AddStateDTO addStateDTO)
        {
            var stateDomain = mapper.Map<State>(addStateDTO);
            await stateRepository.AddStates(stateDomain);
            return Ok(mapper.Map<StateDTO>(stateDomain));
        }

        [HttpPut("updateStateById")]
        public async Task<IActionResult> UpdateState(UpdateStateDTO updateStateDTO, int id)
        {
            var stateDomain = mapper.Map<State>(updateStateDTO);
            if(stateDomain == null)
            {
                return NotFound();
            }
            await stateRepository.UpdateState(id,stateDomain);
            return Ok(mapper.Map<StateDTO>(stateDomain));
        }

        [HttpDelete("DeleteStateById")]
        public async Task<IActionResult> DeleteStates(int id)
        {
            var stateDomain = await stateRepository.DeleteStateById(id);
            if (stateDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<StateDTO>(stateDomain));
        }
    }
}
