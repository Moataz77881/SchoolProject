using SchoolProject.Data.Models;
using SchoolProject.Infrustructure.Repositories;
using SchoolProject.Service.StudentServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
