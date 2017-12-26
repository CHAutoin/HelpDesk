using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore;

namespace HelpDesk.Controllers
{
    public class UserHelpDeskController : Controller
    {
        public IActionResult DashBoard()
        {

            return View();
        }





        [HttpGet]
        public IActionResult MainNews()
        {
            //HttpContext.Session.SetString("nametest", "stringtest");

            //ViewBag.showstr = HttpContext.Session.GetString("nametest");
            return View();

        }
    }
}