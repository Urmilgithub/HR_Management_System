using HR_Management_API.DBContext;
using HR_Management_API.Models.Domain;
using HR_Management_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.Service
{
    public class DepartmentService : IDepartmentRepository
    {
        private readonly Data_DBContext dBContext;

        public DepartmentService(Data_DBContext _dBContext)
        {
            dBContext = _dBContext;
        }

        public async Task<List<Department>> GetDepartmentListAsync()
        {
            return await dBContext.Departments.ToListAsync();
        }
    }
}
