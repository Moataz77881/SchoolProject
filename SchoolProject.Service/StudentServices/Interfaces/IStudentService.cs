using SchoolProject.Data.Models;

namespace SchoolProject.Service.StudentServices.Interfaces
{
	public interface IStudentService
	{
		public Task<List<Student>> GetStudentListAsync();
		public Task SetStudentDepartmentSubject(Student student);
		public Student GetStudentById(int id);
	}
}
