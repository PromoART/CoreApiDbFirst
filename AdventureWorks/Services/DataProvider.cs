using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Core;
using Core.Entities;
using NHibernate.Linq;
using NHibernate.SqlCommand;

namespace Services
{
    public class DataProvider:IDataProvider
    {
        public void CheckConnection()
        {
            var session = SessionFactory.OpenSession();
            session.Close();
        }

        public IEnumerable<PersonAddress> GetPersonAdreses()
        {
            var session = SessionFactory.OpenSession();

            try
            {
                //StateProvince province = null;
                //PersonAddress personAddress = null;

                //var addreses = session.QueryOver<PersonAddress>(() => personAddress)
                //    .JoinAlias(() => personAddress.StateProvince, () => province)
                //    .Where(() => personAddress.StateProvince.ProvinceId == province.ProvinceId).List();

                var addreses = session.Query<PersonAddress>().ToList();

                return addreses;
            }
            finally
            {
                session.Close();
            }
           
        }

        public IEnumerable<StateProvince> GetStateProvinces()
        {
            var session = SessionFactory.OpenSession();

            try
            {
                var personAdressQuery = session.Query<StateProvince>().ToList();
                return personAdressQuery;
            }
            finally
            {
                session.Close();
            }
        }
    }
}
