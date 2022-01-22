using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public  Airport DepartureAirport { get; set; }
        public int? DepartureAirportId { get; set; }


       // public  Airport ArrivalAirport { get; set; }
        //public int? ArrivalAirportId { get; set; }

        public  FlightStatus FlightStatus { get; set; }
        public int? FlightStatusId { get; set; }

        public virtual IEnumerable<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
