using System.ComponentModel.DataAnnotations;

namespace HR_Management_API.Models.Domain
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
