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
    public class CityController : ControllerBase
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public CityController(ICityRepository _cityRepository, IMapper _mapper)
        {
            cityRepository = _cityRepository;
            mapper = _mapper;
        }

        [HttpGet("GetCityList")]
        public async Task<IActionResult> GetCity()
        {
            var cityDomain = await cityRepository.GetCityListAsync();
            return Ok(mapper.Map<List<CityDTO>>(cityDomain));
        }

        [HttpGet("GetCityById")]
        public async Task<IActionResult> GetById(int id)
        {
            var cityDomain = await cityRepository.GetCityByIdAsync(id);
            if(cityDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CityDTO>(cityDomain));
        }

        [HttpPost("AddCity")]
        public async Task<IActionResult> AddCity(AddCityDTO addCityDTO)
        {
            var cityDomain = mapper.Map<City>(addCityDTO);               
            await cityRepository.AddCityAsync(cityDomain);
            return Ok(mapper.Map<CityDTO>(cityDomain));
        }

        [HttpPut("UpdateCityById")]
        public async Task<IActionResult> UpdateCity(int id, UpdateCityDTO updateCityDTO)
        {
            var cityDomain = mapper.Map<City>(updateCityDTO);
            if(cityDomain == null)
            {
                return NotFound();
            }
            await cityRepository.UpdateCityAsync(id, cityDomain);
            return Ok(mapper.Map<CityDTO>(cityDomain));
        }

        [HttpDelete("DeleteCityById")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var cityDomain = await cityRepository.DeleteCityByIdAsync(id);
            if (cityDomain == null)
            {
                return NotFound();
            }            
            return Ok(mapper.Map<CityDTO>(cityDomain));
        }
    }
}
