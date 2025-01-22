using MediatR;
using SchoolProject.Core.Response;
using SchoolProject.Core.StudentCQRS.Handler;
using SchoolProject.Data.DTOs;

namespace SchoolProject.Core.StudentCQRS.Queries
{
	public class GetStudentByIdQuery : IRequest<Response<StudentDto>>
	{
		public GetStudentByIdQuery(int id)
		{
			Id = id;
		}
		public int Id { get; set; }
	}
}
