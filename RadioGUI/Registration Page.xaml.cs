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
using Radio;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for Registration_Page.xaml
    /// </summary>
    public partial class Registration_Page : Page
    {
        UserManager userManager = new UserManager();
        private int minPasswordLength = 7;
        public Registration_Page()
        {
            InitializeComponent();
            Submit.Click += SubmitDetails;
        }

        public void SubmitDetails(object sender, RoutedEventArgs e)
        {
            string message = null;
            if (Password.Text != ConfirmPassword.Text)
            {
                message += "Passwords must match.\n";
                
            }

            if (Password.Text.Length < minPasswordLength)
            {
               message += $"Password must be at least {minPasswordLength} characters long.\n";
                return;
            }

            if(message != null)
            {
                MessageBox.Show(message);
            }

            else { userManager.CreateUser(out string errorMessage, Firstname.Text, Lastname.Text); }
            MainWindow.MainFrame.Content = new LoginPage();

        }
    }
}
