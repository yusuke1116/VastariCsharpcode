using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO.IsolatedStorage;
using System.IO;


namespace PhoneApp2
{

    class DataProtection
    {
        public byte[] ReadPinFromFile()
        {
            // Access the file in the application's isolated storage.
            IsolatedStorageFile readfile = IsolatedStorageFile.GetUserStoreForApplication();
            IsolatedStorageFileStream readstream = new IsolatedStorageFileStream("pincode.txt", System.IO.FileMode.Open, FileAccess.Read, readfile);

            // Read the PIN from the file.
            Stream reader = new StreamReader(readstream).BaseStream;
            byte[] pinArray = new byte[reader.Length];

            reader.Read(pinArray, 0, pinArray.Length);
            reader.Close();
            readstream.Close();

            return pinArray;
        }

        public void WritePinToFile(byte[] pinData)
        {
            // Create a file in the application's isolated storage.
            IsolatedStorageFile writefile = IsolatedStorageFile.GetUserStoreForApplication();
            IsolatedStorageFileStream writestream = new IsolatedStorageFileStream("pincode.txt", System.IO.FileMode.Create, System.IO.FileAccess.Write, writefile);

            // Write pinData to the file.
            Stream writer = new StreamWriter(writestream).BaseStream;
            writer.Write(pinData, 0, pinData.Length);
            writer.Close();
            writestream.Close();
        }

        private byte[] ReadOriginalPageFile()
        {
            // Access the file in the application's isolated storage.
            IsolatedStorageFile readfile = IsolatedStorageFile.GetUserStoreForApplication();
            IsolatedStorageFileStream readstream = new IsolatedStorageFileStream("originalpage.txt", System.IO.FileMode.OpenOrCreate, FileAccess.Read, readfile);

            // Read the PIN from the file.
            Stream reader = new StreamReader(readstream).BaseStream;
            byte[] pinArray = new byte[reader.Length];

            reader.Read(pinArray, 0, pinArray.Length);
            reader.Close();
            readstream.Close();

            return pinArray;
        }
      
    }
}
