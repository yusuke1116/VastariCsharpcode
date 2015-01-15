using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Security.Cryptography;

namespace PhoneApp2
{
    public partial class Settings_ : PhoneApplicationPage
    {
        private static readonly byte[] entropy = { 1, 2, 3, 4, 1, 2, 3, 4 };

        public Settings_()
        {
            InitializeComponent();
        }

        private void Menu(object sender, RoutedEventArgs e) //goes to Menu
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void Home(object sender, RoutedEventArgs e) //goes to Login page (account summary)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

       

        private void Confirm(object sender, RoutedEventArgs e)
        {

            //add this---> if(OldPin==OldPin set on Main Page)
            //try{
                if ((NewPin.Text.Length < 4) || (NewPin.Text.Contains("."))) //checks if pincode consists of 4 digits
                {
                    MessageBox.Show("Please enter 4 characters.(Digits only!)");
                    return;
                }
                else
                {
                    if (NewPin.Text.Trim() != CNewPin.Text.Trim()) //checks if newpin=confirm newpin
                    {
                        MessageBox.Show("New Pin and Confirm Pin do not match!");
                        return;
                    }
                    else
                    {
                        
                        DataProtection readdata = new DataProtection();
                        byte[] ProtectedPinByte = readdata.ReadPinFromFile();
             
                        // Decrypt the PIN by using the Unprotect method.
                        // if I enter null or some byte, Unprotect method generates exception.
                        // return message is "The parameter is incorrect" 
                        byte[] PinByte = ProtectedData.Unprotect(ProtectedPinByte,null);
                        // Convert the PIN from byte to string 
                        string EncPincode = Encoding.UTF8.GetString(PinByte, 0, PinByte.Length);
                

                        if (OldPin.Text != EncPincode)
                        {
                            MessageBox.Show("Old pincode does not match!");
                            return;
                        }
                        else if (OldPin.Text == NewPin.Text)
                        {
                            MessageBox.Show("Old pincode eqauls New pincode!");
                            return;
                        }
                        else
                        {
                             DataProtection writedata = new DataProtection();
                             byte[] NewPinByte = Encoding.UTF8.GetBytes(NewPin.Text);
                             byte[] ProtectedNewPinByte = ProtectedData.Protect(NewPinByte, null);
                             writedata.WritePinToFile(ProtectedNewPinByte);
                            //this.WritePinToFile(ProtectedNewPinByte);
                            MessageBox.Show("You successfully changed your pincode!");
                            OldPin.Text = "";
                            NewPin.Text = "";
                            CNewPin.Text = "";
                        }
                    }
                }
            }
           
    }

}