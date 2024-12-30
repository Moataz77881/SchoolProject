
using SchoolProject.Data.Models;

namespace SchoolProject.Infrustructure.Repositories
{
	public interface IStudentRepository
	{
		public Task<List<Student>> GetStudentListAsync();
	}
}
