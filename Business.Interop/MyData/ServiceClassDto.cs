using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class ServiceClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public virtual IEnumerable<SeatDto> Seats { get; set; }
    }
}
