using HR_Management_API.DBContext;
using HR_Management_API.Models.Domain;
using HR_Management_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.Service
{
    public class CityService : ICityRepository
    {
        private readonly Data_DBContext dBContext;

        public CityService(Data_DBContext _dBContext)
        {
            dBContext = _dBContext;
        }

        public async Task<City> AddCityAsync(City city)
        {
            await dBContext.Cities.AddAsync(city);
            await dBContext.SaveChangesAsync();
            return city;
        }

        public async Task<City?> DeleteCityByIdAsync(int id)
        {
            var cityDomain = await dBContext.Cities.FirstOrDefaultAsync(x => x.CityId == id);
            if (cityDomain == null)
            {
                return null;
            }
            dBContext.Cities.Remove(cityDomain);
            await dBContext.SaveChangesAsync();
            return cityDomain;
        }

        public async Task<City?> GetCityByIdAsync(int id)
        {
            return await dBContext.Cities.FirstOrDefaultAsync(x => x.CityId == id);
        }

        public async Task<List<City>> GetCityListAsync()
        {
            return await dBContext.Cities.ToListAsync();
        }

        public async Task<City?> UpdateCityAsync(int id, City city)
        {
            var cityDomain = await dBContext.Cities.FirstOrDefaultAsync(x => x.CityId == id);
            if(cityDomain == null)
            {
                return null;
            }
            cityDomain.CityId = city.CityId;
            cityDomain.CityName = city.CityName;
            cityDomain.StateId = city.StateId;

            await dBContext.SaveChangesAsync();
            return cityDomain;
        }
    }
}
