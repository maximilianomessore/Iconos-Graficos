using System.ComponentModel.DataAnnotations;

namespace Iconos_Graficos.Models
{
    public class City
    {
        [Key]
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int numberResidents { get; set; }
        public int totalArea { get; set; }
        public List<GraphicIcon> GraphicIcons { get; set; }
    }
}

