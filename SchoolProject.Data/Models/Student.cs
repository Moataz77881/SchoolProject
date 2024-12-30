using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Models
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }
		[StringLength(500)]
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
