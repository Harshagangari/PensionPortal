using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDatabase.Models;

namespace WebAPIDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryOpsController : ControllerBase
    {
        public ICountriesData countryData;
        public CountryOpsController(ICountriesData countriesData)
        {
            countryData = countriesData;
        }
        [HttpGet]
        [Route("getcountries")]
        public IActionResult Get()
        {
            return Ok("hello");
        }

        [HttpGet("{id}")]
        [Route("getcountriesbyid")]
        public ActionResult<CountryClass> Get(int id)
        {
            return Ok(countryData.GetCountry(id));
        }

        [HttpPost]
        [Route("PostCountry")]
        public ActionResult<CountryClass>  Post([FromBody] CountryClass country)
        {
            return countryData.AddCountry(country);
        }
    }
}
