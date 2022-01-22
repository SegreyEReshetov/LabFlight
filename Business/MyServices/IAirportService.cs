using Business.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public interface IAirportService
    {
        public IEnumerable<AirportDto> GetAll();
        public AirportDto Create(AirportDto Airport);
        public AirportDto CreateOrUpdate(AirportDto Airport);
        public AirportDto GetById(int id);
        public AirportDto Update(AirportDto Airport);
        public void Delete(int id);
    }
}
