using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RadioApp;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for PlaylistPlayback.xaml
    /// </summary>
    public partial class PlaylistPlayback : Page
    {
        Radio radio;
        public PlaylistPlayback()
        {
            InitializeComponent();
            radio = new Radio();
            volumeslider.Value = 50;
            
        }

        public void ToggleOnOff(object sender, RoutedEventArgs e)
        {
            if (TogglePower.IsChecked.Value == true)
            {
                radio.TurnOn();
                ChannelDisplay.Text = $"Channel {radio.Channel}";
            }
            else
            {
                radio.TurnOff();
                ChannelDisplay.Text = "";
            }
        }

        private void ChangeChannel(object sender, RoutedEventArgs e)
        {
            //Channels.SelectedItem = (Button)sender;
            if (radio.On)
            {
                int channelNum = Int16.Parse((sender as Button).Content.ToString().Remove(0, 7));
                radio.Channel = channelNum;
                ChannelDisplay.Text = $"{radio.Play()}";
            }

        }

        public void ChangeVolume(object v, RoutedPropertyChangedEventArgs<double> e)
        {
            int volume = (int)(v as Slider).Value;
            radio.Volume = volume;
        }

        private void PlaybackControls(object sender, RoutedEventArgs e)
        {
            string input = (sender as Button).Content.ToString();
            radio.Playback(input);
            
        }

        private void ManageChannels(object sender, RoutedEventArgs e)
        {
            MainWindow.channelManager.Channels.Items.Refresh();
            
            MainWindow.channelManager.Channels.UpdateLayout();
            this.NavigationService.Navigate(MainWindow.channelManager);
        }

        public void UpdateChannels()
        {
            Channels.Items.Refresh();
            Channels.UpdateLayout();
            Channels.ItemsSource = MainWindow.channelManager.Channels.Items;
            foreach (Button b in Channels.Items)
            {
                b.Click += ChangeChannel;
            }
            
        }
    }
}
