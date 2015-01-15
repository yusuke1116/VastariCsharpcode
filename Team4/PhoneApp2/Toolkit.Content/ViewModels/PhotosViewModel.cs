using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp2.Helpers;
using PhoneApp2.Models;
using PhoneApp2.Services;

namespace PhoneApp2.ViewModels
{
    class PhotosViewModel
    {
        public List<KeyedList<string, Photo>> GroupedPhotos
        {
            get
            {
                var photos = DataService.GetPhotos();

                var groupedPhotos =
                    from photo in photos
                    orderby photo.Title
                    group photo by photo.catagory into cat
                    select new KeyedList<string, Photo>(cat);

                return new List<KeyedList<string, Photo>>(groupedPhotos);
            }
        }
    }
}
