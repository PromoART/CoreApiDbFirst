using System.Collections.Generic;
using System.Linq;
using Autofac.Extras.DynamicProxy;
using Core;
using Core.Entities;
using NHibernate;

namespace Services
{
    [Intercept("dataInterceptor")]
    public class InterceptedDataProvider : IIntercepdetDataProvider
    {
        private ISession _session;

        public virtual void SetSession(ISession session)
        {
            _session = session;
        }
        public virtual IEnumerable<PersonAddress> GetPersonAdreses()
        {
            var addreses = _session.Query<PersonAddress>().ToList();

            return addreses;
        }

        public virtual IEnumerable<StateProvince> GetStateProvinces()
        {
            var personAdressQuery = _session.Query<StateProvince>().ToList();
            return personAdressQuery;
        }

        public virtual IEnumerable<CountryRegion> GetCountryRegions()
        {
            var regions = _session.Query<CountryRegion>().ToList();

            return regions;
        }

        public virtual PersonAddress GetPersonAddress(int addressId)
        {
            var person = _session.Query<PersonAddress>().SingleOrDefault(x => x.AddressId == addressId);
            return person;
        }

        public virtual StateProvince GetStateProvince(int id)
        {
            var person = _session.Query<StateProvince>().SingleOrDefault(x => x.ProvinceId == id);
            return person;
        }

        public virtual void CreatePersonAddress(PersonAddress address)
        {
            using (var scope = _session.BeginTransaction())
            {
                _session.Save(address);
                scope.Commit();
            }
        }

        public virtual void CreateStateProvince(StateProvince province)
        {
            using (var scope = _session.BeginTransaction())
            {
                _session.Save(province);
                scope.Commit();
            }
        }

        public virtual void UpdateAddress(PersonAddress address)
        {
            using (var scope = _session.BeginTransaction())
            {
                _session.Update(address);
                scope.Commit();
            }
        }

        public virtual void UpdateStateProvince(StateProvince province)
        {
            using (var scope = _session.BeginTransaction())
            {
                _session.Update(province);
                scope.Commit();
            }
        }

        public virtual void DeleteAddress(int id)
        {
                var query = _session.Query<PersonAddress>().Where(x => x.AddressId == id);

                using (var scope = _session.BeginTransaction())
                {
                    _session.Delete(query);
                    scope.Commit();
                }
        }

        public virtual void DeleteStateProvince(int id)
        {
            var query = _session.Query<PersonAddress>().Where(x => x.AddressId == id);

            using (var scope = _session.BeginTransaction())
            {
                _session.Delete(query);
                scope.Commit();
            }
        }
    }
}
