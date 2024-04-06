﻿using HR_Management_API.DBContext;
using HR_Management_API.Models.Domain;
using HR_Management_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.Service
{
    public class Jobservice : IJobRepository
    {
        private readonly Data_DBContext dBContext;

        public Jobservice(Data_DBContext _dBContext)
        {
            dBContext = _dBContext;
        }

        public async Task<Job> AddJob(Job job)
        {
            await dBContext.Jobs.AddAsync(job);
            await dBContext.SaveChangesAsync();
            return job;
        }

        public async Task<List<Job>> GetAllJobs()
        {
            return await dBContext.Jobs.ToListAsync();
        }

        public async Task<Job?> GetJobById(int id)
        {
            return await dBContext.Jobs.FirstOrDefaultAsync(x => x.JobId == id);
        }
    }
}