using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interop;
namespace Business.MyService
{
    public interface IPersonService
    {
        public IEnumerable<PersonDto> GetAll();
        public PersonDto Create(PersonDto Person);
        public PersonDto CreateOrUpdate(PersonDto Person);
        public PersonDto GetById(int id);
        public PersonDto Update(PersonDto Person);
        public void Delete(int id);
    }
}
