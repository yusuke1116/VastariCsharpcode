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
    public partial class Registration : PhoneApplicationPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)  //go to next page
        {
            //NavigationService.Navigate(new Uri("/Registration2.xaml", UriKind.Relative));
            if (UsrName.Text == "" | Email.Text == "" | ConEmail.Text == "" | Pswd.Text == "" | ConPswd.Text == "")
            {
                MessageBox.Show("Please fill all of the mandatory fields.");
                return;
            }
            if (UsrName.Text.Length < 6)
            {
                MessageBox.Show("Username must consist of 6 characters at least.");
                return;
            }

            if (Email.Text.Contains("@"))
            {
            }else{
                MessageBox.Show("E-mail should contain @.");
                return;
            }
            if (ConEmail.Text.Contains("@")){
            }
            else{
                MessageBox.Show("E-mail should contain @.");
                return;
            }

            //if (String.Equals(Email.Text.Trim(), ConEmail.Text.Trim()))
            if(Email.Text.Trim()!=ConEmail.Text.Trim())
            {
                MessageBox.Show("Error! E-mail and Confirm e-mail fields do not match!");
                return;
            }

            if (Pswd.Text.Length < 6)
            {
                MessageBox.Show("Password must consist of 6 character at least.");
                return;
            }

            if (ConPswd.Text.Length < 6)
            {
                MessageBox.Show("Password must consist of 6 character at least.");
                return;
            }

            if (Pswd.Text != ConPswd.Text)
            {
                MessageBox.Show("Error! Password and Confirm password do not match!");
                return;
            }

               NavigationService.Navigate(new Uri("/Registration2.xaml", UriKind.Relative));
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MainPage(object sender, RoutedEventArgs e) //go back to Mainpage
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

 
    }
}