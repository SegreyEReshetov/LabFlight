using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class FlightStatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<FlightDto> Flights { get; set; }
    }
}
