using FabCommerce.Entities;

namespace FabCommerce.Repositories
{
	public interface ICategoriaRepository
	{
		Task<IEnumerable<Categoria>> GetCategorias();
	}
}
