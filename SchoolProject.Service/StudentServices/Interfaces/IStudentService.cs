using SchoolProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.StudentServices.Interfaces
{
	public interface IStudentService
	{
		public Task<List<Student>> GetStudentListAsync();
		public Task SetStudentDepartmentSubject(Student student);
	}
}
