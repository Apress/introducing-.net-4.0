using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter13.BobsMoviesMVC.Models
{
    public interface IFilmRepository
    {
        bool Add(Film film);
        void Delete(int ID);
        IEnumerable<Film> GetAll();
        Film GetFilm(int ID);
        void Save();
        bool Update(Film film);
    }

}