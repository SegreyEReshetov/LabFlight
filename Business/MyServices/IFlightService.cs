using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interop;
namespace Business.MyService
{
    public interface IFlightService
    {
        public IEnumerable<FlightDto> GetAll();
        public FlightDto Create(FlightDto Flight);
        public FlightDto CreateOrUpdate(FlightDto Flight);
        public FlightDto GetById(int id);
        public FlightDto Update(FlightDto Flight);
        public void Delete(int id);
    }
}
