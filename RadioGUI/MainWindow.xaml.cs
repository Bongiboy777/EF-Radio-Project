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
using Radio;
using RadioDatabase;

namespace RadioGUI
{
    public partial class MainWindow : Window
    {
        RadioPlayback radio;
        public static ManageChannels channelManager = new ManageChannels();
        public static PlaylistPlayback RadioPlayer = new PlaylistPlayback();
        public static Frame MainFrame { get; private set; } = new Frame();

        public MainWindow()
        {
           
            InitializeComponent();
            LoginPage loginPage = new LoginPage();
            Registration_Page registration_Page = new Registration_Page();

            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

          
            loginPage.Register.Click += (object sender, RoutedEventArgs e) => MainFrame.Content = registration_Page;

            MainFrame.Content = loginPage;
            Content = MainFrame;
        }

        public static void NavigatePage(int page)
        {
            switch(page)
            {
                case 0:
                    MainFrame.Content = new LoginPage();
                    break;
                    
            }
        }






    }
}
