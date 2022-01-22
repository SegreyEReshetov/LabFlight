using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class PlaneSeat
    {
        public int Id { get; set; }
        public Plane Plane { get; set; }
        public int? PlaneId { get; set; }
        public Seat Seat { get; set; }
        public int? SeatId  { get; set; }
    }
}
