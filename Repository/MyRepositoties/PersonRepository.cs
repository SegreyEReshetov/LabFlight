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
    public class PersonRepository : AbstractRepository<Person, int>, IPersonRepository
    {
        public PersonRepository(Context context)
        {
            _context = context;
        }

        #region implementation
        protected override int KeySelector(Person entity) => entity.Id;
        protected override Person ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Person> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Person value)
        {
            _context.People.Add(value);
        }
        protected override async Task CreateImplementationAsync(Person value)
        {
            await _context.People.AddAsync(value);
        }
        protected override void UpdateImplementation(Person entity, Person value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Person value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.People.Remove(entity);
        }

        protected override IQueryable<Person> QueryImplementation()
        {
            return _context.People
                .Include(people => people.Tickets)
                    .ThenInclude(tickets => tickets.Seat)
                        .ThenInclude(seats => seats.Plane)
                .Include(people => people.Tickets)
                    .ThenInclude(tickets => tickets.Seat)
                        .ThenInclude(seats => seats.Service)
                .Include(people => people.Tickets)
                    .ThenInclude(tickets => tickets.Flight)
                        .ThenInclude(flight => flight.FlightStatus)
                .Include(people => people.Tickets)
                    .ThenInclude(tickets => tickets.Flight)
                      //  .ThenInclude(flight => flight.ArrivalAirport)
//.ThenInclude(arrivalAirport => arrivalAirport.City)
                .Include(people => people.Tickets)
                    .ThenInclude(tickets => tickets.Flight)
                        .ThenInclude(flight => flight.DepartureAirport)
                            .ThenInclude(departureAirport => departureAirport.City);


        }
        #endregion
    }
}