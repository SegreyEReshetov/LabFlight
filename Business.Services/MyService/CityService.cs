using AutoMapper;
using Business.Interop;
using Business.MyEnties;
using Business.MyRepositories;
using Business.MyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public IEnumerable<CityDto> GetAll()
        {
            var cities = _cityRepository.Query();
            return _mapper.Map<IEnumerable<City>, IEnumerable<CityDto>>(cities);
        }
    }
}
