using HR_Management_API.Models.Domain;

namespace HR_Management_API.Repository
{
    public interface ICityRepository
    {
        Task<List<City>> GetCityListAsync();
        Task<City?> GetCityByIdAsync(int id);
        Task<City> AddCityAsync(City city);
        Task<City?> UpdateCityAsync(int id, City city);
    }
}
