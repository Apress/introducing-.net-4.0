using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace Chapter8.HelloEF
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelDefinedFunction();

            Console.ReadKey();
            BookEntities ctx = new BookEntities();
            var query = from o in ctx.Orders
                        select o;
            foreach (Order order in query)
            {
                Console.WriteLine("Order: " + order.OrderID.ToString() + " " + order.Firstname
                + " "
                + order.Lastname);
                order.OrderItems.Load();
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    Console.WriteLine("Adult: " + orderItem.QtyAdult.ToString() + " Child:"
                    + orderItem.QtyChild.ToString());
                }
                Console.WriteLine("");
            }
            Console.ReadKey();


            //ObjectQuery option
            //ObjectQuery<Order> query = ctx.Orders.OrderBy("it.OrderID");

            //string queryString = @"SELECT VALUE o FROM BookEntities.Orders AS o";
            //ObjectQuery<Order> query = new ObjectQuery<Order>(queryString, ctx, MergeOption.NoTracking);


        }

        private static void AddObject()
        {
            BookEntities ctx = new BookEntities();
            Film NewFilm = new Film();
            NewFilm.Title = "New film";
            NewFilm.Description = "New film";
            NewFilm.Length = 300;
            FilmShowing NewFilmShowing = new FilmShowing();
            NewFilmShowing.Screen = 5;
            NewFilmShowing.ShowingDate = System.DateTime.Now;
            NewFilm.FilmShowings.Add(NewFilmShowing);
            ctx.AddObject("Films", NewFilm);
            ctx.SaveChanges();


            //Another option
            //BookEntities ctx = new BookEntities();
            //Film NewFilm = Film.CreateFilm(0);
            //NewFilm.Title = "New film2";
            //NewFilm.Description = "New film";
            //NewFilm.Length = 300;
            //ctx.AddToFilms(NewFilm);
            //ctx.SaveChanges();
        }

        private static void Updating()
        {
            BookEntities ctx = new BookEntities();
            Film FilmToUpdate = ctx.Films.Where("it.FilmID = 3").First();
            FilmToUpdate.Title = "New updated title";
            ctx.SaveChanges();
        }

        private static void Deleting()
        {
            BookEntities ctx = new BookEntities();
            ctx.Films.DeleteObject(ctx.Films.Where("it.FilmID = 5").First());
            foreach (FilmShowing fs in ctx.FilmShowings.Where("it.FilmID = 5"))
            {
                ctx.FilmShowings.DeleteObject(fs);
            }
        }

        private static void ModelDefinedFunction()
        {
            BookEntities ctx = new BookEntities();
            var query = from f in ctx.Films
                        select new { FullName = MDF.LongFilmDescription(f) };
        }

        public static class MDF
        {
            [EdmFunction("BookModel", "LongFilmDescription")]
            public static string LongFilmDescription(Film f)
            {
                throw new NotSupportedException("This function can only be used in a query");
            }
        }

    }
}
