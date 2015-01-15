using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp2.Resources;


namespace PhoneApp2
{
    public partial class Login : PhoneApplicationPage
    {
        // Constructor
        public Login()
        {
            InitializeComponent();
  
        }

        private void Menu(object sender, RoutedEventArgs e) //goes to Menu page
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void Home(object sender, RoutedEventArgs e) //goes back to Home page (Account Summary)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void Upload(object sender, RoutedEventArgs e) //go to upload photo
        {
            NavigationService.Navigate(new Uri("/UploadPhoto.xaml", UriKind.Relative));
        }
     
    }
}