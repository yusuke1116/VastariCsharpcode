﻿using System;
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
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void MainPage(object sender, RoutedEventArgs e) //go to mainpage
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

     
    }
}