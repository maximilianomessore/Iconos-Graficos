using Microsoft.EntityFrameworkCore;

namespace Iconos_Graficos.Repositories
{
       
		public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
		{
			private readonly DataContext _DataContext;

			public GenericRepository(DataContext _DataContext)
			{
				this._DataContext = _DataContext;
			}

			// DELETE
			public async Task Delete(int id)
			{
				try
				{
					var entity = await GetById(id);

					if (entity == null)
					{
						throw new Exception("The entity is null");
					}
					else
					{
						_DataContext.Set<TEntity>().Remove(entity);
						await _DataContext.SaveChangesAsync();
					}
				}
				catch (System.Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}

			// GET ALL 
			public async Task<List<TEntity>> GetAll()
			{
				try
				{
					return await _DataContext.Set<TEntity>().ToListAsync();
				}
				catch (System.Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}

			// GET BY ID 
			public async Task<TEntity> GetById(int id)
			{
				try
				{
					return await _DataContext.Set<TEntity>().FindAsync(id);
				}
				catch (System.Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}

			// INSERT
			public async Task<TEntity> Insert(TEntity entity)
			{
				if (entity == null)
				{
					throw new ArgumentNullException(nameof(entity));
				}

				try
				{
					await _DataContext.Set<TEntity>().AddAsync(entity);
					await _DataContext.SaveChangesAsync();
					return entity;
				}
				catch (System.Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}

			// UPDATE
			public async Task<TEntity> Update(TEntity entity)
			{
				if (entity == null)
				{
					throw new ArgumentNullException(nameof(entity));
				}

				try
				{
					_DataContext.Set<TEntity>().Update(entity);
					await _DataContext.SaveChangesAsync();
					return entity;
				}
				catch (System.Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}
	
}
