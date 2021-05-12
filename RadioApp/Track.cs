using System;
using System.Collections.Generic;

#nullable disable

namespace RadioDatabase
{
    public partial class Track
    {
        public int? PlayListId { get; set; }
        public string Artist { get; set; }
        public int? GenreId { get; set; }
        public string Name { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual PlayList PlayList { get; set; }
    }
}
