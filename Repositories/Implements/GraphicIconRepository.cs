using Iconos_Graficos.Models;

namespace Iconos_Graficos.Repositories.Implements
{
    public class GraphicIconRepository : GenericRepository<GraphicIcon>, IGraphicIcon  
    {
        public GraphicIconRepository(DataContext DataContext) : base(DataContext)
        {
        }
    }
}
