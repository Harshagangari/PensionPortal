using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionManagementPortal.Controllers
{
    public class PensionManagement : Controller
    {
        public IActionResult Index()
        {
            return View("Create");
        }
    }
}
