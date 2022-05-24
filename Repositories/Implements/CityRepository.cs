using Iconos_Graficos.Models;

namespace Iconos_Graficos.Repositories.Implements
{
    public class CityRepository : GenericRepository<City>, ICity
    {
        public CityRepository(DataContext DataContext) : base(DataContext)
        {
        }
    }
}
