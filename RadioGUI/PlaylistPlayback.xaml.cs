using InterMediateLayer;
using System.Linq;
using System.Windows;
using WMPLib;
using WMPDXMLib;
using System.Windows.Data;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using AxWMPLib;

namespace RadioGUI
{

    /// <summary>
    /// Interaction logic for PlaylistPlayback.xaml
    /// </summary>
    public partial class PlaylistPlayback : Page
    {
        PlaylistManager playlistManager = new PlaylistManager();
        UserManager userManager = new UserManager();
        TrackManager TrackManager = new TrackManager();

        public PlaylistPlayback()
        {

            InitializeComponent();
            UpdateChannels();
            //MainWindow.radioPlayback.x.CurrentItemChange += TrackChange;
            WelcomeText.Text = LoginPage.loggedIn ? $"Hello {UserManager.User.GetFullName()}" : "Hello user";
            volumeslider.Value = MainWindow.radioPlayback.Volume != 50 ? MainWindow.radioPlayback.Volume : 50;
            //Binding binding = new Binding("currentPositionString") { Source = MainWindow.radioPlayback.x.controls, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.OneWay };
            //binding.IsAsync = true;
            //BindingOperations.SetBinding(volumedisplay, TextBox.TextProperty, binding);



            NextTrackButton.Click += (object sender, RoutedEventArgs e) => { MainWindow.radioPlayback.NextTrack(sender, e); UpdateChanneldisplay(); };
            PauseButton.Click += MainWindow.radioPlayback.TogglePause;
            PreviousTrackButton.Click += (object sender, RoutedEventArgs e) => { MainWindow.radioPlayback.PreviousTrack(sender, e); UpdateChanneldisplay(); };
            Channels.SelectionChanged += PopulateTrackList;

            Trackposition.Visibility = Visibility.Hidden;

            @return.Click += (object sender, RoutedEventArgs e) => { MainWindow.radioPlayback.Stop(); MainWindow.MainFrame.Content = new LoginPage(); };
        }
        

        public void UpdateChanneldisplay()
        {
            ChannelDisplay.Text = Channels.SelectedItem != null ? $"Playing {(Channels.SelectedItem as Button).Content as string} - {Tracklist.SelectedItem as string} ": "Playing track" ;
            
           


        }

        public void ToggleOnOff(object sender, RoutedEventArgs e)
        {
            if (TogglePower.IsChecked.Value == true)
            {

                MainWindow.radioPlayback.TurnOn();
                ChannelDisplay.Text = $"Choose channel";
            }
            else
            {
                MainWindow.radioPlayback.TurnOff();
                ChannelDisplay.Text = "";
            }
        }

        private void ChangeChannel(object sender, RoutedEventArgs e)
        {
            //Channels.SelectedItem = (Button)sender;
            if (MainWindow.radioPlayback.On)
            {
                //int channelNum = Int16.Parse((sender as Button).Content.ToString().Remove(0, 7));
                MainWindow.radioPlayback.Channel = 1;
                MainWindow.radioPlayback.PlayChannel((sender as Button).Content as string);
                if (MainWindow.radioPlayback.mediaPlayer.currentItem != null)
                {
                    ChannelDisplay.Text = MainWindow.radioPlayback.mediaPlayer.currentItem.name != null ? $"Playing {playlistManager.GetPlaylist((sender as Button).Content as string).Name} - {MainWindow.radioPlayback.mediaPlayer.currentItem.name}" : $"Playing { playlistManager.GetPlaylist((sender as Button).Content as string).Name}";

                }
                else { ChannelDisplay.Text = $"Playlist {(Channels.SelectedItem as Button).Content as string} empty."; }

            }

        }

        public void ChangeVolume(object v, RoutedPropertyChangedEventArgs<double> e)
        {
            int volume = (int)(v as Slider).Value;
            MainWindow.radioPlayback.Volume = volume;
            
        }

 

        

        private void GotoSettings(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SettingsPage());
        }

        public void UpdateChannels()
        {
            Channels.Items.Refresh();
            Channels.UpdateLayout();
            userManager.GetChannels(UserManager.User).Select(x => x.Name).ToList().ForEach(x =>
            { Channels.Items.Add(new Button { Content = x }); });

            foreach (Button b in Channels.Items)
            {
                b.Click += ChangeChannel;
            }
            Channels.SelectionChanged += PopulateTrackList;

        }

   
        public void PopulateTrackList(object sender, SelectionChangedEventArgs e)
        {
            Tracklist.Items.DetachFromSourceCollection();
            Tracklist.ItemsSource =  playlistManager.GetTracks(playlistManager.GetPlaylist((e.AddedItems[0] as Button).Content as string)).Select(z => z.Name);
            Tracklist.Items.Refresh();

            Tracklist.SelectionChanged += (object sender, SelectionChangedEventArgs e) => 
            {
                MainWindow.radioPlayback.mediaPlayer.URL =  TrackManager.GetTrack(e.AddedItems[0] as string).SourceURL;
                
                MainWindow.radioPlayback.Play();
                UpdateChanneldisplay();
                };

        }


    }
}
