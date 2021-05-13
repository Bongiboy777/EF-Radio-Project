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
using Radio;
using RadioDatabase;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InterMediateLayer;
namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for ManageChannels.xaml
    /// </summary>
    public partial class ManageChannels : Page
    {
        PlaylistManager PlaylistManager = new PlaylistManager();
        public ManageChannels()
        {
            InitializeComponent();
            PopulateFileList();
            BackToSettings.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new SettingsPage();
        }

        private void AddChannel(object sender, RoutedEventArgs e)
        {
            PlaylistManager.AddPlaylist(NameChannel.Text);
            Channels.Items.Add(new Button { Content = $"Channel {Channels.Items.Count + 1}" }); // Add new object
            
            

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
            string[] mediaFiles = Directory.GetFiles(PlaylistManager.mediaPaths[0], "*.*").Where(s => new string[] { ".wav", ".mp3" }.Contains(System.IO.Path.GetExtension(s))).ToArray();
            foreach (var item in mediaFiles)
            {
                files.Add(item.Replace(PlaylistManager.mediaPaths[0], ""), item);
                MusicFiles.Items.Add(item.Replace(PlaylistManager.mediaPaths[0], ""));
            }
            
        }

        public void PopulatePlayList(object sender, RoutedEventArgs e)
        {
            ChannelPlaylist.Items.Add(MusicFiles.SelectedItem);
            PlaylistManager.AddToPlaylist(NameChannel.Text, MusicFiles.SelectedItem as string);
        }


    }
}
