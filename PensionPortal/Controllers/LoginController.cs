using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PensionPortal.Entites;

namespace PensionPortal.Controllers
{
    public class LoginController : Controller
    {
        List<Login> loginDetails = new List<Login>();
        public LoginController()
        {
            loginDetails.Add(new Login() { Username = "lavangam", Password = "alda@paris" });

            loginDetails.Add(new Login() { Username = "pampachek", Password = "ruchi@usa" });
        }   
                
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            var user = loginDetails.Find(x => x.Username == username);
            if(user!=null && user.Password.Equals(password))
            {
                ViewBag.message = "Login Success";
                return RedirectToAction("Create","PensionDetails");
            }
            ViewBag.message = "Password choosko nayana";
            return View();
        }
    }
}
