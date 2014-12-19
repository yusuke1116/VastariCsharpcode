using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace PhoneApp2
{
    public partial class PinCode : PhoneApplicationPage
    {
        public PinCode()
        {
            InitializeComponent();
        }

        private void txt_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length > 4)
            {
                txt.Text = txt.Text.Substring(0, 4);
                txt.SelectionStart = 4;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // using(IsolatedStorageFile isoStorage = IsolatedStorageFile.GetUserStoreForApplication())
            try
            {
                DataProtection readdata = new DataProtection();
                byte[] ReadProtectedPinByte = readdata.ReadPinFromFile();
                byte[] ReadPinByte = ProtectedData.Unprotect(ReadProtectedPinByte, null);
                string EncPincode = Encoding.UTF8.GetString(ReadPinByte, 0, ReadPinByte.Length);

                if (EncPincode == null)
                {
                    DataProtection writedata = new DataProtection();
                    byte[] PinByte = Encoding.UTF8.GetBytes(PinBox.Text);
                    byte[] ProtectedPinByte = ProtectedData.Protect(PinByte, null);
                    writedata.WritePinToFile(ProtectedPinByte);
                    MessageBox.Show("Your pincode is set!");
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                    return;
                }
                else
                {
                    if (EncPincode.CompareTo(PinBox.Text) == 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("pincode is unmatch");
                        return;
                    }
                }

                if (PinBox.Text.Length != 4 || PinBox.Text.Any(char.IsDigit) != true)
                {
                    MessageBox.Show("Error! Please enter a 4 digit code");
                    return;
                } 

                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative)); //Work Normally

                /*using (IsolatedStorageFileStream stream = isoStorage.OpenFile("pincode.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(PswdBox.Password);
                        MessageBox.Show("Success! Your pincode is set");
                        NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
                        writer.Close();
                    }
                }*/


            }
            catch (IsolatedStorageException)
            {
                MessageBox.Show("IsolatedStorageException");
                NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("ArgumentnullException");
            }
        }
    }
}