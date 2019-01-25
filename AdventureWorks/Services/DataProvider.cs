using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Entities;

namespace Services
{
    public class DataProvider : IDataProvider
    {
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

        public void CreatePersonAddress(PersonAddress address)
        {
            var session = SessionFactory.OpenSession();

            try
            {
                using (var scope = session.BeginTransaction())
                {
                    session.Save(address);
                    scope.Commit();
                }
            }
            finally
            {
                session.Close();
            }
        }

        public void CreateStateProvince(StateProvince province)
        {
            var session = SessionFactory.OpenSession();

            try
            {
                using (var scope = session.BeginTransaction())
                {
                    session.Save(province);
                    scope.Commit();
                }
            }
            finally
            {
                session.Close();
            }
        }

        public void UpdateAddress(PersonAddress address)
        {
            var session = SessionFactory.OpenSession();

            try
            {
                using (var scope = session.BeginTransaction())
                {
                    session.Update(address);
                    scope.Commit();
                }
            }
            finally
            {
                session.Close();
            }
        }

        public void UpdateStateProvince(StateProvince province)
        {
            var session = SessionFactory.OpenSession();

            try
            {
                using (var scope = session.BeginTransaction())
                {
                    session.Update(province);
                    scope.Commit();
                }
            }
            finally
            {
                session.Close();
            }
        }

        public void DeleteAddress(int id)
        {
            var session = SessionFactory.OpenSession();
            try
            {
                var query = session.Query<PersonAddress>().Where(x => x.AddressId == id);

                using (var scope = session.BeginTransaction())
                {
                    session.Delete(query);
                    scope.Commit();
                }
            }
            finally
            {
                session.Close();
            }
        }

        public void DeleteStateProvince(int id)
        {
            var session = SessionFactory.OpenSession();
            try
            {
                var query = session.Query<PersonAddress>().Where(x => x.AddressId == id);

                using (var scope = session.BeginTransaction())
                {
                    session.Delete(query);
                    scope.Commit();
                }
            }
            finally
            {
                session.Close();
            }
        }
    }
}
