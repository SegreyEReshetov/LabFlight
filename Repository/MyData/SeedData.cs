using Business.MyEnties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MyData
{
    public class SeedData
    {
        private static readonly IEnumerable<Country> Countries = new List<Country>()
        {
            new Country()
            {
                Name = "Россия",

            },
        };
        public static readonly IEnumerable<Region> Regions = new List<Region>()
        {
            new Region()
            {
               Name = "Воронежская область",
               CountryId = 0,
               Country = Countries.ElementAt(0),
            },
            new Region()
            {
               Name = "Московская область",
               CountryId = 0,
               Country = Countries.ElementAt(0),
            },
        };
        private static readonly IEnumerable<City> Cities = new List<City>()
        {
           new City()
           {
               Name = "Воронеж",
               Region = Regions.ElementAt(0),
               RegionId = 0,
           },
           new City()
           {
               Name = "Москва",
               Region = Regions.ElementAt(1),
               RegionId = 1,
           },
           new City()
           {
              Name = "Калуга",
              Region = Regions.ElementAt(1),
              RegionId = 1,
           },
        };
        private static readonly IEnumerable<ServiceClass> ServiceClasses = new List<ServiceClass>()
        {
            new ServiceClass()
            {
                Name = "Бизнес",
                Cost = 10000,

            },
            new ServiceClass()
            {
                Name = "Эконом",
                Cost = 5000,
            },
            new ServiceClass()
            {
                Name = "Комфорт",
                Cost = 7500,
            },
        };
        private static readonly IEnumerable<FlightStatus> FlightStatuses = new List<FlightStatus>()
        {
            new FlightStatus()
            {
                Name = "Отменен",
            },
            new FlightStatus()
            {
                Name = "Ожидает вылета",
            },
            new FlightStatus()
            {
                Name = "Ожидает приземления",
            },
             new FlightStatus()
            {
                Name = "В полете",
            },
        };
        private static readonly IEnumerable<Plane> Planes = new List<Plane>()
        {
            new Plane()
            {
                Model = "Airbus F1A ",
                Range = 10000,
            },
            new Plane()
            {
                Model = "Boeing 7712",
                Range = 7000,
            },
        };
       private static readonly IEnumerable<Person> People = new List<Person>()
       {
           new Person()
            {
               Fio = "Иванов Иван Иванович",
                Birthdate = new DateTime(1989,11,12),
                Passport = "2004, 453212",

            },
           new Person()
           {
               Fio = "Петров Петр Петрович",
                Birthdate = new DateTime(2000,01,01),
                Passport = "2016 563212",

           },
           new Person()
           {
               Fio = "Решетов Сергей Владимирович",
               Birthdate = new DateTime(2002,01,29),
               Passport = "2015 939251",
           }
        };
        
        private static readonly IEnumerable<Airport> Airports = new List<Airport>()
        {
            new Airport()
            {
                Name = "Великий Петр",
                City = Cities.ElementAt(0),
                CityId = 0,
                Latitude = 111,
                Longitude = 121,
            },
            new Airport()
            {
                Name = "Демодедово",
                City = Cities.ElementAt(1),
                CityId = 1,
                Latitude = 511,
                Longitude = 421,
            },
             new Airport()
            {
                Name = "Шереметьево",
                City = Cities.ElementAt(1),
                CityId = 1,
                Latitude = 506,
                Longitude = 399,
            },
        };
        private static readonly IEnumerable<Seat> Seats = new List<Seat>()
        {
            new Seat()
            {
                Num = "1A",
                Service = ServiceClasses.ElementAt(0),
                ServiceId = 0,
                Plane = Planes.ElementAt(0),
                PlaneId = 0,

        
            },
            new Seat()
            {
                Num = "1B",
                Service = ServiceClasses.ElementAt(1),
                ServiceId = 1,
                Plane = Planes.ElementAt(0),
                PlaneId = 0,
            },
            new Seat()
            {
                Num = "1C",
                Service = ServiceClasses.ElementAt(2),
                ServiceId = 2,
                Plane = Planes.ElementAt(0),
                PlaneId = 0,
            },
            new Seat()
            {
                Num = "2A",
                Service = ServiceClasses.ElementAt(0),
                ServiceId = 0,
                Plane = Planes.ElementAt(1),
                PlaneId = 1,
            },
            new Seat()
            {
                Num = "2B",
                Service = ServiceClasses.ElementAt(1),
                ServiceId = 1,
                Plane = Planes.ElementAt(1),
                PlaneId = 1,
            },
            new Seat()
            {
                Num = "2C",
                Service = ServiceClasses.ElementAt(2),
                ServiceId = 2,
                 Plane = Planes.ElementAt(1),
                PlaneId = 1,
            },
        };
        private static readonly IEnumerable<Flight> Flights = new List<Flight>()
        {
            new Flight()
            {
                Arrival = new DateTime(2021,01,21),
                Departure = new DateTime(2021,01,22),
                DepartureAirport = Airports.ElementAt(0),
                DepartureAirportId = 0,
                FlightStatus = FlightStatuses.ElementAt(1),
                FlightStatusId = 1,
            },
            new Flight()
            {
                Arrival = new DateTime(2020,10,11),
                Departure = new DateTime(2021,10,12),
                DepartureAirport = Airports.ElementAt(1),
                DepartureAirportId = 1,
                FlightStatus = FlightStatuses.ElementAt(2),
                FlightStatusId = 2,
            },
            new Flight()
            {
                Arrival = new DateTime(2022,06,12),
                Departure = new DateTime(2021,06,13),
                DepartureAirport = Airports.ElementAt(2),
                DepartureAirportId = 2,
                FlightStatus = FlightStatuses.ElementAt(3),
                FlightStatusId = 3,
            }
        };
        private static readonly IEnumerable<Ticket> Tickets = new List<Ticket>()
        {
            new Ticket()
            {
                Person = People.ElementAt(0),
                PersonId = 0,
                Seat = Seats.ElementAt(0),
                SeatId = 0,
                Flight = Flights.ElementAt(0),
                FlightId = 0,
            },
            new Ticket()
            {
                Person = People.ElementAt(1),
                PersonId = 1,
                Seat = Seats.ElementAt(1),
                SeatId = 1,
                Flight = Flights.ElementAt(0),
                FlightId = 0,
            },
            new Ticket()
            {
                Person = People.ElementAt(2),
                PersonId = 2,
                Seat = Seats.ElementAt(3),
                SeatId = 3,
                Flight = Flights.ElementAt(1),
                FlightId = 1,
            },
        };
        public static void Initialize(Context context)
        {
            
            if (!context.Countries.Any())
            {
                context.Countries.AddRange(Countries);
                context.SaveChanges();
            }
            if (!context.Regions.Any())
            {
                context.Regions.AddRange(Regions);
                context.SaveChanges();
            }
            if (!context.Cities.Any())
            {
                context.Cities.AddRange(Cities);
                context.SaveChanges();
            }
            if(!context.Airports.Any())
            {
                context.Airports.AddRange(Airports);
                context.SaveChanges();
            }
            if (!context.ServiceClasses.Any())
            {
                context.ServiceClasses.AddRange(ServiceClasses);
                context.SaveChanges();
            }
            
            if (!context.Planes.Any())
            {
                context.Planes.AddRange(Planes);
                context.SaveChanges();
            }
            if (!context.FlightStatuses.Any())
            {
                context.FlightStatuses.AddRange(FlightStatuses);
                context.SaveChanges();
            }
            if(!context.People.Any())
            {
                context.People.AddRange(People);
                context.SaveChanges();
            }
            if(!context.Seats.Any())
            {
                context.Seats.AddRange(Seats);
                context.SaveChanges();
            }
            if(!context.Flights.Any())
            {
                context.Flights.AddRange(Flights);
                context.SaveChanges();
            }
            if(!context.Tickets.Any())
            {
                context.Tickets.AddRange(Tickets);
                context.SaveChanges();
            }
     
        }
        
    }
    
}
