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
        private int minPasswordLength;
        public Registration_Page()
        {
            InitializeComponent();
            SubmitRegistration.Click += SubmitDetails;
        }

        public void SubmitDetails(object sender, RoutedEventArgs e)
        {
            if (Password.Text != ConfirmPassword.Text)
            {
                MessageBox.Show("Passwords must match");
                return;
            }

            else if (Password.Text.Length < minPasswordLength)
            {
                MessageBox.Show($"Password must be at least {minPasswordLength} characters long.");
                return;
            }

            else { userManager.CreateUser(out string errorMessage, Firstname.Text, Lastname.Text); }

        }
    }
}
