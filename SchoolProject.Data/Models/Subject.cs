using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Models
{
	public class Subject
	{
		public Subject()
		{
			Students = new HashSet<Student>();
			Departments = new HashSet<Department>();
		}
		[Key]
		public int SubId { get; set; }
		[StringLength(500)]
		public string SubName { get; set; }
		public DateTime Priod { get; set; }
		public ICollection<Student> Students { get; set; }
		public ICollection<Department> Departments { get; set; }
	}
}
