using HR_Management_API.Models.Domain;

namespace HR_Management_API.Repository
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobs();
        Task<Job?> GetJobById(int id);
        Task<Job> AddJob(Job job);
    }
}
