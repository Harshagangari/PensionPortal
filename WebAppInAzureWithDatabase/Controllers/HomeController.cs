using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppInAzureWithDatabase.Models;

namespace WebAppInAzureWithDatabase.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly MemeContextClass context;

       /* public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
       public HomeController(MemeContextClass _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            List<MemeDialouges> dialougeList=null;
            if(!ModelState.IsValid)
            {
                return null;
            }
            else
            {
               dialougeList = context.dialogues.ToList();
            }
           
            return View(dialougeList);
        }
    }
}
