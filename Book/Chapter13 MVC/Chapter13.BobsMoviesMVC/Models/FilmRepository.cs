using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter13.BobsMoviesMVC.Models
{
    public class FilmRepository : BobsMoviesMVC.Models.IFilmRepository
    {
        private BobsMoviesMVC.Models.TheatreEntities dbContext = new BobsMoviesMVC.Models.TheatreEntities();

        public IEnumerable<Film> GetAll()
        {
            return dbContext.Films;

        }

        public Film GetFilm(int ID)
        {
            return dbContext.Films.Single(f => f.FilmID == ID);
        }


        public bool Add(Film film)
        {
            if (film.GetErrors().Count == 0)
            {
                dbContext.Films.AddObject(film);
                Save();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Update(Film film)
        {
            if (film.GetErrors().Count == 0)
            {
                var ExistingFilm = dbContext.Films.Single(f => f.FilmID == film.FilmID);
                ExistingFilm.Title = film.Title;
                ExistingFilm.Description = film.Description;
                ExistingFilm.Length = film.Length;

                Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(int ID)
        {
            dbContext.Films.DeleteObject(dbContext.Films.Single(f => f.FilmID == ID));
            Save();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }



    }

}