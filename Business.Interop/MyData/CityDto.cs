using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<AirportDto> Airports { get; set; }

        public virtual RegionDto Region { get; set; }
        public int? RegionId { get; set; } 
    }
}
