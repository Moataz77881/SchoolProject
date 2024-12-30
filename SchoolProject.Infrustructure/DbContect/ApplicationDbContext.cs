using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Models;

namespace SchoolProject.Infrustructure.DbContect
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Student> Students { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Department> Departments { get; set; }
	}
}
