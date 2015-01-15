using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PhoneApp2
{
    public partial class Registration3 : PhoneApplicationPage
    {

        
        public Registration3()
        {
            InitializeComponent();
            
            var source = new List<String>();
            source.Add("Avid Collector");
            source.Add("Leisurely Collector");
            source.Add("Scholar/Student");
            source.Add("Professional Collector");
            source.Add("Collector by inheritance");

            this.listPicker.ItemsSource = source;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registration2.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            if (Agree.IsChecked== true)
            {
                NavigationService.Navigate(new Uri("/Registration4.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("ERROR", "Please agree the terms & conditions.", MessageBoxButton.OK);
            }
            //NavigationService.Navigate(new Uri("/Registration4.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

       

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask wtb = new WebBrowserTask();
            wtb.Uri = new Uri("https://www.vastari.com/terms_conditions.aspx", UriKind.Absolute);
            wtb.Show(); 
        }

        private void HyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask wtb = new WebBrowserTask();
            wtb.Uri = new Uri("https://www.vastari.com/privacy_policy.aspx", UriKind.Absolute);
            wtb.Show(); 
        }

        
    }
}