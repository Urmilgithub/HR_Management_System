using HR_Management_API.DBContext;
using HR_Management_API.Mapper;
using HR_Management_API.Models.Domain;
using HR_Management_API.Models.DTO;
using HR_Management_API.Repository;
using HR_Management_API.Service;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Data_DBContext>(options
    => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployeeRepository, EmployeeService>();
builder.Services.AddScoped<IJobRepository, Jobservice>();
builder.Services.AddScoped<IStateRepository, StateService>();
builder.Services.AddScoped<ICityRepository, CityService>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentService>();


builder.Services.AddAutoMapper(typeof(MapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
