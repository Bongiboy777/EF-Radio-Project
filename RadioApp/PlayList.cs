using System;
using System.Collections.Generic;

#nullable disable

namespace RadioDatabase
{
    public partial class PlayList
    {
        public PlayList()
        {
           
        }

        public int PlayListId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public virtual User CreatedByNavigation { get; set; }
    }
}
