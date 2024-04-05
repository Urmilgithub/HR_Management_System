using HR_Management_API.DBContext;
using HR_Management_API.Models.Domain;
using HR_Management_API.Repository;

namespace HR_Management_API.Service
{
    public class Jobservice : IJobRepository
    {
        private readonly Data_DBContext dBContext;

        public Jobservice(Data_DBContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public async Task<List<Job>> GetAllJobs()
        {
            return await dBContext.Jobs.ToListAsync();
        }
    }
}
