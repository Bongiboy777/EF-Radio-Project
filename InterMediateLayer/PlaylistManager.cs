using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using WMPLib;
using WMPDXMLib;
using System.IO;
using RadioDatabase;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;


namespace InterMediateLayer
{
    public class PlaylistManager
    {
        public static WindowsMediaPlayer x = new WindowsMediaPlayer();

            public PlaylistManager()
            {

            }

        public void AddPlaylist(string name)
        {
            using (var db = new RadioContext())
            {
               db.PlayLists.Add(new PlayList() { Name = name, CreatedBy = UserManager.User.UserId, DateCreated = DateTime.Now });
               db.SaveChanges();
            }
           

        }

        public List<Track> GetTracks(PlayList playlist)
        {
            using(var db = new RadioContext())
            {
                return db.Tracks.Where(t => t.PlayListId == playlist.PlayListId).ToList();
            }
        }

        public PlayList GetPlaylist(string playlistName)
        {
            using (var db = new RadioContext())
            {
                return db.PlayLists.First(p => playlistName == p.Name && p.CreatedBy.Value == UserManager.User.UserId);
            }
        }

        public void AddToPlaylist(string playlistName,Track track)
        {
            if(playlistName != null)
            {
                using (var db = new RadioContext())
                {
                    int playlistID = db.PlayLists.First(c => c.Name == playlistName).PlayListId;
                    db.Tracks.Add(track.SetPlaylist(playlistID));
                    db.SaveChanges();
                }
            }

            
        }

        public void RemovePlaylist(string playlistname)
        {
            x.playlistCollection.remove(x.playlistCollection.getByName(playlistname).Item(0));
        }

    }
}
