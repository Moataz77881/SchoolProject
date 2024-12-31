using MediatR;
using SchoolProject.Data.DTOs;
using SchoolProject.Data.Models;

namespace SchoolProject.Core.StudentCQRS.Queries
{
	public class GetStudentListQuery : IRequest<List<StudentDto>>
	{
	}
}
