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
using System.IO.IsolatedStorage;
using System.IO;
using System.ServiceModel;
using System.Runtime.Serialization.Json;
using System.Xml;
using PhoneApp2.VastariAPI;



namespace PhoneApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void AboutUs(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutUS.xaml", UriKind.Relative));
        }

        private void Contact(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact.xaml", UriKind.Relative));
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void Login(object sender, RoutedEventArgs e)
        {

            if (UsrName.Text == "" | PswdBox.Password == "")
            {
                MessageBox.Show("Please fill the username and passwordbox");
            }
            else {
               try
               {
               
                    VastariAPIServiceClient client = new VastariAPIServiceClient();
                   //loginResponse response = new loginResponse();
                   //MessageBox.Show(response.Status);
                   client.LoginCompleted += new EventHandler<VastariAPI.LoginCompletedEventArgs>(clients_login_done);
                    
                    using (IsolatedStorageFile isoStorage = IsolatedStorageFile.GetUserStoreForApplication())
                    {
                        using (IsolatedStorageFileStream stream = isoStorage.OpenFile("pincode.txt", FileMode.Open))
                        {
                            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
                        }
                    }
               //     client.CloseAsync();
                }
                catch (IsolatedStorageException)
                {
                    MessageBox.Show("1st time Login", "Please set a 4 digit pincode.", MessageBoxButton.OK);
                    NavigationService.Navigate(new Uri("/PinCode.xaml", UriKind.Relative));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
               // NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
            }

            //MessageBox.Show("SET PINCODE","Please set a 4 digit pincode. *You will be asked to enter the code each time you re-open the app",MessageBoxButton.OK);
           
        }
       
        void clients_login_done(object sender, VastariAPI.LoginCompletedEventArgs e)
        {
            // Write message.
            MessageBox.Show("login success!");
            using (IsolatedStorageFile isoStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = isoStorage.OpenFile("pincode.txt", FileMode.Open))
                {
                    NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
                }
            }

        }

        void rtnJSON_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Error != null)
            {
                MessageBox.Show("network error!" + e.Error.Message);
                return;
            }
            MessageBox.Show(e.Result);
            StringReader sr = new StringReader(e.Result);
            Console.WriteLine(sr);
            //XmlReader xr = XmlReader.Create(sr);
            //SyndicationFeed sf = SyndicationFeed.Load(xr);

        }

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}