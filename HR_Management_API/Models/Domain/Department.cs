using System.ComponentModel.DataAnnotations;

namespace HR_Management_API.Models.Domain
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int CityId { get; set; }
    }
}
