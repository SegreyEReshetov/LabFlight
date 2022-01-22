using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class Seat
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public Plane Plane { get; set; }
        public int? PlaneId { get; set; }
        public  virtual IEnumerable<Ticket> Tickets { get; set; } = new List<Ticket>();
        public  ServiceClass Service { get; set; }
        public int? ServiceId { get; set; }
    }
}
