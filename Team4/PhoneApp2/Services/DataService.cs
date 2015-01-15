using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp2.Models;
using System.IO;


namespace PhoneApp2.Services
{
    public static class DataService
    {
        public static List<Photo> GetPhotos()
        {
            List<Photo> imageList = new List<Photo>();
            for (int i = 1; i <= 10; i++)//With api, a Json Object will be received and therefore the uri from ImageSource needed to be change. So as the title.
            {
                Photo imageData = new Photo()
                {
                    ImageSource = new Uri(String.Format("/Assets/samplePic/{0}.jpg", i), UriKind.Relative),
                    Title = i.ToString(),
                    catagory = "MyCollection"
                };

                imageList.Add(imageData);
            }

            return imageList;
        }
    }
}
