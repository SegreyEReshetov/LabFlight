using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class Ticket
    {
        public int Id { get; set; }

        public virtual Person Person { get; set; }
        public int? PersonId { get; set; }
        public virtual Flight Flight { get; set; }
        public int? FlightId { get; set; }
        public virtual Seat Seat { get; set; }
        public int? SeatId { get; set; }

    }
}
