using HR_Management_API.Models.Domain;

namespace HR_Management_API.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetEmployeeById(int id);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee?> UpdateEmployeeById(int id, Employee employee);
        Task<Employee?> DeleteEmployeeById(int id);
    }
}
