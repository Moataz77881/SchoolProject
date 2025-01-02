using Microsoft.EntityFrameworkCore;
using SchoolProject.Core.StudentCQRS.Queries;
using SchoolProject.Infrustructure.DbContect;
using SchoolProject.Infrustructure.Implementation;
using SchoolProject.Infrustructure.Repositories;
using SchoolProject.Service.StudentServices.Implementation;
using SchoolProject.Service.StudentServices.Interfaces;
using System.Reflection;

namespace SchoolProject.Configurations
{
	public static class Config
	{
		public static WebApplicationBuilder AddConfigServices(this WebApplicationBuilder builder) 
		{
			#region dbcontext configuration
			builder.Services.AddDbContext<ApplicationDbContext>(options => 
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString"));
			});
			#endregion

			#region Dependency injection
			builder.Services.AddScoped<IStudentRepository, StudentRepository>();
			builder.Services.AddScoped<IStudentService, StudentService>();
			#endregion

			#region Mediator Configuration
			builder.Services.AddMediatR(r => r.RegisterServicesFromAssemblies(typeof(GetStudentListQuery).Assembly));
			#endregion

			return builder;
		}
	}
}
