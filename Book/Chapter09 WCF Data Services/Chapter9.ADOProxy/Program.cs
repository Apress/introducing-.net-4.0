using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Services.Client;

namespace Chapter9.ADOProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServiceContext ctx =new DataServiceContext(new Uri("http://localhost/Chapter9/MovieService.svc"));
            var Orders =
            ctx.Execute<MovieService.Order>(new Uri("Orders", UriKind.Relative));
            foreach (MovieService.Order Order in Orders)
            {
                Console.WriteLine(Order.Firstname);
            }
            Console.ReadKey();
        }

        public void AddNewItem()
        {
            DataServiceContext ctx = new DataServiceContext(new Uri("http://localhost/Chapter9/MovieService.svc"));
            MovieService.Film NewFilm = new MovieService.Film();
            NewFilm.Title = "Pulp Fiction";
            NewFilm.Length = 124;
            NewFilm.Description = "Quentins classic movie";
            ctx.AddObject("Films", NewFilm);
            ctx.SaveChanges();
        }

        public void UpdateItem()
        {
            DataServiceContext ctx = new DataServiceContext(new Uri("http://localhost/Chapter9/MovieService.svc"));
            MovieService.Film FilmToUpdate =ctx.Execute<MovieService.Film>(new Uri("Films(1)", UriKind.Relative)).First();
            FilmToUpdate.Title = "Updated title";
            ctx.UpdateObject(FilmToUpdate);
            ctx.SaveChanges();
        }

        public void DeleteItem()
        {
            DataServiceContext ctx = new DataServiceContext(new Uri("http://localhost/Chapter9/MovieService.svc"));
            MovieService.Film FilmToDelete =
            ctx.Execute<MovieService.Film>(new Uri("Films(1)", UriKind.Relative)).First();
            ctx.DeleteObject(FilmToDelete);
            ctx.SaveChanges();
        }
    }
}
