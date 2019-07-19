using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvs.Models.ViewModels;

namespace SalesWebMvs.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Sales Web MVC App from C# Course";
            ViewData["Student"] = "Jonas Garcia";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";
            ViewData["EmailCustom"] = "suporte.ti@wittel.com";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
