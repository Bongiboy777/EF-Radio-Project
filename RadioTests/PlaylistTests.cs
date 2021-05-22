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
        [SetUp]
        public void Setup()
        {
            playlistManager = new PlaylistManager();
            User testUser = new User() {FirstName="test", LastName="test" };
        }

        [Test]
        public void AddChannelTest()
        {
            using (var db = new RadioContext())
            {
                playlistManager.AddPlaylist("Zachariah");
                Assert.DoesNotThrow(() =>db.PlayLists.Where(u => u.Name == "Zachariah").First());
            }
                
        }

        [TearDown]
        public void TearDown()
        {
            
            using (var db = new RadioContext())
            {
                PlayList testPlaylist = null;
                try
                {
                    testPlaylist = db.PlayLists.First(p => p.Name == "TestPlaylist");
                }
                catch(InvalidOperationException o) 
                { 
                    
                }
                if(testPlaylist != null)
                {
                    db.PlayLists.Remove(db.PlayLists.First(p => p.Name == "TestPlaylist"));
                }
                
            }
        }


    }
}
