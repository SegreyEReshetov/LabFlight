using AutoMapper;
using Business.Interop;
using Business.MyEnties;
using Business.MyRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;
        public CountryService(ICountryRepository CountryRepository, IMapper mapper)
        {
            _countryRepository = CountryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CountryDto> GetAll()
        {
            var countries = _countryRepository.Query();
            return _mapper.Map<IEnumerable<Country>, IEnumerable<CountryDto>>(countries);
        }


    }
}
