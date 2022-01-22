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
    public class PlaneService : IPlaneService
    {

        private readonly IPlaneRepository _planeRepository;
        private readonly IMapper _mapper;
        public PlaneService(IPlaneRepository planeRepository, IMapper mapper)
        {
            _planeRepository = planeRepository;
            _mapper = mapper;
        }

        public PlaneDto CreateOrUpdate(PlaneDto Plane)
        {
            var entity = _mapper.Map<Plane>(Plane);
            _planeRepository.CreateOrUpdate(entity);
            return _mapper.Map<PlaneDto>(entity);
        }
        public PlaneDto Create(PlaneDto Plane)
        {
            var entity = _mapper.Map<Plane>(Plane);
            _planeRepository.Create(entity);
            return _mapper.Map<PlaneDto>(entity);
        }
        public IEnumerable<PlaneDto> GetAll()
        {
            var planes = _planeRepository.Query();
            return _mapper.Map<IEnumerable<Plane>, IEnumerable<PlaneDto>>(planes);
        }

        public PlaneDto GetById(int id)
        {
            var entity = _planeRepository.Read(id);
            return _mapper.Map<PlaneDto>(entity);
        }

        public PlaneDto Update(PlaneDto Plane)
        {
            var entity = _mapper.Map<Plane>(Plane);
            _planeRepository.Update(entity);
            return _mapper.Map<PlaneDto>(entity);
        }

        public void Delete(int id)
        {
            var entity = _planeRepository.Read(id);
            _planeRepository.Delete(entity);
        }
    }
}
