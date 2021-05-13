using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using WMPLib;
using WMPDXMLib;
using System.IO;
using SpotifyAPI;
using RadioDatabase;
using SpotifyAPI.Web.Auth;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using System.IO;
using RadioDatabase;

namespace InterMediateLayer
{
    public class PlaylistManager
    {
          WindowsMediaPlayer x;
        WindowsMediaPlayerClass channels = new WindowsMediaPlayerClass();
        
        public static List<string> mediaPaths = new List<string> { @"C:\Users\Bongt\OneDrive\Documents\sparta global\eng86\Eng86\C#Data\EF-Project\Radio\RadioGUI\media\" };
        

            //channels[Channel-1].play();
            public PlaylistManager()
        {

        }

        public void AddPlaylist(string name)
        {
            Directory.CreateDirectory($@"mediaPaths[0]\name");
            x.playlistCollection.newPlaylist(name);
            
        }

        public void AddToPlaylist(string playlistName,string track)
        {
            IWMPMedia music1 = channels.add($@"{mediaPaths[0]}\{track}");
            x.playlistCollection.getByName(playlistName).Item(0).appendItem(music1);
        }

    }
}
