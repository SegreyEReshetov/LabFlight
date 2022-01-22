using AutoMapper;
using Business.MyEnties;
using Business.MyRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interop;

namespace Business.MyService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public PersonDto CreateOrUpdate(PersonDto Person)
        {
            var entity = _mapper.Map<Person>(Person);
            _personRepository.CreateOrUpdate(entity);
            return _mapper.Map<PersonDto>(entity);
        }
        public PersonDto Create(PersonDto Person)
        {
            var entity = _mapper.Map<Person>(Person);
            _personRepository.Create(entity);
            return _mapper.Map<PersonDto>(entity);
        }
        public IEnumerable<PersonDto> GetAll()
        {
            var Persons = _personRepository.Query();
            return _mapper.Map<IEnumerable<Person>, IEnumerable<PersonDto>>(Persons);
        }

        public PersonDto GetById(int id)
        {
            var entity = _personRepository.Read(id);
            return _mapper.Map<PersonDto>(entity);
        }

        public PersonDto Update(PersonDto Person)
        {
            var entity = _mapper.Map<Person>(Person);
            _personRepository.Update(entity);
            return _mapper.Map<PersonDto>(entity);
        }

        public void Delete(int id)
        {
            var entity = _personRepository.Read(id);
            _personRepository.Delete(entity);
        }
    }
}
