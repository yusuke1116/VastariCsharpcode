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
    public partial class Page6 : PhoneApplicationPage
    {
        
        PhotoChooserTask photoChooserTask;
      
        public Page6()
        {

            InitializeComponent(); 
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
        }
        private void Camera_roll(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Camera.xaml", UriKind.Relative)); 
        }
        private void Confirm(object sender, RoutedEventArgs e)
        {

        }

        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
            //    MessageBox.Show(e.ChosenPhoto.Length.ToString());

                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
           
                myImage.Source = bmp;
                
            //    PhoneApp2.ServiceReference1.Service1Client clients = new PhoneApp2.ServiceReference1.Service1Client();
             
            }
        }
    }
}