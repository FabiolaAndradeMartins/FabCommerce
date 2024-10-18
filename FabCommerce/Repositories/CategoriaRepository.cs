using FabCommerce.Context;
using FabCommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace FabCommerce.Repositories
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly AppDbContext dbContext;

		public CategoriaRepository(AppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<IEnumerable<Categoria>> GetCategorias()
		{
			return await dbContext.Categorias.ToListAsync();
		}
	}
}
