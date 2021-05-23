using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using WMPLib;
using WMPDXMLib;
using System.IO;
using RadioDatabase;
using System.Media;
using System.Windows;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;

namespace InterMediateLayer
{
    public class RadioPlayback
    {
        
        PlaylistManager playlistManager = new PlaylistManager();

        public WindowsMediaPlayerClass mediaPlayer = new WindowsMediaPlayerClass();

        private const string rootAddress = @"C:\Users\Bongt\OneDrive\Music";
        

        private int _channel = 1;
        private bool _on;
        
        
        
        public int Volume { get => mediaPlayer.settings.volume; set => mediaPlayer.settings.volume = value; }

        public RadioPlayback()
        {
            
            
        }



        public void NextTrack(object sender, EventArgs e)
        {
            mediaPlayer.controls.next();
        }

        public void PreviousTrack(object sender, EventArgs e)
        {
            mediaPlayer.controls.previous();
        }

        public void TogglePause(object sender, EventArgs e)
        {
            if(mediaPlayer.playState == WMPPlayState.wmppsPaused)
            {
                mediaPlayer.resume();
            }
            else
            {
                mediaPlayer.pause();
            }
        }

        public void Stop()
        {
            mediaPlayer.controls.stop();
        }

        public void PlayChannel(string channel)
        {
            using(var db = new RadioContext())
            {
              PlayList playList =  db.Users.Include(u => u.PlayLists).Where(u => u.UserId == UserManager.User.UserId).Select(x => x.PlayLists).First().First(p => p.Name == channel);
                if (mediaPlayer.playlistCollection.getByName(channel).count == 0)
                {
                    mediaPlayer.playlistCollection.newPlaylist(channel);
                }
                mediaPlayer.currentPlaylist = mediaPlayer.playlistCollection.getByName(channel).Item(0);

                db.Tracks.Where(t => playList.PlayListId == t.PlayListId).ToList().ForEach(t =>
                {
                    mediaPlayer.currentPlaylist.appendItem(mediaPlayer.add(t.SourceURL));
                    });
                mediaPlayer.controls.play();
            }
        }

        public void AddChannelPlaylist(FileInfo[] files, string name)
        {

        }

        public bool On { get => _on; set => _on = value; }

        public int Channel
        {
            get => _channel;
            set => _channel = value;
        }


        public void Play()
        {
            using (var db = new RadioContext())
            {
                
                mediaPlayer.play();
            }
                
        }

        public void TurnOff()
        {
            On = false;
            mediaPlayer.controls.stop();
        }

        public void TurnOn()
        {
            Play();
            On = true;
        }

        
    }

   

}
