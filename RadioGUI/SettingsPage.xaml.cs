using System;
using System.Collections.Generic;
using System.Linq;
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

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
            ManageChannels.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new ManageChannels();
            AccountSettings.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new AccountSettings();
            SearchDirectories.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new SearchDirectories();
            Return.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new PlaylistPlayback();
        }
    }
}

