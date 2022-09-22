using Mvcproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvcproject.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            //Validate Model User and save user data to db table
            return RedirectToAction("Validate","Account");
        }
    }
}