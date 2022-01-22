using AutoMapper;
using Business.Interop;
using Business.MyService;
using Business.MyEnties;
using Business.MyRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IAirportRepository _airportRepository;
        private readonly IFlightStatusRepository _flightStatusRepository;
        private readonly IMapper _mapper;
        public FlightService(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public FlightDto CreateOrUpdate(FlightDto Flight)
        {
            var entity = _mapper.Map<Flight>(Flight);
            _flightRepository.CreateOrUpdate(entity);
            return _mapper.Map<FlightDto>(entity);
        }
        public FlightDto Create(FlightDto Flight)
        {
            var entity = _mapper.Map<Flight>(Flight);
            _flightRepository.Create(entity);
            return _mapper.Map<FlightDto>(entity);
        }
        public IEnumerable<FlightDto> GetAll()
        {
            var Flights = _flightRepository.Query();
            return _mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDto>>(Flights);
        }

        public FlightDto GetById(int id)
        {
            var entity = _flightRepository.Read(id);
            return _mapper.Map<FlightDto>(entity);
        }

        public FlightDto Update(FlightDto Flight)
        {
            var entity = _mapper.Map<Flight>(Flight);
            _flightRepository.Update(entity);
            return _mapper.Map<FlightDto>(entity);
        }

        public void Delete(int id)
        {
            var entity = _flightRepository.Read(id);
            _flightRepository.Delete(entity);
        }


    }
}
