﻿using MediatR;
using SchoolProject.Core.StudentCQRS.Queries;
using SchoolProject.Data.DTOs;
using SchoolProject.Service.StudentServices.Interfaces;

namespace SchoolProject.Core.StudentCQRS.Handler
{
	public class StudentHandler : IRequestHandler<GetStudentListQuery, List<StudentDto>>
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
		public async Task<List<StudentDto>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
		{
			List<StudentDto> studentDtos = new List<StudentDto>();

			var Students = await _studentService.GetStudentListAsync();

			foreach (var student in Students) 
			{
				studentDtos.Add(new StudentDto 
				{
					Name = student.Name,
					Address = student.Address,
					Phone = student.Phone,
					Department = student.Department,
					Subjects = student.Subjects,
				});
			}
			return studentDtos;
		}
		#endregion
	}
}