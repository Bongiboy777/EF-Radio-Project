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
using InterMediateLayer;
using RadioDatabase;
using System.Windows.Shapes;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public static UserManager userManager = new UserManager();
        public static bool loggedIn;
        public LoginPage()
        {
            InitializeComponent();
            Login.Click += Verify;
            Register.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new Registration_Page();
        }

        public void Verify(object sender, RoutedEventArgs e)
        {
            if (userManager.VerifyUser(out string error, Password.Password, UserName.Text))
            {
                loggedIn = true;
                MainWindow.MainFrame.Content = new PlaylistPlayback();
                
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
