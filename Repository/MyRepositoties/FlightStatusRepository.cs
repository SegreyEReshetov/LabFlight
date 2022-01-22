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
   public class FlightStatusRepository : AbstractRepository<FlightStatus, int>, IFlightStatusRepository
   {
        public FlightStatusRepository(Context context)
        {
            _context = context;
        }
        #region implementation
        protected override int KeySelector(FlightStatus entity) => entity.Id;
        protected override FlightStatus ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<FlightStatus> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(FlightStatus value)
        {
            _context.FlightStatuses.Add(value);
        }
        protected override async Task CreateImplementationAsync(FlightStatus value)
        {
            await _context.FlightStatuses.AddAsync(value);
        }
        protected override void UpdateImplementation(FlightStatus entity, FlightStatus value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(FlightStatus value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.FlightStatuses.Remove(entity);
        }

        protected override IQueryable<FlightStatus> QueryImplementation()
        {
            return _context.FlightStatuses
                .Include(flightStatuses => flightStatuses.Flights);
        }
        #endregion
    }

}
