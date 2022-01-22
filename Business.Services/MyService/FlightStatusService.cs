using AutoMapper;
using Business.MyEnties;
using Business.Interop;
using Business.MyRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public class FlightStatusService : IFlightStatusService
    {
        private readonly IFlightStatusRepository _flightStatusRepository;
        private readonly IMapper _mapper;
        public FlightStatusService(IFlightStatusRepository flightStatusRepository, IMapper mapper)
        {
            _flightStatusRepository = flightStatusRepository;
            _mapper = mapper;
        }

        public IEnumerable<FlightStatusDto> GetAll()
        {
            var flightStatuses = _flightStatusRepository.Query();
            return _mapper.Map<IEnumerable<FlightStatus>, IEnumerable<FlightStatusDto>>(flightStatuses);
        }
    }
}

