using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class FlightStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Flight> Flights { get; set; } = new List<Flight>(); 
    }
}
