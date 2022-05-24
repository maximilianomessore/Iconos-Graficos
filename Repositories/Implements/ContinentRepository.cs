using Iconos_Graficos.Models;

namespace Iconos_Graficos.Repositories.Implements
{
    public class ContinentRepository : GenericRepository<Continent>, IContinent
    {
        public ContinentRepository(DataContext DataContext) : base(DataContext)
        {
        }
    }
}
