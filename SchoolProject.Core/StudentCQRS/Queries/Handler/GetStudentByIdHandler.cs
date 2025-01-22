using MediatR;
using SchoolProject.Core.Response;
using SchoolProject.Core.StudentCQRS.Queries;
using SchoolProject.Data.DTOs;
using SchoolProject.Service.StudentServices.Interfaces;

namespace SchoolProject.Core.StudentCQRS.Queries.Handler
{
	public class GetStudentByIdHandler : ResponseHandler, IRequestHandler<GetStudentByIdQuery, Response<StudentDto>>
	{
		private readonly IStudentService service;
		public GetStudentByIdHandler(IStudentService service)
		{
			this.service = service;
		}
		public async Task<Response<StudentDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
		{
			var model = service.GetStudentById(request.Id);
			var dto = new StudentDto
			{
				Name = model.Name,
				Address = model.Address,
				DepartmentDto = new DepartmentDto
				{
					DepId = model.Department.DepId,
					DepName = model.Department.DepName,
				},
				Phone = model.Phone,
			};
			return Success(dto);
		}
	}
}
