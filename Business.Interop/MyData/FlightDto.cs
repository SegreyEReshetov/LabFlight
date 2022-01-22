using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class FlightDto
    {
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public virtual AirportDto DepartureAirport { get; set; }
        public int? DepartureAirportId { get; set; }

        public virtual FlightStatusDto FlightStatus { get; set; }
        public int? FlightStatusId { get; set; }

        public virtual IEnumerable<TicketDto> Tickets { get; set; }
    }
}
