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
    public class SeatService : ISeatService
    {
        private readonly ISeatRepository _seatRepository;
        private readonly IMapper _mapper;
        public SeatService(ISeatRepository seatRepository, IMapper mapper)
        {
            _seatRepository = seatRepository;
            _mapper = mapper;
        }

        public IEnumerable<SeatDto> GetAll()
        {
            var Seats = _seatRepository.Query();
            return _mapper.Map<IEnumerable<Seat>, IEnumerable<SeatDto>>(Seats);
        }
    }
}
