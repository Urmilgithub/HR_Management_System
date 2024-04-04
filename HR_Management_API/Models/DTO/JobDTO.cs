namespace HR_Management_API.Models.DTO
{
    public class JobDTO
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
    }
}
