using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class CountryRegion
    {
        public virtual string RegionCode{ get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifeDateTime { get; set; }

        public virtual IEnumerable<StateProvince> StateProvinces { get; set; }
    }
}
