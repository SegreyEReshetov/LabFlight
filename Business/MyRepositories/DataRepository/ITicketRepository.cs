using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.MyEnties;
namespace Business.MyRepositories
{
    public interface ITicketRepository : IRepository<Ticket, int> { }
}
