using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interop;
namespace Business.MyService
{
    public interface IFlightStatusService
    {
        public IEnumerable<FlightStatusDto> GetAll();
    }
}
