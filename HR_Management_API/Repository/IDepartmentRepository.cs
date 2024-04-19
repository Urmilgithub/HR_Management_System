﻿using HR_Management_API.Models.Domain;

namespace HR_Management_API.Repository
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartmentListAsync();
        Task<Department?> GetDepartmentByIdAsync(int id);
        Task<Department> AddDepartmentAsync(Department department);
    }
}
