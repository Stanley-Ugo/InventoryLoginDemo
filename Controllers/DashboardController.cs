using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryLoginDemo.Controllers
{
    public class DashboardController : Controller
    {
        //Dashboard View
        public IActionResult Index()
        {
            var token = HttpContext.Session.GetString("JWToken");
            return View();
        }
    }
}
