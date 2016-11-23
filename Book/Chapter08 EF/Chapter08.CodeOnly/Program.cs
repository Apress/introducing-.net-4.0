using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using System.Data.SqlClient;

namespace Chapter08.CodeOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note this wont work at time of writing due to EF add on not being available for RC yet

            var ctxBuilder = new ContextBuilder<FilmModel>();
            ctxBuilder.Configurations.Add(new FilmConfiguration());
            var ctx =
            ctxBuilder.Create(new SqlConnection(
            "server=localhost;UID=USERNAME;PWD=PASSWORD; database=book;Pooling=true")
            );
            var NewFilm =
            new Film { Description = "Code only", Length = 200, Title = "Total Recall" };
            ctx.Film.AddObject(NewFilm);
            ctx.SaveChanges();
            ctx.Dispose();
        }
    }


}
