using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop
{
    public class PlaneSeatDto
    {
        public int Id { get; set; }
        public PlaneDto Plane { get; set; }
        public int? PlaneId { get; set; }
        public SeatDto Seat { get; set; }
        public int? SeatId { get; set; }
    }
}
