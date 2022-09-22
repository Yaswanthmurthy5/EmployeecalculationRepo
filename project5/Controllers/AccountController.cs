using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvcproject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Validate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validate(Mvcproject.Models.Login  login)
        {
            if (ModelState.IsValid)//IsValid returns true when Model is validated
            {
                //validate used with Db table using EntityFramework
                //return RedirectToAction("Index", "Home")
                return RedirectToAction("Index", "Employee");
            }
     
            else
                return View();
        }
    }
}