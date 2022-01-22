using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class ServiceClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public virtual IEnumerable<Seat> Seats { get; set; } = new List<Seat>();
    }
}
