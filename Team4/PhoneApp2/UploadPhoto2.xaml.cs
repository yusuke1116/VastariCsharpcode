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
    public partial class Setting : PhoneApplicationPage
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Menu(object sender, RoutedEventArgs e) //goes to Menu
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void Home(object sender, RoutedEventArgs e) //goes back to Login page(account summary)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

   
        private void BacktoCollection(object sender, RoutedEventArgs e) //goes to My Collection
        {
            NavigationService.Navigate(new Uri("/MyCollection.xaml", UriKind.Relative));
        }

        private void Camera2(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Uri("/Camera2.xaml", UriKind.Relative));
        }

        private void Takeaphoto(object sender, RoutedEventArgs e) //goes to camera
        {
            NavigationService.Navigate(new Uri("/Camera.xaml", UriKind.Relative));
        }   

      
 
    }
}