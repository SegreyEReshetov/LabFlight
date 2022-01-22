using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interop
{
    public class RegionDto
    {
        public int Guid { get; set; }
        public string Name { get; set; }

        public virtual CountryDto Country { get; set; }
        public int? CountryId { get; set; }
      //  public virtual IEnumerable<CityDto> Cities { get; set; }
    }
}
