using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class SeatDto
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public PlaneDto Plane { get; set; }
        public int? PlaneId { get; set; }
        public virtual IEnumerable<TicketDto> Tickets { get; set; }
        public virtual ServiceClassDto Service { get; set; }
        public int? ServiceId { get; set; }
    }
}
