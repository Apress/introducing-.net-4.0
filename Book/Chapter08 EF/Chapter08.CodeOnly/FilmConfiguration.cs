using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter08.CodeOnly
{
    class FilmConfiguration : EntityConfiguration<Film>
    {
        public FilmConfiguration()
        {
            Property(f => f.FilmID).IsIdentity();
            Property(f => f.Title).HasMaxLength(100).IsRequired();
        }
    }
}
