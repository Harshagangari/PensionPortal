using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDatabase.Models
{
    public interface ICountriesData
    {
        List<CountryClass> GetCountries();
        CountryClass GetCountry(int id);
        CountryClass AddCountry(CountryClass country);
        void DeleteCountry(CountryClass country);
        CountryClass EditCountry(CountryClass country);
    }
}
