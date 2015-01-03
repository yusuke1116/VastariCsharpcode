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
    public partial class Page3 : PhoneApplicationPage
    {
        List<String> items;
        List<String> name;
        List<String> subitems;
        public Page3()
        {
            InitializeComponent();
                items = new List<String>();
                items.Add("ab");
                items.Add("cd");
                items.Add("ef");
             
            this.Category.ItemsSource = items;

            name = new List<String>();
            name.Add("Brian");
            name.Add("Ozge");
            name.Add("Yusuke san");

            this.Artist.ItemsSource = name;

         

        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPhoto2.xaml", UriKind.Relative)); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Change(object sender, SelectionChangedEventArgs e)
        {
            String item = (sender as ListPicker).SelectedItem.ToString();
             subitems = new List<String>();
             switch (item)
            {
                case "ab":
                   subitems.Add("op1");
                   subitems.Add("1.1");
                   subitems.Add("1.2");
                   subitems.Add("1.3");
                   subitems.Add("1.4");
                    break;
                case "cd":
                    subitems.Add("op2");
                    subitems.Add("2.1");
                    subitems.Add("2.2");
                    subitems.Add("2.3");
                    subitems.Add("2.4");
                    break;
                case "ef":
                    subitems.Add("op3");
                    subitems.Add("3.1");
                    subitems.Add("3.2");
                    subitems.Add("3.3");
                    subitems.Add("3.4");
                    break;
            }
            this.Sub.ItemsSource = subitems;

        }
        private void ADD(object sender, RoutedEventArgs e) {

           name.Add(Title_Copy.Text);
            this.Artist.ItemsSource = name;


        }
       



    }
}