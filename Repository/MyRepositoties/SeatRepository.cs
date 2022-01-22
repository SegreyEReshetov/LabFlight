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
    public class SeatRepository : AbstractRepository<Seat, int>, ISeatRepository
    {
        public SeatRepository(Context context)
        {
            _context = context;
        }
        #region implementation
        protected override int KeySelector(Seat entity) => entity.Id;
        protected override Seat ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Seat> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Seat value)
        {
            _context.Seats.Add(value);
        }
        protected override async Task CreateImplementationAsync(Seat value)
        {
            await _context.Seats.AddAsync(value);
        }
        protected override void UpdateImplementation(Seat entity, Seat value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Seat value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Seats.Remove(entity);
        }
        protected override IQueryable<Seat> QueryImplementation()
        {
            return _context.Seats
                 .Include(seats => seats.Plane)
                 .Include(seats => seats.Service)
                 .Include(seats => seats.Tickets)
                        .ThenInclude(tickets => tickets.Person)
                 .Include(seats => seats.Tickets)
                    .ThenInclude(tickets => tickets.Flight);
        }
        #endregion
    }
}
