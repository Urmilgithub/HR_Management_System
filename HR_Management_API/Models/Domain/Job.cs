using System.ComponentModel.DataAnnotations;

namespace HR_Management_API.Models.Domain
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
    }
}
