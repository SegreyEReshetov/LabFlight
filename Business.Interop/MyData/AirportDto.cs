using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop
{
    public class AirportDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }

        public virtual IEnumerable<FlightDto> Flights { get; set; }

        public virtual CityDto City { get; set; }
        public int? CityId { get; set; }
    }
}
