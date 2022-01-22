using AutoMapper;
using Business.Interop;
using Business.MyEnties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            CreateMap<Airport, AirportDto>();
            CreateMap<City, CityDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Flight, FlightDto>();
            CreateMap<FlightStatus, FlightStatusDto>();
            CreateMap<Person, PersonDto>();
            CreateMap<Plane, PlaneDto>();
            CreateMap<Region, RegionDto>();
            CreateMap<Seat, SeatDto>();
            CreateMap<ServiceClass, ServiceClassDto>();
            CreateMap<Ticket, TicketDto>();
            CreateMap<PlaneSeat, PlaneSeatDto>();

            CreateMap<AirportDto, Airport>();
            CreateMap<CityDto, City>();
            CreateMap<CountryDto, Country>();
            CreateMap<FlightDto, Flight>();
            CreateMap<FlightStatusDto, FlightStatus>();
            CreateMap<PersonDto, Person>();
            CreateMap<PlaneDto, Plane>();
            CreateMap<RegionDto, Region>();
            CreateMap<SeatDto, Seat>();
            CreateMap<ServiceClassDto, ServiceClass>();
            CreateMap<TicketDto, Ticket>();
            CreateMap<PlaneSeatDto, PlaneSeat>();
        }
    }
}
