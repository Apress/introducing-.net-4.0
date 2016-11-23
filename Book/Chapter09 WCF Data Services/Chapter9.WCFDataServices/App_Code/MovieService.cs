using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Linq.Expressions;
using BookModel;

public class MovieService : DataService<BookModel.BookEntities>
{
    // This method is called only once to initialize service-wide policies.
    public static void InitializeService(DataServiceConfiguration config)
    {
       //config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
       config.SetEntitySetAccessRule("*", EntitySetRights.All);
       config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
    }

    //Uncomment to see filter
    //[QueryInterceptor("Films")]
    //public Expression<Func<Film, bool>> FilterOnlyShowFilmID1()
    //{
    //    return f => f.FilmID == 1;
    //}
}
