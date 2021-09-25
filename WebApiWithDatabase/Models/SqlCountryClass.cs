using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithDatabase.Models
{
    public class SqlCountryClass : ICountries
    {

        private readonly DbContextClass context;
        public SqlCountryClass(DbContextClass _context)
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

        public string DeleteCountry(int id)
        {
            
            try 
            {
                var countrytoDelete = context.countries.Find(id);
                context.countries.Remove(countrytoDelete);
                context.SaveChanges();
                return "Deleted Successfully!";
            }
            catch(Exception exp)
            {
                return "Error in Deleting";
            }
        }

        public CountryClass EditCountry(CountryClass country)
        {
            var countryEdit = context.countries.Find(country.id);
            if(countryEdit!=null)
            {
                countryEdit.countryname = country.countryname;
                countryEdit.areaInSqKm = country.areaInSqKm;
                countryEdit.Officialrepresentative = country.Officialrepresentative;
                countryEdit.populationInCr = country.populationInCr;
                context.SaveChanges();
                return country;
            }
            else
                {
                return null;
            }
           
        }


        
        public CountryClass GetCountry(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            var country = context.countries.Find(id);
            return country;
        }
    }
}
