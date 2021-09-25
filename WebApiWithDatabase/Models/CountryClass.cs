using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApiWithDatabase.Models
{
    public class CountryClass
    {

        [Key]
        public int id { get; set; }
        public string countryname { get; set; }
        public double populationInCr { get; set; }
        public double areaInSqKm { get; set; }
        public string Officialrepresentative { get; set; }
    }
}



    
       

