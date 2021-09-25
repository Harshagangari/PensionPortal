using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDatabase.Models;

namespace WebApiWithDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryOperationsController : ControllerBase
    {
        private ICountries _countries;
        public CountryOperationsController(ICountries countries)
        {
            _countries = countries;
        }
        [HttpGet]
        [Route("getcountries")]
        public ActionResult Get()
        {
            return Ok(_countries.GetCountries());
        }

        [HttpGet]
        [Route("getcountrybyid")]
        public ActionResult GetById(int id)
        {
            return Ok(_countries.GetCountry(id));
        }

        [HttpPost]
        [Route("PostCountry")]
        public ActionResult PostCountry([FromBody] CountryClass country)
        {
            return Ok(_countries.AddCountry(country));
        }
        [HttpPut]
        [Route("EditCountry")]
        public ActionResult EditCountry([FromBody] CountryClass country)
        {
            return Ok(_countries.EditCountry(country));
        }

        [HttpDelete]
        [Route("DeleteCountry")]
        public ActionResult DeleteCountry(int id)
        {
            return Ok(_countries.DeleteCountry(id));
        }
    }
}
