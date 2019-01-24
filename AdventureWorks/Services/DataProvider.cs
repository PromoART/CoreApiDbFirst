using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Entities;
using NHibernate.Linq;

namespace Services
{
    public class DataProvider : IDataProvider
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

        public IEnumerable<CountryRegion> GetCountryRegions()
        {
            var session = SessionFactory.OpenSession();

            try
            {
                var regions = session.Query<CountryRegion>().ToList();

                return regions;
            }
            finally
            {
                session.Close();
            }
        }

        public PersonAddress GetPersonAddress(int addressId)
        {
            var session = SessionFactory.OpenSession();

            try
            {
                var person = session.Query<PersonAddress>().SingleOrDefault(x => x.AddressId == addressId);
                return person;
            }
            finally
            {
                session.Close();
            }
        }

        public StateProvince GetStateProvince(int id)
        {
            var session = SessionFactory.OpenSession();

            try
            {
                var person = session.Query<StateProvince>().SingleOrDefault(x => x.ProvinceId == id);
                return person;
            }
            finally
            {
                session.Close();
            }
        }
    }
}
