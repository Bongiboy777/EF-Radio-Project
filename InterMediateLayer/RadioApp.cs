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

namespace Radio
{
    public class RadioPlayback
    {
       


        private WindowsMediaPlayerClass channels;
        //<PackageReference Include="C:\Users\Bongt\Downloads\SpotifyAPI.Web.Auth-net5.0\SpotifyAPI.Web.Auth.dll"/>
        private const string rootAddress = @"C:\Users\Bongt\OneDrive\Music";
        //SpotifyClient session = new SpotifyClient("BQCT0n3SH-PaK70gxTCkYwMG7dfr_AacuH7wqFbYk0AU5OxgYhNv42kADKaoQspCchcygrTjUcyFopSJKH3ohr6jgZsia5THZHQYPLFBXmjY2GooMQduZud5Pj5LLn1XpgIPcCBYZuS1Ke33GgXGpPFOTplXfv9KQLpfnQTvOb_yQT-VNxUdkOWXRh0RTINwnm3qBehK");
        //var track = await session.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");


        private int _channel = 1;
        private bool _on;
        IWMPPlayer4 x = new WMPLib.WindowsMediaPlayer();
        IWMPPlaylist madtunes;
        public int Volume { get => x.settings.volume; set => x.settings.volume = value; }

        public RadioPlayback()
        {

            
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


        public string Play()
        {

            x.controls.playItem(madtunes.Item[new Random().Next(0, 4)]);
            return On ? $"Channel {Channel}" : "Radio is off";
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
            switch (command)
            {
                case "FF":
                    x.controls.next();
                    x.controls.play();
                    break;

                case "Pause/Play":
                    if (x.playState == WMPPlayState.wmppsPaused)
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

   

}