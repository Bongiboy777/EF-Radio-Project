using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using RadioApp;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for ManageChannels.xaml
    /// </summary>
    public partial class ManageChannels : Page
    {
        public ManageChannels()
        {
            InitializeComponent();
            PopulateFileList();
        }

        private void AddChannel(object sender, RoutedEventArgs e)
        {
            //if (NameChannel.Text != "" && NameChannel.Text != "NameChannel")
            //{
            //    Channels.Items.Add(new Button { Content = NameChannel.Text }); // Add new object
            //}
            //else
            //{
            //    Channels.Items.Add(new Button { Content = $"Channel {Channels.Items.Count + 1}" }); // Add new object
            //}

            Channels.Items.Add(new Button { Content = $"Channel {Channels.Items.Count + 1}" }); // Add new object
            //(Channels.Items[Channels.Items.Count - 1] as Button).Click += ChangeChannel; // Add click event change channel to this object


        }
        private void DeleteChannel(object sender, RoutedEventArgs e)
        {
            Channels.Items.Remove(Channels.SelectedItem as Button);
            for (int i = 0; i < Channels.Items.Count; i++)
            {
                Button tempButton = (Channels.Items[i] as Button);
                tempButton.Content = tempButton.Content.ToString().Contains("Channel") ? $"Channel {i + 1}" : tempButton.Content;
            }
        }

        private void Playback(object sender, RoutedEventArgs e)
        {
            
            MainWindow.RadioPlayer.UpdateChannels();
            this.NavigationService.Navigate(MainWindow.RadioPlayer);
        }

        public void PopulateFileList()
        {
            Dictionary<string, string> files = new Dictionary<string, string>();
            string[] mediaFiles = Directory.GetFiles(Radio.mediaPaths[0], "*.*").Where(s => new string[] {".wav",".mp3" }.Contains(System.IO.Path.GetExtension(s))).ToArray();
            foreach (var item in mediaFiles)
            {
                files.Add(item.Replace(Radio.mediaPaths[0], ""), item);
                MusicFiles.Items.Add(item.Replace(Radio.mediaPaths[0],""));
            }
        }

        public void PopulatePlayList(object sender, RoutedEventArgs e)
        {
            ChannelPlaylist.Items.Add(MusicFiles.SelectedItem);
        }

        
    }
}
