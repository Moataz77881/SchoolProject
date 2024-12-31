using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrustructure.DbContect;
using SchoolProject.Infrustructure.Implementation;
using SchoolProject.Infrustructure.Repositories;
using SchoolProject.Service.StudentServices.Implementation;
using SchoolProject.Service.StudentServices.Interfaces;

namespace SchoolProject.Configurations
{
	public class Config
	{
		public static WebApplicationBuilder AddConfigServices(WebApplicationBuilder builder) 
		{
			#region dbcontext configuration
			builder.Services.AddDbContext<ApplicationDbContext>(options => 
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString"));
			});
			#endregion

			builder.Services.AddScoped<IStudentRepository, StudentRepository>();
			builder.Services.AddScoped<IStudentService, StudentService>();


			return builder;
		}
	}
}
