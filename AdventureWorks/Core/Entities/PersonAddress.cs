using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class PersonAddress
    {
        public virtual int AddressId { get; set; }
        public virtual string Line1 { get; set; }
        public virtual string Line2 { get; set; }
        public virtual string City { get; set; }
        //public virtual int ProvinceId { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual Guid RowGuid{ get; set; }
        public virtual DateTime ModifeDateTime { get; set; }
    }
}
