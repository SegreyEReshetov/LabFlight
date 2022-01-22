using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class Plane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Range { get; set; }

        public virtual IEnumerable<PlaneSeat> Seats { get; set; } = new List<PlaneSeat>();

    }
}
