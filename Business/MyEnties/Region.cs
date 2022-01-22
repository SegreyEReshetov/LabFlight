using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyEnties
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public int? CountryId { get; set; }
     //   public virtual IEnumerable<City> Cities { get; set; } = new List<City>();
    }
}
