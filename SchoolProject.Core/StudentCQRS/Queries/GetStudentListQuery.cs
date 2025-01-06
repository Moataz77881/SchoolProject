using MediatR;
using SchoolProject.Core.ResponseOBJ;
using SchoolProject.Data.DTOs;
using SchoolProject.Data.Models;

namespace SchoolProject.Core.StudentCQRS.Queries
{
	public class GetStudentListQuery : IRequest<Response<List<StudentDto>>>
	{
	}
}
