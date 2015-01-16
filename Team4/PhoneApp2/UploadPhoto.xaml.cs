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
        List<String> subitems2;
        public Page3()
        {
            InitializeComponent();
                items = new List<String>();
                items.Add("Fine Art");
                items.Add("Antiques");
                items.Add("Artefacts");
                items.Add("Design");
                items.Add("Memorabilia");
                items.Add("Currencies,Documents and Stamps");
                items.Add("Musical Intruments");
                items.Add("Natural Objects");
                items.Add("Miscellaneous");
        
             
            this.Category.ItemsSource = items;

            name = new List<String>();
            name.Add("Artistname");
           

            this.Artist.ItemsSource = name;
            

        

        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPhoto2.xaml", UriKind.Relative)); 
        }

    
        private void Change(object sender, SelectionChangedEventArgs e)
        {
            String item = (sender as ListPicker).SelectedItem.ToString();
             subitems = new List<String>();
             switch (item)
            {

                 case "Musical Intruments": 
                    break;
                case "Natural Objects":
                    subitems.Add("Fossils");
                    subitems.Add("Taxidermy");
                    subitems.Add("Microbiology");
                    subitems.Add("Geological ");
                    subitems.Add("Living specimens");
                    subitems.Add("Other");
                    break;
                case "Miscellaneous":      
                    break; 
                 case "Currencies,Documents and Stamps":
                    subitems.Add("Stamps");
                    subitems.Add("Coins");
                    subitems.Add("Notes");
                    subitems.Add("Letters");
                    subitems.Add("Documents");
                    subitems.Add("Other");
                    break;
                case "Memorabilia":
                    subitems.Add("Tourism & Travel");
                    subitems.Add("Costume & Outfits ");
                    subitems.Add("Entertainment");
                    subitems.Add("Ephemera");
                    subitems.Add("Medals");
                    subitems.Add("Miscellaneous");
                    break;         
                 case "Fine Art":
                   subitems.Add("Paintings");
                   subitems.Add("Drawings");
                   subitems.Add("Sculpture");
                   subitems.Add("Prints & Multiples");
                   subitems.Add("Photography");
                   subitems.Add("Video");
                   subitems.Add("Installation/Performance");
                   subitems.Add("Calligraphy");
                    break;
                case "Antiques":
                    subitems.Add("Ceramics");
                    subitems.Add("Furniture");
                    subitems.Add("Glassware");
                    subitems.Add("Silverware & Metalware");
                    subitems.Add("Horology");
                    subitems.Add("Textiles");
                    subitems.Add("Lighting");
                    break;
                case "Artefacts":
                    subitems.Add("Cultural & Religious Relics");
                    subitems.Add("Scientific Instruments");
                    subitems.Add("Arms & Armour"); 
                    break;
                case "Design":
                    subitems.Add("Fashion");
                    subitems.Add("Gems & Jewellery");
                    subitems.Add("Decorative Objects");
                    subitems.Add("Models");
                    subitems.Add("Furniture");
                    subitems.Add("Other");
                    break;      
            }
             this.Sub.ItemsSource = subitems;

             String subitem = Sub.SelectedItem.ToString();

             subitems2 = new List<String>();
             switch (subitem)
             {

                 case "Paintings":
                     subitems2.Add("Oil");
                     subitems2.Add("Acr");
                     subitems2.Add("Tempera");
                     subitems2.Add("Watercolour");
                     subitems2.Add("Mixed Media ");
                     subitems2.Add("Other");
                     break;

                 case "Drawings":
                     subitems2.Add("Charcoal");
                     subitems2.Add("Chalk");
                     subitems2.Add("Pastel");
                     subitems2.Add("Pencil");
                     subitems2.Add("Ink");
                     subitems2.Add("Other");
                     break;
                 case "Sculpture":
                     subitems2.Add("Bronze");
                     subitems2.Add("Marble");
                     subitems2.Add("Clay");
                     subitems2.Add("Alabaster");
                     subitems2.Add("Wood");
                     subitems2.Add("Aluminum");
                     subitems2.Add("Resin");
                     subitems2.Add("Glass");
                     subitems2.Add("Mixed Media ");
                     subitems2.Add("Other");
                     break;
                 case "Prints & Multiples":
                     subitems2.Add("Etching/Drypoint");
                     subitems2.Add("Engraving");
                     subitems2.Add("Woodcut");
                     subitems2.Add("Linocut");
                     subitems2.Add("Screenprint");
                     subitems2.Add("Lithography");
                     subitems2.Add("Mezzotint");
                     subitems2.Add("Aquatint");
                     subitems2.Add("Silk Aquatint");
                     subitems2.Add("Monoprint");
                     subitems2.Add("Foil imaging");
                     subitems2.Add("Other");
                     break;
                 case "Photography":
                     subitems2.Add("Giclée/Inkjet Print");
                     subitems2.Add("Dye destruction print");
                     subitems2.Add("Gelatin silver print");
                     subitems2.Add("LightJet print");
                     subitems2.Add("Albumen silver print");
                     subitems2.Add("Contact print");
                     subitems2.Add("Daguerrotype");
                     subitems2.Add("Type C-Print");
                     subitems2.Add("Silk Aquatint");
                     subitems2.Add("Sepia tone print");
                     subitems2.Add("Digital photography");
                     break;
                 case "Video":
                     subitems2.Add("Videotape/DVD");
                     subitems2.Add("Broadcast recordings");
                     subitems2.Add("Sculptural installation (i.e. monitor, TV set)");
                     subitems2.Add("Artists’ proof");
                     subitems2.Add("Digital file");
                     subitems2.Add("Other");
                     break;
                 case "Installation/Performance":
                     subitems2.Add("Plan/Drawings");
                     subitems2.Add("Photographic Evidence ");
                     subitems2.Add("Land Art");
                     subitems2.Add("Site-specific");
                     subitems2.Add("Conceptual");
                     subitems2.Add("Virtual Reality");
                     subitems2.Add("Interactive");
                     subitems2.Add("Other");
                     break;
                 case "Calligraphy":
                     subitems2.Add("Brush");
                     subitems2.Add("Felt-tip/ballpoint pen");
                     subitems2.Add("Bamboo pen");
                     subitems2.Add("Carving");
                     subitems2.Add("Other");
                     break;
                 case "Ceramics":
                     subitems2.Add("Porcelain");
                     subitems2.Add("Stoneware");
                     subitems2.Add("Earthenware");
                     subitems2.Add("Faience");
                     subitems2.Add("Other");
                     break;
                 case "Furniture":
                     subitems2.Add("Wood");
                     subitems2.Add("Bamboo");
                     subitems2.Add("Wicker/Rattan");
                     subitems2.Add("Metal");
                     subitems2.Add("Plastic");
                     subitems2.Add("Glass");
                     subitems2.Add("Electronics");
                     break;
                 case "Glassware":
                     subitems2.Add("Handblown");
                     subitems2.Add("Enamel");
                     subitems2.Add("Stained");
                     subitems2.Add("Murano");
                     subitems2.Add("Painted");
                     break;
                 case "Silverware & Metalware":
                     subitems2.Add("Sterling Silver");
                     subitems2.Add("Silver");
                     subitems2.Add("Gold");
                     subitems2.Add("Gold-plated");
                     subitems2.Add("Pewter");
                     subitems2.Add("Platinum");
                     subitems2.Add("Spelter");
                     subitems2.Add("Iron");
                     subitems2.Add("Other "); 
                     break;
                 case "Horology":
                     subitems2.Add("Mechanical Clocks");
                     subitems2.Add("Tallcase/Longcase");
                     subitems2.Add("Garniture/Framed Clocks");
                     subitems2.Add("Astronomical");
                     subitems2.Add("Water & Sun Clocks");
                     subitems2.Add("Chronometer");
                     subitems2.Add("Wristwatch");
                     subitems2.Add("Pocketwatch");
                     subitems2.Add("Other ");
                     break;
                 case "Textiles":
                     subitems2.Add("Tapestry");
                     subitems2.Add("Rug/Carpet");
                     subitems2.Add("Upholstery");
                     subitems2.Add("Textile");
                     break;
                 case "Lighting":
                     subitems2.Add("Candle");
                     subitems2.Add("Gas");
                     subitems2.Add("Electric");
                     subitems2.Add("Other");
                     break;
                 case "Cultural & Religious Relics":
                     subitems2.Add("Stone");
                     subitems2.Add("Wood");
                     subitems2.Add("Pottery");
                     subitems2.Add("Glass");
                     subitems2.Add("Shell");
                     subitems2.Add("Metal");
                     subitems2.Add("Other");
                     break;
                 case "Scientific Instruments":
                     subitems2.Add("Stone");
                     subitems2.Add("Wood");
                     subitems2.Add("Pottery");
                     subitems2.Add("Glass");
                     subitems2.Add("Metal");
                     subitems2.Add("Other");
                     break;
                 case "Arms & Armour":
                     subitems2.Add("Stone");
                     subitems2.Add("Wood");
                     subitems2.Add("Glass");
                     subitems2.Add("Metal");
                     subitems2.Add("Other");
                     break;
                 case "Fashion":
                     subitems2.Add("Garment");
                     subitems2.Add("Drawing/Croquis");
                     subitems2.Add("Documentation");
                     subitems2.Add("Photograph");
                     subitems2.Add("Shoes");
                     subitems2.Add("Accessories");
                     break;
                 case "Gems & Jewellery":
                     subitems2.Add("High");
                     subitems2.Add("Vintage");
                     subitems2.Add("Costume");
                     subitems2.Add("Other");
                     break;
                   
             }
             this.Sub2.ItemsSource = subitems2;
            
        }
       
           
    
        private void ADD(object sender, RoutedEventArgs e) {

           name.Add(Title_Copy.Text);
            this.Artist.ItemsSource = name;


        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }
    
    }
}