using System.ComponentModel.DataAnnotations;

namespace Iconos_Graficos.Models
{
    public class Continent
    {
        [Key]
        public int continentID { get; set; }
        public string Name { get; set; }
        public List<City> cityIcons { get; set; }
    }
}
