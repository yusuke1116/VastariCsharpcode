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
using System.IO;
using System.Windows.Media.Imaging;

namespace Vastari
{
    public partial class Mycollection : PhoneApplicationPage
    {
        // Image stream variables
        private MemoryStream photoStream;
        private string fileName;
        // PhotoChooserTask definition
        PhotoChooserTask photoChooserTask;


        public Mycollection()
        {
            InitializeComponent();
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed +=    new EventHandler<PhotoResult>(OnPhotoChooserTaskCompleted);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        }
           // Called when an existing photo is chosen with the photo chooser.
        private void OnPhotoChooserTaskCompleted(object sender, PhotoResult e)
        {
      
            // Make sure the PhotoChooserTask is resurning OK
            if (e.TaskResult == TaskResult.OK)
            {
                // initialize the result photo stream
                photoStream = new MemoryStream();
                // Save the stream result (copying the resulting stream)
                e.ChosenPhoto.CopyTo(photoStream);
                // save the original file name
                fileName = e.OriginalFileName;
                // display the chosen picture
                var bitmapImage = new BitmapImage();
                bitmapImage.SetSource(photoStream);
                imgSelectedImage.Source = bitmapImage;
                // enable the upload button
                //btnUpload.IsEnabled = true;
            }
            else
            {
                // if result is not ok, make sure user can't upload
                //btnUpload.IsEnabled = false;
            }
    }
        private void Home(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void Upload(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPhoto.xaml", UriKind.Relative));
        }


    }
}