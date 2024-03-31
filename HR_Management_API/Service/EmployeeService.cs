using HR_Management_API.DBContext;
using HR_Management_API.Models.Domain;
using HR_Management_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.Service
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly Data_DBContext dBContext;

        public EmployeeService(Data_DBContext _dBContext)
        {
            dBContext = _dBContext;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await dBContext.Employees.ToListAsync();
        }
    }
}
