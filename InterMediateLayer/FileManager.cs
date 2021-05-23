using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using RadioDatabase;
using WMPLib;
using System.Windows;
using WMPDXMLib;
using System.IO;
namespace InterMediateLayer
{
    public class FileManager
    {
        public static List<string> mediaPaths = new List<string>();
        public List<Track> GetAllAudioiles()
        {
            WindowsMediaPlayerClass helper = new WindowsMediaPlayerClass();
            List<Track> tracks = new List<Track>();
            using (var db = new RadioContext())
            {
                
                
                foreach (var item in mediaPaths)
                {
                    Directory.GetFiles(item, "*.*").Where(s => new string[] { ".wav", ".mp3" }.Contains(System.IO.Path.GetExtension(s))).ToList().ForEach(x =>
                    {
                        
                        tracks.Add(new Track() { SourceURL = x, Name = x.Replace(item, "")});
                    });
                }

                return tracks;
            }
                
            
        }

     
    }
}
