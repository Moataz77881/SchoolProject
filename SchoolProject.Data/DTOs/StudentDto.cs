using SchoolProject.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.DTOs
{
	public class StudentDto
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public DepartmentDto DepartmentDto { get; set; }
		public List<StudentSubjectDto> studentSubjectDtos { get; set; }
	}
}
