using FilmDB.Models;
using FilmDB.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private FilmManager _manager;


        public FilmController(FilmManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var film = new FilmModel();
            film.ID = 0;
            film.Title = "Rambo";
            _manager.AddFilm(film);
            return View();
           
        }
        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
      
            _manager.AddFilm(film);
            return View(film);
        }

    }
}
