using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interop;
namespace Business.MyService
{
    public interface ITicketService
    {
        public IEnumerable<TicketDto> GetAll();
        public TicketDto Create(TicketDto Ticket);
        public TicketDto CreateOrUpdate(TicketDto Ticket);
        public TicketDto Update(TicketDto Ticket);
        public TicketDto GetById(int id);
        public void Delete(int id);
    }
}
