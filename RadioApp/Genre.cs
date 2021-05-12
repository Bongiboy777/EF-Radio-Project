using System;
using System.Collections.Generic;

#nullable disable

namespace RadioDatabase
{
    public partial class Genre
    {
        public Genre()
        {
            PlayLists = new HashSet<PlayList>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}
