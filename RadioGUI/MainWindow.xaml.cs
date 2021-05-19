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
using System.Runtime.InteropServices;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WMPLib;
using WMPDXMLib;
using InterMediateLayer;
using RadioDatabase;

namespace RadioGUI
{
    public partial class MainWindow : Window
    {
        

        //public static UserManager sessioUserManager = new UserManager();
        //public static ManageChannels channelManager = new ManageChannels();
        ////public static PlaylistPlayback RadioPlayer = new PlaylistPlayback();
        public static Frame MainFrame { get; private set; } = new Frame();
        public static RadioPlayback radioPlayback = new RadioPlayback();


        public MainWindow()
        {
           
            InitializeComponent();
            radioPlayback.Volume = 50;
            
                MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

          

            MainFrame.Content = new LoginPage();
            Content = MainFrame;
        }

        public void changestate(object sender, _WMPOCXEvents_CurrentItemChangeEventHandler ex)
        {

        }

    






    }
}
