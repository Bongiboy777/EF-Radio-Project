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
using InterMediateLayer;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for AccountSettings.xaml
    /// </summary>
    public partial class AccountSettings : Page
    {
        public AccountSettings()
        {
            InitializeComponent();
            Return.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new SettingsPage();
            if(UserManager.User != null)
            {
                Firstname.Text = UserManager.User.FirstName;
                Lastname.Text = UserManager.User.LastName;
                Email.Text = UserManager.User.Email;
                UserName.Text = UserManager.User.Username;
                Firstname.Text = UserManager.User.FirstName;
                Firstname.Text = UserManager.User.FirstName;
            }
        }
    }
}
