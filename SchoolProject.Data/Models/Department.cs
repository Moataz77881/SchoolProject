using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Models
{
	public class Department
	{
		public Department()
		{
			Students = new HashSet<Student>();
			Subjects = new HashSet<Subject>();
		}
		[Key]
		public int DepId { get; set; }
		[StringLength(500)]
		public string DepName { get; set; }
		public ICollection<Student> Students { get; set; }
		public ICollection<Subject> Subjects { get; set; }
	}
}
