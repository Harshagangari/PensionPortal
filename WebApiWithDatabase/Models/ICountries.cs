using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithDatabase.Models
{
    public interface ICountries
    {
        List<CountryClass> GetCountries();
        CountryClass GetCountry(int id);
        CountryClass AddCountry(CountryClass country);
        string DeleteCountry(int id);
        CountryClass EditCountry(CountryClass country);
    }
}
