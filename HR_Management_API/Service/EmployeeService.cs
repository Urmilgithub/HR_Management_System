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

        public async Task<Employee> AddEmployee(Employee employee)
        {
            await dBContext.AddAsync(employee);
            await dBContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> DeleteEmployeeById(int id)
        {
            var employeeDomain = await dBContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if(employeeDomain == null)
            {
                return null;
            }

            dBContext.Employees.Remove(employeeDomain);
            await dBContext.SaveChangesAsync();
            return employeeDomain;
               
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await dBContext.Employees.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await dBContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        public async Task<Employee?> UpdateEmployeeById(int id, Employee employee)
        {
            var employeeDomain = await dBContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if(employeeDomain == null)
            {
                return null;
            }

            employeeDomain.EmployeeId = employee.EmployeeId;
            employeeDomain.FirstName = employee.FirstName;
            employeeDomain.LastName = employeeDomain.LastName;
            employeeDomain.Email = employee.Email;
            employeeDomain.Contact = employee.Contact;
            employeeDomain.HireDate = employee.HireDate;
            employeeDomain.Salary = employee.Salary;

            await dBContext.SaveChangesAsync();
            return employeeDomain;
        }
    }
}
