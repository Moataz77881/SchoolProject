using Microsoft.EntityFrameworkCore.Storage;

namespace SchoolProject.Infrustructure.Repositories
{
	public interface IGenericRepo<T> where T : class
	{	
		public Task<List<T>> GetAllAsync();
		public IQueryable<T> GetTableNoTracking();
		public Task<IQueryable<T>> GetTableAsTracking();
		public Task<T> GetByIdAsync(int id);
		public Task AddAsync(T entity);
		public Task AddRangeAsync(IList<T> entities);
		public Task<T> UpdateAsync(T entity);
		public Task<T> UpdateRangeAsync(IList<T> entities);
		public Task DeleteAsync(T entity);
		public Task DeleteRangeAsync(IList<T> entities);
		public IDbContextTransaction BeginTransaction();
		public void commit();
		public void RollBack();
	}
}
