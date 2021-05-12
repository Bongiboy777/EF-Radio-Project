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
using Radio;
using RadioDatabase;
using System.Windows.Shapes;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        UserManager userManager = new UserManager();
        public LoginPage()
        {
            InitializeComponent();
            Login.Click += Verify;
        }

        public void Verify(object sender, RoutedEventArgs e)
        {
            if (userManager.VerifyUser(out string error, Password.Text, UserName.Text))
            {
                MainWindow.MainFrame.Content = new PlaylistPlayback();
            }

            MessageBox.Show(error);
           
        }
    }
}
