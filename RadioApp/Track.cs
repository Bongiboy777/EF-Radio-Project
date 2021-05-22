using System;
using System.Collections.Generic;
using WMPLib;

#nullable disable

namespace RadioDatabase
{
    public partial class Track
    {
        public int? PlayListId { get; set; }
        public string Artist { get; set; }
        public int TrackID { get; set; }
        public string Name { get; set; }
        public string SourceURL { get; set; }
        public string Genre { get; set; }
        public virtual PlayList PlayList { get; set; }

        public Track(string _sourceUrl, string _name)
        {
            SourceURL = _sourceUrl;
            Name = _name;

        }

        public Track()
        {

        }

        public Track SetPlaylist(int playlistID)
        {
            this.PlayListId = playlistID;
            return this;
        }
    }
}
