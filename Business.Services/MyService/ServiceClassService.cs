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
    public class ServiceClassService : IServiceClassService
    {
        private readonly IServiceClassRepository _serviceClassRepository;
        private readonly IMapper _mapper;
        public ServiceClassService(IServiceClassRepository serviceClassRepository, IMapper mapper)
        {
            _serviceClassRepository = serviceClassRepository;
            _mapper = mapper;
        }

        public IEnumerable<ServiceClassDto> GetAll()
        {
            var serviceClasses = _serviceClassRepository.Query();
            return _mapper.Map<IEnumerable<ServiceClass>, IEnumerable<ServiceClassDto>>(serviceClasses);
        }
    }
}
