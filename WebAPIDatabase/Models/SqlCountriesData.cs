using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDatabase.Models
{
    public class SqlCountriesData : ICountriesData
    {
        private readonly DbContextClass context;
        public SqlCountriesData(DbContextClass _context)
        {
            context = _context;
        }
        public List<CountryClass> GetCountries()
        {
            return context.countries.ToList();
        }
        public CountryClass AddCountry(CountryClass country)
        {
            context.countries.Add(country);
            context.SaveChanges();
            return country;
        }

        public void DeleteCountry(CountryClass country)
        {
            context.countries.Remove(country);
            context.SaveChanges();
        }

        public CountryClass EditCountry(CountryClass country)
        {
            var countryEdit = context.countries.SingleOrDefault(x => x.id == country.id);
            countryEdit.countryname = country.countryname;
            countryEdit.areaInSqKm = country.areaInSqKm;
            countryEdit.Officialrepresentative = country.Officialrepresentative;
            countryEdit.populationInCr = country.populationInCr;
            return country;
        }

       

        public CountryClass GetCountry(int id)
        {
            if(id<=0)
            {
                return null;
            }
            var country = context.countries.Find(id);
            return country;
        }
    }
}
