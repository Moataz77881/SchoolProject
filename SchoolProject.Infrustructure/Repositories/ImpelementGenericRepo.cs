using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SchoolProject.Infrustructure.DbContect;

namespace SchoolProject.Infrustructure.Repositories
{
	public class ImpelementGenericRepo<T> : IGenericRepo<T> where T : class
	{
		#region fiels
		private readonly ApplicationDbContext context;
		#endregion
		#region construcor
		public ImpelementGenericRepo(ApplicationDbContext context)
		{
			this.context = context;
		}
		#endregion
		#region methods
		public async Task AddAsync(T entity)
		{
			await context.Set<T>().AddAsync(entity);
		}
		public async Task AddRangeAsync(IList<T> entities)
		{
			await context.Set<T>().AddRangeAsync(entities);
		}
		public IDbContextTransaction BeginTransaction()
		{
			throw new NotImplementedException();
		}

		public void commit()
		{
			throw new NotImplementedException();
		}

		public async Task DeleteAsync(T entity)
		{
			context.Set<T>().Remove(entity);
			await context.SaveChangesAsync();
		}

		public Task DeleteRangeAsync(IList<T> entities)
		{
			throw new NotImplementedException();
		}

		public Task<List<T>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await context.Set<T>().FindAsync(id);
		}

		public Task<IQueryable<T>> GetTableAsTracking()
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> GetTableNoTracking()
		{
			return context.Set<T>().AsNoTracking().AsQueryable();
		}

		public void RollBack()
		{
			throw new NotImplementedException();
		}

		public Task<T> UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> UpdateRangeAsync(IList<T> entities)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
