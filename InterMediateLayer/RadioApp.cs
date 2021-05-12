using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using WMPLib;
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
        public static List<string> mediaPaths = new List<string> { @"C:\Users\Bongt\OneDrive\Documents\sparta global\eng86\Eng86\C#Data\EF-Project\Radio\RadioGUI\media\" };


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

        public RadioPlayback()
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

    public class UserManager
    {
        public void CreateUser(out string errorMessage, string firstName = "Bongani", string lastName = "Luwemba", string userName = "Bongiboy777", string email = "Bongtheman@outlook.com", string passWord = "1234567")
        {
            using (var db = new RadioContext())
            {
                errorMessage = null;

                if (db.Users.Where(u => u.Email == email).Count() != 0)
                {
                    errorMessage = $"This email address is already in use with another account.";
                    return;
                }
                try
                {
                    db.Users.Add(new User(firstName, lastName, userName, email, passWord));

                    db.SaveChanges();
                }

                catch (DbUpdateConcurrencyException e)
                {
                    errorMessage = $"Could not add user please check fields: {e.Message}";
                }

                catch (DbUpdateException ex)
                {
                    errorMessage = $"Could not add user please check fields: {ex.Message}";
                }

            }
        }

        public void CreateUser(string firstName = "Bongani", string lastName = "Luwemba", string userName = "Bongiboy777", string email = "Bongtheman@outlook.com", string passWord = "1234567")
        {
            using (var db = new RadioContext())
            {
               
                try
                {
                    db.Users.Add(new User(firstName, lastName, userName, email, passWord));

                    db.SaveChanges();
                }

                catch (DbUpdateConcurrencyException e)
                {
                    Console.WriteLine($"Could not add user please check fields: {e.Message}");
                }

                catch (DbUpdateException ex)
                {
                    Console.WriteLine($"Could not add user please check fields: {ex.Message}");
                }

            }
        }

        public void UpdateUser(out string errorMessage, User user, string firstName = null, string lastName = null, string passWord = null, string userName = null, string email = null)
        {
            using (var db = new RadioContext())
            {
                errorMessage = null;
                
                
                try
                {
                    user.LastName = lastName != null ? lastName : user.LastName;
                    user.FirstName = firstName != null ? firstName : user.FirstName;

                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    errorMessage = $"Could not update firstname or last name fields, please check: {e.Message}";
                }

                try
                {
                    user.Username = userName != null ? userName : user.Username;
                    db.SaveChanges();


                }

                catch (Exception e)
                {
                    errorMessage = $"Username was put in incorrect format, please correct";
                }

                // Assign email
                try
                {
                    user.Email = email != null ? email : user.Email;
                    db.SaveChanges();
                }

                catch (DbUpdateException ex)
                {
                    errorMessage = $"Email was put in incorrect format, please correct";
                }

                try
                {
                    user.PassWord = passWord != null ? passWord : user.PassWord;
                    db.SaveChanges();
                }

                catch (Exception ex)
                {

                }

                db.SaveChanges();
            }
        }

        public void RemoveUser(out string errorMessage, User user)
        {
            using (var db = new RadioContext())
            {
                errorMessage = null;


                try
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    errorMessage = $"Could not update firstname or last name fields, please check: {e.Message}";
                }

                catch(ArgumentNullException ex)
                {
                    errorMessage = $"This user does not exist anymore.";
                }

                
            }
        }

        public bool VerifyUser(out string error, string password, string email=null, string userName = null)
        {
            error = null;
            User user = null;
            using (var db = new RadioContext())
            {
                try
                {
                    user = userName != null ? db.Users.Where(u => u.Username == userName).First()
                        : email != null ? db.Users.Where(u => u.Email == email).First() : null;
                }

                catch(InvalidOperationException e)
                {
                    error = email == null ? $"Username {userName} is incorrect or does not exist." : $"Email {email} is incorrect or does not exist";
                    return false;
                }

                if(user != null)
                {
                    return user.PassWord == password;
                }

                return false;
            }
                
        }

    }

}