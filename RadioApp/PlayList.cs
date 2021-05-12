using System;
using System.Collections.Generic;

#nullable disable

namespace RadioDatabase
{
    public partial class PlayList
    {
        public PlayList()
        {
            UserPlaylists = new HashSet<UserPlaylist>();
        }

        public int PlayListId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public int? GenreId { get; set; }
        public string Name { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<UserPlaylist> UserPlaylists { get; set; }
    }
}
