using SchoolProject.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.DTOs
{
	public class StudentDto
	{
		public string Name { get; set; }
		[StringLength(500)]
		public string Address { get; set; }
		[StringLength(11)]
		public string Phone { get; set; }

		[ForeignKey("Department")]
		public int DepId { get; set; }
		public Department Department { get; set; }
		public ICollection<Subject> Subjects { get; set; }
	}
}
