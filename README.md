# HR_Management_System

HR Management System is a backend API built to manage daily task operation of an organization. It provides endpoints for user authentication, employee management, job roles, department, role authorization and image upload of employee

# Technologies Used ⚡
- .Net Core Framework
- C#
- ASP.NET Core Web API
- Entity Framework Core
- Automapper
- Microsoft SQL Server


## Architecture

This project follows a Repository Pattern with Dependency Injection for
clean separation of concerns. Each entity (Employee, Department, Job, City,
State) has its own repository interface and implementation, registered as
Scoped services in the DI container. JWT secrets and DB connection strings
are stored in appsettings.json (use Azure App Service Configuration or
environment variables in production)