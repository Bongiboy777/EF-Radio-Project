using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioDatabase;
using RadioGUI;
using RadioTests;
using InterMediateLayer;

namespace PlaylistTests
{
    class PlaylistTests
    {
        PlaylistManager playlistManager;
        UserManager userManager = new UserManager();
        [SetUp]
        public void Setup()
        {
            playlistManager = new PlaylistManager();
            userManager.CreateUser("test","test","test","test","test");

        }

        [Test]
        public void AddChannelTest()
        {
            using (var db = new RadioContext())
            {
                playlistManager.AddPlaylist("TestPlaylist", db.Users.First(u => u.FirstName == "test" && u.Email == "test").UserId);
                Assert.DoesNotThrow(() =>db.PlayLists.Where(u => u.Name == "TestPlaylist").First());
            }
                
        }

        [TearDown]
        public void TearDown()
        {
            
            using (var db = new RadioContext())
            {
                PlayList testPlaylist = null;
                User userCheck = null;
                try
                {
                    testPlaylist = db.PlayLists.First(p => p.Name == "TestPlaylist");
                    userCheck = db.Users.First(u => u.FirstName == "test" && u.Email == "test");


                }
                catch(InvalidOperationException o) 
                { 
                    
                }
                if(testPlaylist != null && userCheck != null)
                {
                    db.Users.Remove(db.Users.First(u => u.FirstName == "test" && u.Email == "test"));
                    db.PlayLists.Remove(db.PlayLists.First(p => p.Name == "TestPlaylist"));
                }

                
                
            }
        }


    }
}
