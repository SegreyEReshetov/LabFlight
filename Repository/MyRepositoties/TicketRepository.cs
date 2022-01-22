using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.MyEnties;
using Business.MyRepositories;
using Microsoft.EntityFrameworkCore;
using Repository.MyData;

namespace Repository.MyRepositories
{
    public class TicketRepository : AbstractRepository<Ticket, int>, ITicketRepository
    {
        public TicketRepository(Context context)
        {
            _context = context;
        }

        #region implementation
        protected override int KeySelector(Ticket entity) => entity.Id;
        protected override Ticket ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Ticket> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Ticket value)
        {
            _context.Tickets.Add(value);
        }
        protected override async Task CreateImplementationAsync(Ticket value)
        {
            await _context.Tickets.AddAsync(value);
        }
        protected override void UpdateImplementation(Ticket entity, Ticket value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Ticket value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Tickets.Remove(entity);
        }

        protected override IQueryable<Ticket> QueryImplementation()
        {
            return _context.Tickets
                 .Include(tickets => tickets.Person)
                 .Include(tickets => tickets.Seat)
                    .ThenInclude(seats => seats.Plane)
                //.Include(tikets => tikets.Flight)
                   //  .ThenInclude(flights => flights.ArrivalAirport)
                       // .ThenInclude(arrivalAirport => arrivalAirport.City)
                 .Include(tikets => tikets.Flight)
                     .ThenInclude(flights => flights.DepartureAirport)
                        .ThenInclude(departureAirport => departureAirport.City);

        }
        #endregion
    }
}
