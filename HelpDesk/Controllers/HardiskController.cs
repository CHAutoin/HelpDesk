using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelpDesk.Models;



namespace HelpDesk.Controllers
{
    public class HardiskController : Controller
    {
        public IActionResult HardiskList()
        {
            //CPU cp = new CPU();
            //var aa = cp.computer.comid;
            return View();
        }
    }
}