using MediatR;
using SchoolProject.Core.ResponseOBJ;
using SchoolProject.Core.StudentCQRS.Queries;
using SchoolProject.Data.DTOs;
using SchoolProject.Service.StudentServices.Interfaces;

namespace SchoolProject.Core.StudentCQRS.Handler
{
	public class StudentHandler : ResponseHandler, IRequestHandler<GetStudentListQuery,Response<List<StudentDto>>>
	{
		#region fields
		private readonly IStudentService _studentService;
		#endregion

		#region Constructor
		public StudentHandler(IStudentService studentService)
		{
			this._studentService = studentService;
		}
		#endregion

		#region Implement Handler
		public async Task<Response<List<StudentDto>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
		{
			List<StudentDto> studentDtos = new List<StudentDto>();
			List<StudentSubjectDto> studentSubjectDtos = new List<StudentSubjectDto>();
			var students = await _studentService.GetStudentListAsync();

			foreach (var student in students) 
			{
				studentDtos.Add(new StudentDto
				{
					Name = student.Name,
					Address = student.Address,
					Phone = student.Phone,
					DepartmentDto = new DepartmentDto()
					{
						DepName = student.Department.DepName
					},
					studentSubjectDtos = student.Subjects.Select(ss => new StudentSubjectDto
					{
						SubName = ss.SubName,
						Priod = ss.Priod
					}).ToList()
				});
			}
			return Success(studentDtos);
		}
		#endregion
	}
}
