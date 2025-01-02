
using SchoolProject.Data.DTOs;
using SchoolProject.Data.Models;

namespace SchoolProject.Infrustructure.Repositories
{
	public interface IStudentRepository
	{
		public Task<List<Student>> GetStudentListAsync();
		public Task setStudentDepartmentSubject(Student student);
	}
}
