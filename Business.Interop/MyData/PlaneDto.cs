using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class PlaneDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Range { get; set; }

        public virtual IEnumerable<SeatDto> Seats { get; set; }
    }
}
