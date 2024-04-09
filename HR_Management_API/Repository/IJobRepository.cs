using HR_Management_API.Models.Domain;
using HR_Management_API.Models.DTO;

namespace HR_Management_API.Repository
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobs();
        Task<Job?> GetJobById(int id);
        Task<Job> AddJobs(Job job);
        Task<Job?> UpdateJob(int id, Job job);
    }
}
