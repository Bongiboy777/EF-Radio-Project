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
using InterMediateLayer;
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
            Return.Click += (object sender, RoutedEventArgs e) => MainWindow.MainFrame.Content = new LoginPage();
        }

        public void SubmitDetails(object sender, RoutedEventArgs e)
        {
            string message = null;
            if (Password.Password != ConfirmPassword.Password)
            {
                message += "Passwords must match.\n";
                
            }

            if (Password.Password.Length < minPasswordLength)
            {
               message += $"Password must be at least {minPasswordLength} characters long.\n";
               
            }

            
            if(message == null)
            {
                userManager.CreateUser(out string errorMessage, Firstname.Text, Lastname.Text, UserName.Text, Email.Text, Password.Password);
                message += errorMessage;
            }
            

            if (message == null || message == "")
            {
                MainWindow.MainFrame.Content = new LoginPage();
                return;
            }

            else MessageBox.Show(message);

        }
    }
}
