using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
		public async Task<IActionResult> Get() 
		{
			return Ok(await _mediator.Send(new GetStudentListQuery()));
		}
		#endregion
	}
}
