using System;
using System.Threading;
using System.Collections.Generic;
using WMPLib;
using System.IO;
using SpotifyAPI;

namespace RadioApp
{
    public class Radio
    {
        public static List<string> mediaPaths = new List<string>{ @"C:\Users\Bongt\OneDrive\Documents\sparta global\eng86\Eng86\C#Data\EF-Project\Radio\RadioGUI\media\" };


        private WindowsMediaPlayerClass channels;
        //<PackageReference Include="C:\Users\Bongt\Downloads\SpotifyAPI.Web.Auth-net5.0\SpotifyAPI.Web.Auth.dll"/>
        private const string rootAddress = @"C:\Users\Bongt\OneDrive\Music";
        //SpotifyClient session = new SpotifyClient("BQCT0n3SH-PaK70gxTCkYwMG7dfr_AacuH7wqFbYk0AU5OxgYhNv42kADKaoQspCchcygrTjUcyFopSJKH3ohr6jgZsia5THZHQYPLFBXmjY2GooMQduZud5Pj5LLn1XpgIPcCBYZuS1Ke33GgXGpPFOTplXfv9KQLpfnQTvOb_yQT-VNxUdkOWXRh0RTINwnm3qBehK");
        //var track = await session.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");

        
        private int _channel = 1;
        private bool _on;
        WindowsMediaPlayer x = new WMPLib.WindowsMediaPlayer();
        IWMPPlaylist madtunes;
        public int Volume { get => x.settings.volume; set => x.settings.volume = value; }

        public Radio()
        {
         
            channels = new WindowsMediaPlayerClass();
            
            x.URL = mediaPaths[0] + "Funk4.wav";
            madtunes = x.newPlaylist("MadTunes", mediaPaths[0]);
            madtunes.appendItem(channels.add(mediaPaths[0] + "Funk4.wav"));
            madtunes.appendItem(channels.add(mediaPaths[0] + "2Pac_ft_Eric_Williams_-_Do_For_Love_Qoret.mp3"));
            madtunes.appendItem(channels.add(mediaPaths[0] + "hard track 1.mp3"));
            madtunes.appendItem(channels.add(mediaPaths[0] + "Take It to the Lord in Prayer   Aeolians of Oakwood University.wav"));
            madtunes.appendItem(channels.add(mediaPaths[0] + "What does the Electoral Commission’s probe mean for Boris Johnson  – BBC Newsnight.mp3"));
            x.currentPlaylist = madtunes;
            
            
            
            x.controls.stop();
            
            //channels[Channel-1].play();

        }

        public void AddChannelPlaylist(FileInfo[] files, string name)
        {
            
        }

        public bool On { get => _on; set => _on = value; }

        public int Channel { 
            get => _channel;
            set => _channel = value;
        }
        

        public string Play()
        {
            
            x.controls.playItem(madtunes.Item[new Random().Next(0,4)]);
            return On ? $"Channel {Channel}": "Radio is off";
        }

        public void TurnOff()
        {
            On = false;
            x.controls.stop();
        }

        public void TurnOn()
        {
            Play();
            On = true;
        }

        public void Playback(string command)
        {
            switch(command)
            {
                case "FF":
                    x.controls.next();
                    x.controls.play();
                    break;

                case "Pause/Play":
                    if(x.playState == WMPPlayState.wmppsPaused)
                    {
                        x.controls.play();
                        break;
                    }
                    x.controls.pause();
                    break;

                case "Rewind":
                    x.controls.previous();
                    break;
            }
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}