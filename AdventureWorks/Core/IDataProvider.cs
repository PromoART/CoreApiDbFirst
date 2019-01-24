using System.Collections.Generic;
using Core.Entities;

namespace Core
{
    public interface IDataProvider
    {
        void CheckConnection();

        IEnumerable<PersonAddress> GetPersonAdreses();

        IEnumerable<StateProvince> GetStateProvinces();
    }
}