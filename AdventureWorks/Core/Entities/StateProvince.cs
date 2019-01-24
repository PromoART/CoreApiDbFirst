using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class StateProvince
    {
        public virtual int ProvinceId { get; set; }

        public virtual string Code { get; set; }

        public virtual string RegionCode { get; set; }

        public virtual bool IsOnlyStateProvince { get; set; }

        public virtual IEnumerable<PersonAddress> Addresses { get; set; }

        public virtual string Name { get; set; }

        //public virtual int SalesTerritoryId { get; set; }

        public virtual Guid RowGuid { get; set; }

        public virtual DateTime ModifeDateTime { get; set; }
    }
}
