using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp2
{
    public partial class MenuPage : PhoneApplicationPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MyCollection(object sender, RoutedEventArgs e) //go to my collection
        {
            NavigationService.Navigate(new Uri("/Mycollection.xaml", UriKind.Relative));
        }

        private void Upload(object sender, RoutedEventArgs e) //go to upload object
        {
            NavigationService.Navigate(new Uri("/UploadPhoto2.xaml", UriKind.Relative));
        }

        private void Settings(object sender, RoutedEventArgs e) //go to settings
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }

        private void Logout(object sender, RoutedEventArgs e) //go to Mainpage
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Close(object sender, RoutedEventArgs e) //go back to current page
        {
            NavigationService.GoBack();
        }

       
    }
}