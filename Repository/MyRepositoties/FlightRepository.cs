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
    public class FlightRepository : AbstractRepository<Flight, int>, IFlightRepository
    {
        public FlightRepository(Context context)
        {
            _context = context;
        }
        #region implementation
        protected override int KeySelector(Flight entity) => entity.Id;
        protected override Flight ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Flight> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Flight value)
        {
            _context.Flights.Add(value);
        }
        protected override async Task CreateImplementationAsync(Flight value)
        {
            await _context.Flights.AddAsync(value);
        }
        protected override void UpdateImplementation(Flight entity, Flight value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Flight value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Flights.Remove(entity);
        }

        protected override IQueryable<Flight> QueryImplementation()
        {
            return _context.Flights
                .Include(flights => flights.FlightStatus)
               // .Include(flights => flights.ArrivalAirport)
                 //   .ThenInclude(arrivalAirport => arrivalAirport.City)
                 .Include(flights => flights.DepartureAirport)
                    .ThenInclude(departureAirport => departureAirport.City)
                .Include(flight => flight.Tickets)
                    .ThenInclude(tickets => tickets.Seat)
                         .ThenInclude(seat => seat.Service)
                .Include(flights => flights.Tickets)
                    .ThenInclude(tickets => tickets.Seat)
                         .ThenInclude(seat => seat.Plane);


        }
        #endregion
    }
}