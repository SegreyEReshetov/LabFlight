using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class Airport
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public City City { get; set; }
        public int? CityId { get; set; }
        public virtual IEnumerable<Flight> FlightsDeparture { get; set; } = new List<Flight>();
        //public virtual IEnumerable<Flight> FlightsArrival { get; set; } = new List<Flight>();
    }
}
