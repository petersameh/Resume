using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using resume.Core.Interfaces;
using resume.Models;

namespace resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IResumeCore _resumeCore;

        public HomeController(ILogger<HomeController> logger, IResumeCore resumeCore)
        {
            _logger = logger;
            _resumeCore = resumeCore;
        }

        public IActionResult Index()
        {
            var resume = _resumeCore.RetrieveResumeModel();
            return View(resume);
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
