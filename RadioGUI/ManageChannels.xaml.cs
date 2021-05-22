using InterMediateLayer;
using RadioDatabase;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for ManageChannels.xaml
    /// </summary>
    public partial class ManageChannels : Page
    {
        PlaylistManager playlistManager = new PlaylistManager();
        UserManager userManager = new UserManager();
        FileManager fileManager = new FileManager();
        List<Track> mediaFiles = new List<Track>();

        public ManageChannels()
        {
            InitializeComponent();
            PopulateFileList();
            if (UserManager.User != null)
            {
                PopulateChannelList();
            }
            PauseButton.Click += MainWindow.radioPlayback.TogglePause;
            NextTrackButton.Click += MainWindow.radioPlayback.NextTrack;
            PreviousTrackButton.Click += MainWindow.radioPlayback.PreviousTrack;

            BackToSettings.Click += (object sender, RoutedEventArgs e) => { MainWindow.MainFrame.Content = new SettingsPage(); };
            volumeslider.Value = MainWindow.radioPlayback.Volume;
            volumedisplay.Text = MainWindow.radioPlayback.Volume.ToString();
            
        }

        private void AddChannel(object sender, RoutedEventArgs e)
        {
            string channelName = (NameChannel.Text == "" || NameChannel.Text == null) ? $"Channel {Channels.Items.Count + 1}" : NameChannel.Text;
            playlistManager.AddPlaylist(NameChannel.Text);
            Channels.Items.Add(channelName); // Add new object


        }


        private void DeleteChannel(object sender, RoutedEventArgs e)
        {
            Channels.Items.Remove(Channels.SelectedItem as Button);
           
        }

        public void PopulateFileList()
        {

            mediaFiles = fileManager.GetAllAudioiles();
            foreach (var item in mediaFiles)
            {
                MusicFiles.Items.Add(item.Name);
            }

        }

        public void PopulateChannelList()
        {

            userManager.GetChannels(UserManager.User).Select(x => x.Name).ToList().ForEach(x => Channels.Items.Add(x));


            Channels.SelectionChanged += DisplayChannelData;
        }

        public void DisplayChannelData(object sender, SelectionChangedEventArgs e)
        {
            PlayList selectedPlaylist = playlistManager.GetPlaylist(e.AddedItems[0] as string);
            ChannelPlaylist.Items.Clear();
            playlistManager.GetTracks(selectedPlaylist)
                .ForEach(x =>
                {
                    ChannelPlaylist.Items.Add(x.Name);
                }
                );

            PlaylistInfoName.Text = selectedPlaylist.Name;
            playlistInfo.Text = $"Date Created: {selectedPlaylist.DateCreated}\nGenre: {selectedPlaylist.Genre}";


        }

        public void PopulatePlayList(object sender, RoutedEventArgs e)
        {
            Songinforname.Text = MusicFiles.SelectedItem as string;
            if (!ChannelPlaylist.Items.Contains(MusicFiles.SelectedItem))
            {
                ChannelPlaylist.Items.Add(MusicFiles.SelectedItem);



            }

            if (Channels.SelectedItem != null)
            {
                Track selectedTrack = mediaFiles.First(x => x.Name.Contains(MusicFiles.SelectedItem as string));
                playlistManager.AddToPlaylist(Channels.SelectedItem as string, selectedTrack);
                Songinfo.Text = $"{selectedTrack.Name}\nGenre: None.\nArtist: {selectedTrack.Artist}.";

            }



        }

        public void ChangeVolume(object v, RoutedPropertyChangedEventArgs<double> e)
        {
            int volume = (int)(v as Slider).Value;
            MainWindow.radioPlayback.Volume = volume;
        }


    }
}
