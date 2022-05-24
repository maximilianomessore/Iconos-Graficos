using System.ComponentModel.DataAnnotations;

namespace Iconos_Graficos.Models
{
    public class GraphicIcon
    {

        [Key]
        public int iconID { get; set; }
        public string iconName { get; set; }
        public DateTime? date { get; set; }
        public int height { get; set; }
        public string history { get; set; }
        public City city { get; set; }
    }
}
