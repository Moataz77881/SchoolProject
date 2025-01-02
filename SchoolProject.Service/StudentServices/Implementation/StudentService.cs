using SchoolProject.Data.Models;
using SchoolProject.Infrustructure.Repositories;
using SchoolProject.Service.StudentServices.Interfaces;

namespace SchoolProject.Service.StudentServices.Implementation
{
	public class StudentService : IStudentService
	{
		#region fields
		private readonly IStudentRepository _studentRepository;
		#endregion

		#region Constructor
		public StudentService(IStudentRepository studentRepository)
		{
			this._studentRepository = studentRepository;
		}
		#endregion

		#region methods
		public Task<List<Student>> GetStudentListAsync()
		{
			return _studentRepository.GetStudentListAsync();
		}
		#endregion

		#region SetStudentDepartmentSubject
		public async Task SetStudentDepartmentSubject(Student student)
		{
			await _studentRepository.setStudentDepartmentSubject(student);
		}
		#endregion
	}
}
