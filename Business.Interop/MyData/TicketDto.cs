using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public virtual PersonDto Person { get; set; }
        public int? PersonId { get; set; }
        public virtual FlightDto Flight { get; set; }
        public int? FlightId { get; set; }
        public virtual SeatDto Seat { get; set; }
        public int? SeatId { get; set; }
    }
}
