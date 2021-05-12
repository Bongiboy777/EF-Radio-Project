using System;
using System.Collections.Generic;

#nullable disable

namespace RadioDatabase
{
    public partial class UserPlaylist
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? PlayListId { get; set; }

        public virtual PlayList PlayList { get; set; }
        public virtual User User { get; set; }
    }
}
