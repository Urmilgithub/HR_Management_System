using AutoMapper;
using HR_Management_API.Models.Domain;
using HR_Management_API.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace HR_Management_API.Mapper
{
    public class MapperProfiles: Profile
    {
        public MapperProfiles()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<AddEmployeeDTO, Employee>().ReverseMap();
            CreateMap<UpdateEmployeeDTO, Employee>().ReverseMap();

            CreateMap<Job, JobDTO>().ReverseMap();
            CreateMap<AddJobDTO, Job>().ReverseMap();
            CreateMap<UpdateEmployeeDTO, Job>().ReverseMap();
        }   
    }
}
