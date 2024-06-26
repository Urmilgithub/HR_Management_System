﻿using HR_Management_API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.DBContext
{
    public class Data_DBContext: DbContext
    {
        public Data_DBContext(DbContextOptions<Data_DBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
