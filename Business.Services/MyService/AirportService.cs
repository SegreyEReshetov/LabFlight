using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.MyService;
using Business.MyEnties;
using Business.MyRepositories;
using Business.Interop;

namespace Business.MyService
{
    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _airportRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IFlightRepository _flightRepository;
        
        private readonly IMapper _mapper;
        public AirportService(IAirportRepository AirportRepository, IMapper mapper, IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
            _airportRepository = AirportRepository;
            _mapper = mapper;
        }

        public AirportDto CreateOrUpdate(AirportDto Airport)
        {
            var entity = _mapper.Map<Airport>(Airport);
            _airportRepository.CreateOrUpdate(entity);
            return _mapper.Map<AirportDto>(entity);
        }
        public AirportDto Create(AirportDto Airport)
        {
            var entity = _mapper.Map<Airport>(Airport);
            _airportRepository.Create(entity);
            return _mapper.Map<AirportDto>(entity);
        }
        public IEnumerable<AirportDto> GetAll()
        {
            var Airports = _airportRepository.Query();
            return _mapper.Map<IEnumerable<Airport>, IEnumerable<AirportDto>>(Airports);
        }

        public AirportDto GetById(int id)
        {
            var entity = _airportRepository.Read(id);

            return _mapper.Map<AirportDto>(entity);
        }

        public AirportDto Update(AirportDto Airport)
        {
            var entity = _mapper.Map<Airport>(Airport);
            _airportRepository.Update(entity);
            return _mapper.Map<AirportDto>(entity);
        }

        public void Delete(int id)
        {
            var entity = _airportRepository.Read(id);
            _airportRepository.Delete(entity);
        }
    }
}
