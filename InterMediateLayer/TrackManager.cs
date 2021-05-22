using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RadioDatabase;

namespace InterMediateLayer
{
    public class TrackManager
    {
        public Track GetTrack(string trackName)
        {
            using (var db = new RadioContext())
            {
                return db.Tracks.Include(p => p.PlayList).First(t => t.Name == trackName && t.PlayList.CreatedBy.Value == UserManager.User.UserId);
            }

        }

        public Track GetTrackFromPlaylist(string playlist, string trackName)
        {

            using (var db = new RadioContext())
            {
                return db.Tracks.Include(p => p.PlayList).First(t => t.Name == trackName && t.PlayList.CreatedBy.Value == UserManager.User.UserId && t.PlayList.Name == playlist);
            }

        }
    }
}
