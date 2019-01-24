using System;

namespace Core.Entities
{
    public class SalesTerritory
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string RegCode { get; set; }

        public virtual string Group { get; set; }

        public virtual decimal SalesYtd { get; set; }

        public virtual decimal SalesLastYear { get; set; }

        public virtual decimal LostYtd { get; set; }

        public virtual decimal LostLastYear { get; set; }

        public virtual Guid RowGuid { get; set; }

        public virtual DateTime ModifeDateTime { get; set; }
    }
}
