using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WenSonarCloudProj.Models;

namespace WenSonarCloudProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            bool blnWork = true;

            //if (val == "Good")
            //    blnWork = true;
            //else
            //    blnWork = false;

            if (blnWork)
                ViewBag.Work = "Good Work";
            else
                ViewBag.Work = "Needs Improvement";
            return View();
        }

        private readonly string[] whiteList = { "https://www.sonarsource.com" };

        public IActionResult RedirectMe(string url)
        {
            return Redirect(url);

            //if (!whiteList.Contains(url))
            //{
            //    return BadRequest();
            //}

            //return Redirect(url);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
