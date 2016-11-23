using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chapter13.BobsMoviesMVC.Controllers
{
    public static class UrlHelperExtension
    {

        public static string AllFilms(this UrlHelper helper)
        {
            return helper.Content("~/Film/All");
        }
    }

}