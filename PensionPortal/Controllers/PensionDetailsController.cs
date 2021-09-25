using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PensionPortal.Entites;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Web;

namespace PensionPortal.Controllers
{
    public class PensionDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
          
        }
       
       [HttpPost]
        public IActionResult Display(double AadharNo,string name,DateTime dob,int pensionType,string pan)
        {
            dynamic dataObj = new ExpandoObject();
            dataObj.aadharNo = AadharNo;
            dataObj.Name = name;
            dataObj.Dob = dob;
            dataObj.pensiontype = pensionType;
            dataObj.Pan = pan;
            ViewBag.details = dataObj;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55345/api/pensionerdetails/");
                var response = client.GetAsync("getById?aadharID=" + (string)dataObj.Pan);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    
                    JsonDocument jd = JsonDocument.Parse(result.Content.ReadAsStringAsync().Result);
                    //return View();
                    if(!dataObj.Name.Equals(jd.RootElement.GetProperty("name")))
                    {
                        ViewBag.link = Url.Action(null,"PensionDetails","Create");
                    }
                    ViewBag.pension = jd.RootElement.GetProperty("salaryEarned");
                }
            }
            return View();
        }


    }
}
