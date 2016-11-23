using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Chapter13.BobsMoviesMVC.Controllers
{
    public class FilmController : Controller
    {
        private BobsMoviesMVC.Models.IFilmRepository filmRepository;

        public FilmController()
        {
            filmRepository = new BobsMoviesMVC.Models.FilmRepository();
        }

        public FilmController(BobsMoviesMVC.Models.IFilmRepository Repository)
        {
            filmRepository = Repository;
        }


        public ActionResult Index()
        {
            ViewData["Message"] = "Hello and welcome to MVC!";
            return View();
        }

        public ActionResult IWillAlsoReturnIndex()
        {
            ViewData["Message"] = "I am using Index view";
            return View("Index");
        }

        public ActionResult All()
        {
            return View(filmRepository.GetAll());
        }

        public ActionResult Detail(int ID)
        {
            Models.Film Film = filmRepository.GetFilm(ID);
            ViewData["Title"] = Film.Title;
            ViewData["Description"] = Film.Description;
            ViewData["Length"] = Film.Length.ToString();

            return View();
        }


        [AcceptVerbs("GET")]
        public ActionResult Edit(int ID)
        {

            return View(filmRepository.GetFilm(ID));
        }


        [AcceptVerbs("POST")]
        public ActionResult Edit(BobsMoviesMVC.Models.Film Film)
        {
            if (Film.IsValid() == true)
            {
                filmRepository.Update(Film);

                return RedirectToAction("All");
            }
            else
            {
                foreach (BobsMoviesMVC.Models.Error error in Film.GetErrors())
                {
                    ModelState.AddModelError(error.Property, error.Description);
                }

                return View(filmRepository.GetFilm(Film.FilmID));
            }

            
        }

        [AcceptVerbs("GET")]
        public ActionResult Create()
        {

            return View();
        }

        [AcceptVerbs("POST")]
        public ActionResult Create(BobsMoviesMVC.Models.Film film)
        {
            filmRepository.Add(film);
            return RedirectToAction("All");
        }
              

        public ActionResult Delete(int ID)
        {
            filmRepository.Delete(ID);
            return RedirectToAction("All");
        }

        [AcceptVerbs("GET")]
        public ActionResult EditJSON(int ID)
        {
            return View(filmRepository.GetFilm(ID));
        }

        [AcceptVerbs("POST")]
        public JsonResult EditJSON(BobsMoviesMVC.Models.Film film)
        {

            filmRepository.Update(film);

            //Return a very simple JSON response
            return Json(new { Message = "Success", Title = film.Title });
        }


    }
}
