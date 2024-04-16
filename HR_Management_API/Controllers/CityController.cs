using AutoMapper;
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
            return Ok(mapper.Map<CityDTO>(cityDomain));
        }

        [HttpGet("GetCityById")]
        public async Task<IActionResult> GetById(int id)
        {
            var cityDomain = await cityRepository.GetCityListAsync();
            if(cityDomain == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CityDTO>(cityDomain));
        }
    }
}
