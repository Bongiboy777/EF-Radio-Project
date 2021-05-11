using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioApp;

namespace RadioGUI
{
    public partial class MainWindow : Window
    {
        Radio radio;
        public static ManageChannels channelManager = new ManageChannels();
        public static PlaylistPlayback RadioPlayer = new PlaylistPlayback();
        
   
        public MainWindow()
        {
            InitializeComponent();
            TopFrame.Content = new TopFramePage();
            MainFrame.Content = RadioPlayer;
        }

        

        
    }
}
