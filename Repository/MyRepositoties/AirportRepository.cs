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
    public class AirportRepository : AbstractRepository<Airport, int>, IAirportRepository
    {
        public AirportRepository(Context context)
        {
            _context = context;
        }

        #region implementation
        protected override int KeySelector(Airport entity) => entity.Id;
        protected override Airport ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Airport> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Airport value)
        {
            _context.Airports.Add(value);
        }
        protected override async Task CreateImplementationAsync(Airport value)
        {
            await _context.Airports.AddAsync(value);
        }
        protected override void UpdateImplementation(Airport entity, Airport value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Airport value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Airports.Remove(entity);
        }
        protected override IQueryable<Airport> QueryImplementation()
        {
            return _context.Airports
                .Include(airport => airport.City)
                    .ThenInclude(city => city.Region)
                        .ThenInclude(region => region.Country)
                .Include(airport => airport.FlightsDeparture)
                    .ThenInclude(flightsDeparture => flightsDeparture.FlightStatus)
                .Include(airport => airport.FlightsDeparture)
                   .ThenInclude(flightsDeparture => flightsDeparture.Tickets)
                        .ThenInclude(tickets => tickets.Person)
                .Include(airport => airport.FlightsDeparture)
                    .ThenInclude(flightsDeparture => flightsDeparture.Tickets)
                        .ThenInclude(tickets => tickets.Seat)
                            .ThenInclude(seat => seat.Service)
                .Include(airport => airport.FlightsDeparture)
                    .ThenInclude(flightsDeparture => flightsDeparture.Tickets)
                        .ThenInclude(tickets => tickets.Seat)
                            .ThenInclude(seat => seat.Plane);

                //.Include(airport => airport.FlightsArrival)
                //    .ThenInclude(flightsArrival => flightsArrival.FlightStatus)
                //.Include(airport => airport.FlightsArrival)
                //    .ThenInclude(flightsArrival => flightsArrival.Tickets)
                //        .ThenInclude(tickets => tickets.Person)
                //.Include(airport => airport.FlightsArrival)
                //    .ThenInclude(flightsArrival => flightsArrival.Tickets)
                //        .ThenInclude(tickets => tickets.Seat)
                //            .ThenInclude(seat => seat.Service)
                //.Include(airport => airport.FlightsArrival)
                //    .ThenInclude(flightsArrival => flightsArrival.Tickets)
                //        .ThenInclude(tickets => tickets.Seat)
                //            .ThenInclude(seat => seat.Planes)
                //                .ThenInclude(planes => planes.Plane);
        }
        #endregion
    }
}
