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
using System.IO;
using Microsoft.Win32;
using Ookii.Dialogs.Wpf;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InterMediateLayer;
namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for SearchDirectories.xaml
    /// </summary>
    public partial class SearchDirectories : Page
    {
        FileManager fileManager = new FileManager();
        public SearchDirectories()
        {
            InitializeComponent();
            ReturnToSettings.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new SettingsPage();
            AddDirectory.Click += AddSearchDirectory;
            SearchDirectoryList.ItemsSource = FileManager.mediaPaths;
        }

        public void PopulateSearchDirectories()
        {
            
        }

        public void AddSearchDirectory(object sender, RoutedEventArgs e)
        {
            VistaFolderBrowserDialog openFileDialog = new VistaFolderBrowserDialog() {Description= "Choose folder.", RootFolder=Environment.SpecialFolder.MyMusic, ShowNewFolderButton=true};
            if(openFileDialog.ShowDialog().Value)
            {
                
                FileManager.mediaPaths.Add(openFileDialog.SelectedPath);
                SearchDirectoryList.Items.Refresh();
            }
            
        }
    }
}
