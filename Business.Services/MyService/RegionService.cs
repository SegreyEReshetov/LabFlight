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
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;
        public RegionService(IRegionRepository regionRepository, IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }

        public IEnumerable<RegionDto> GetAll()
        {
            var regions = _regionRepository.Query();
            return _mapper.Map<IEnumerable<Region>, IEnumerable<RegionDto>>(regions);
        }
    }
}
