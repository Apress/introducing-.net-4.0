using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter13.BobsMoviesMVC.Models
{
    public partial class Film
    {
        public bool IsValid()
        {
            if (this.GetErrors().Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Error> GetErrors()
        {
            List<Error> Errors = new List<Error>();

            if (String.IsNullOrEmpty(this.Title))
            {
                Errors.Add(new Error { Description = "Title cannot be blank", Property = "Title" });

            }

            return Errors;
        }

    }
}