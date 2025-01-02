using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Models;
using SchoolProject.Infrustructure.DbContect;
using SchoolProject.Infrustructure.Repositories;

namespace SchoolProject.Infrustructure.Implementation
{
	public class StudentRepository : IStudentRepository
	{
		#region Fields
		private readonly ApplicationDbContext _context;
		#endregion

		#region constructor
		public StudentRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		#endregion

		#region GetStudentListAsync method
		public async Task<List<Student>> GetStudentListAsync()
		{
			return await _context.Students.Include(x=>x.Department).Include(y=>y.Subjects).ToListAsync();
		}
		#endregion

		#region setStudentDepartmentSubject
		public async Task setStudentDepartmentSubject(Student student)
		{
			await _context.Students.AddRangeAsync(student);
		}
		#endregion
	}
}
