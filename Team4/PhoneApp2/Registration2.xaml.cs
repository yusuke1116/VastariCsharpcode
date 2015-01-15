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
    public partial class Registration2 : PhoneApplicationPage
    {
        public Registration2()
        {
            InitializeComponent();
            var source = new List<String>();
            source.Add("Mr.");
            source.Add("Ms.");
            source.Add("Mrs.");
            source.Add("Dr");
            this.listPicker.ItemsSource = source;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registration.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            if (zip.Text == ""| FstName.Text == "" | LstName.Text == "" | Country.Text == "" | City.Text == "")
            {
                MessageBox.Show("Please fill the mandatory fields.");
                return;
            }
            else
            {
                NavigationService.Navigate(new Uri("/Registration3.xaml", UriKind.Relative));
            }
        }

        private void MainPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }
}