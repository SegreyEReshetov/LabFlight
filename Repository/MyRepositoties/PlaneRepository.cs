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
    public class PlaneRepository : AbstractRepository<Plane, int>, IPlaneRepository
    {
        public PlaneRepository(Context context)
        {
            _context = context;
        }

        #region implementation
        protected override int KeySelector(Plane entity) => entity.Id;
        protected override Plane ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Plane> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Plane value)
        {
            _context.Planes.Add(value);
        }
        protected override async Task CreateImplementationAsync(Plane value)
        {
            await _context.Planes.AddAsync(value);
        }
        protected override void UpdateImplementation(Plane entity, Plane value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Plane value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Planes.Remove(entity);
        }

        protected override IQueryable<Plane> QueryImplementation()
        {
            return _context.Planes
                 .Include(planes => planes.Seats)
                    .ThenInclude(seats => seats.Seat)
                        .ThenInclude(seat => seat.Tickets)
                            .ThenInclude(tickets => tickets.Person)
                .Include(planes => planes.Seats)
                    .ThenInclude(seats => seats.Seat)
                        .ThenInclude(seats => seats.Tickets)
                            .ThenInclude(tickets => tickets.Flight)
                             //   .ThenInclude(flights => flights.ArrivalAirport)
                .Include(planes => planes.Seats)
                    .ThenInclude(seats => seats.Seat)
                        .ThenInclude(seats => seats.Tickets)
                            .ThenInclude(tickets => tickets.Flight)
                                .ThenInclude(flights => flights.DepartureAirport);

        }
        #endregion
    }
}
