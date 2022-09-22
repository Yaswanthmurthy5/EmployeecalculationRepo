using project5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project5.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(new salary());
        }
        [HttpPost]
        public ActionResult Index(salary s)
        {
            if (s.bsal > 50000)
            {
                s.Tax = s.bsal * 10 / 100;
            }
            else if (s.bsal > 30000)
            {
                s.Tax = s.bsal * 5 / 100;
            }
            else
            {
                s.Tax = 0;
            }
                s.Netsal = s.bsal - s.Tax;

                return View(s);
            }
        }
    }