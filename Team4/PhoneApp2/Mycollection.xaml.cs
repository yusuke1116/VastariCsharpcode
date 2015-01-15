using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp2.ViewModels;
using PhoneApp2.Services;
using PhoneApp2.Models;

namespace PhoneApp2
{
    public partial class MyCollection : PhoneApplicationPage
    {
        public MyCollection()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(MyCollectionLoaded);
            var viewModel = new PhotosViewModel();
            DataContext = viewModel;
        }

        private void MyCollectionLoaded(object sender, RoutedEventArgs e)
        {
            var viewModel = new PhotosViewModel();
             DataContext = viewModel;

           scroll.ScrollTo(scroll.ItemsSource[scroll.ItemsSource.Count - 1]);
        }



        private void Undo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void layout_LayoutUpdated_1(object sender, EventArgs e)
        {

        }

        private void layout_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void Scroll_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}