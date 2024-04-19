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

        public async Task<Department> AddDepartmentAsync(Department department)
        {
            await dBContext.Departments.AddAsync(department);
            await dBContext.SaveChangesAsync();
            return department;
        }

        public async Task<Department?> GetDepartmentByIdAsync(int id)
        {
            return await dBContext.Departments.FirstOrDefaultAsync(x => x.DeptId == id);   
        }

        public async Task<List<Department>> GetDepartmentListAsync()
        {
            return await dBContext.Departments.ToListAsync();
        }

        public async Task<Department?> UpdateDepartmentByIdAsync(int id, Department department)
        {
            var deptDomain = await dBContext.Departments.FirstOrDefaultAsync(x => x.DeptId == id);
            if(deptDomain == null)
            {
                return null;
            }
            deptDomain.DeptId = department.DeptId;
            deptDomain.DeptName = department.DeptName;
            deptDomain.CityId = department.CityId;

            await dBContext.SaveChangesAsync();
            return department;                
        }
    }
}
