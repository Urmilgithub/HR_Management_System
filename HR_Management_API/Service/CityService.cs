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

        public async Task<List<City>> GetCityListAsync()
        {
            return await dBContext.Cities.ToListAsync();
        }
    }
}
