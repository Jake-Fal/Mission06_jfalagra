using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_jfalagra.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jfalagra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDBContext _blooContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieDBContext someName)
        {
            _logger = logger;
            _blooContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bacon()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(AddMovieModel ar)
        {
            _blooContext.Add(ar);
            _blooContext.SaveChanges();
            return View("Conf", ar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
