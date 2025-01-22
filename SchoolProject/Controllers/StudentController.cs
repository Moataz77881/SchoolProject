using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.StudentCQRS.Queries;

namespace SchoolProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		#region fields
		private readonly IMediator _mediator;
		#endregion

		#region Constructor
		public StudentController(IMediator mediator)
		{
			_mediator = mediator;
		}
		#endregion

		#region EndPoint
		[HttpGet]
		public async Task<IActionResult> GetStudentList() 
		{
			return Ok(await _mediator.Send(new GetStudentListQuery()));
		}

		[Route("{id:int}")]
		[HttpGet]
		public async Task<IActionResult> GetStudentById([FromRoute] int id) 
		{
			return Ok(await _mediator.Send(new GetStudentByIdQuery(id)));
		}
		#endregion
	}
}
