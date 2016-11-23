using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chapter13.BobsMoviesMVC.Models;


namespace BobsMoviesMVC.Support
{
    public class FakeFilmRepository : IFilmRepository
    {

        public List<Film> Films = new List<Film>();


        #region IFilmRepository Members

        public bool Add(Film film)
        {
            throw new NotImplementedException();
        }

        public Film Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetAll()
        {
            return Films;
        }

        public Film GetFilm(int FilmID)
        {
            return Films.Single(f => f.FilmID == FilmID);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Film film)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
