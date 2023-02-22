using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_jfalagra.Models;
using System.Linq;

namespace Mission06_jfalagra.Controllers
{
    public class HomeController : Controller
    {
        private MovieDBContext daContext { get; set; }

        //Constructor
        public HomeController(MovieDBContext someName)
        {
            daContext = someName;
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
            ViewBag.Genre = daContext.genres.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(AddMovieModel ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Conf", ar);
            }
            else
            {
                ViewBag.Genre = daContext.genres.ToList();
                return View(ar);
            }
            
        }
        public IActionResult MovieList()
        {
            var showMovies = daContext.responses
                .Include(x => x.Genres)
                .ToList();
            return View(showMovies);
        }
        [HttpGet]
        public IActionResult Edit(int categoryid)
        {
            ViewBag.Genre = daContext.genres.ToList();

            var movie = daContext.responses.Single(x => x.CategoryID == categoryid);
            return View("AddMovie", movie);
        }
        [HttpPost]
        public IActionResult Edit(AddMovieModel bloo)
        {
            daContext.Update(bloo);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int categoryid)
        {
            var movie = daContext.responses.Single(x => x.CategoryID == categoryid);
            return View("AddMovie", movie);
        }
        [HttpPost]
        public IActionResult Delete(AddMovieModel ar)
        {
            daContext.responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
