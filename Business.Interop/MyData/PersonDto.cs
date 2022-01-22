using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string Passport { get; set; } 
        public DateTime Birthdate { get; set; }

        public virtual IEnumerable<TicketDto> Tickets { get; set; }
    }
}
