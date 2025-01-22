using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Models;
using SchoolProject.Infrustructure.Repositories;
using SchoolProject.Service.StudentServices.Interfaces;

namespace SchoolProject.Service.StudentServices.Implementation
{
	public class StudentService : IStudentService
	{
		#region fields
		private readonly IStudentRepository _studentRepository;
		private readonly IGenericRepo<Student> genericRepo;
		#endregion

		#region Constructor
		public StudentService(IStudentRepository studentRepository, IGenericRepo<Student> genericRepo)
		{
			this._studentRepository = studentRepository;
			this.genericRepo = genericRepo;
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
		public Student GetStudentById(int id)
		{
			return genericRepo.GetTableNoTracking()
				.Include(x=>x.Department)
				.Where(x=>x.StudentId.Equals(id))
				.FirstOrDefault();
		}
	}
}
