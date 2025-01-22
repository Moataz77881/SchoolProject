namespace SchoolProject.Core.Response
{
	public class ResponseHandler
	{
		public ResponseHandler()
		{
			
		}
		public Response<T> Success<T>(T entity, object Meta = null) 
		{
			return new Response<T> 
			{
				Data = entity,
				Status = System.Net.HttpStatusCode.OK,
				Succeeded = true,
				Message = "Added Successfully",
				Meta = Meta
			};
		}
		public Response<T> Deleted<T>() 
		{
			return new Response<T>
			{
				Status = System.Net.HttpStatusCode.OK,
				Succeeded = true,
				Message = "Deleted Successfully",
			};
		}
		public Response<T> UnAuthorized<T>(string message = null)
		{
			return new Response<T>
			{
				Status = System.Net.HttpStatusCode.Unauthorized,
				Succeeded = false,
				Message = message == null ? "Bad Request" : message,
			};
		}
		public Response<T> NotFound<T>(string message = null)
		{
			return new Response<T>
			{
				Status = System.Net.HttpStatusCode.NotFound,
				Succeeded = false,
				Message = message == null ? "Not Found" : message,
			};
		}
		public Response<T> Created<T>(T entity, object meta = null)
		{
			return new Response<T>
			{
				Data = entity,
				Status = System.Net.HttpStatusCode.Created,
				Succeeded = true,
				Message = "Created successfully",
				Meta = meta
			};
		}
	}
}
