using System.Collections.Generic;
using Core.Entities;

namespace Core
{
    public interface IDataProvider
    {
        void CheckConnection();

        IEnumerable<PersonAddress> GetPersonAdreses();

        IEnumerable<StateProvince> GetStateProvinces();

        IEnumerable<CountryRegion> GetCountryRegions();

        PersonAddress GetPersonAddress(int addressId);
        StateProvince GetStateProvince(int provinceId);

        void CreatePersonAddress(PersonAddress address);

        void CreateStateProvince(StateProvince province);
    }
}