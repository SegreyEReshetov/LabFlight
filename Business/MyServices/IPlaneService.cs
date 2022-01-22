using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interop;
namespace Business.MyService
{
    public interface IPlaneService
    {
        public IEnumerable<PlaneDto> GetAll();
        public PlaneDto Create(PlaneDto Plane);
        public PlaneDto CreateOrUpdate(PlaneDto Plane);
        public PlaneDto Update(PlaneDto Plane);
        public PlaneDto GetById(int id);
        public void Delete(int id);
    }
}
