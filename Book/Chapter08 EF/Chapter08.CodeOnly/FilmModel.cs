using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.EntityClient;

namespace Chapter08.CodeOnly
{
    public class FilmModel : ObjectContext
    {
        public FilmModel(EntityConnection connection)
            : base(connection)
        {
            DefaultContainerName = "FilmModel";
        }
        public IObjectSet<Film> Film { get { return base.CreateObjectSet<Film>(); } }
    }
}
