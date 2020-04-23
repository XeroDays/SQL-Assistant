using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace SQL_Assistant
{
    class sysController
    {
        private static string keyFilePath = dbController.localPath + "//" + "init.si";

        public static void addDataTypes(ComboBox cmb)
        {
            cmb.Items.Add("int");
            cmb.Items.Add("nvarchar");
            cmb.Items.Add("datetime");
            cmb.Items.Add("image");
            cmb.Items.Add("bit");
            cmb.Items.Add("decimal");
        }

        public static void addItemToList(ListBox listbox,string item)
        {
            listbox.Items.Add(item);
        }
        
        public static string generateHashKey(string Owner,string username)
        {

            int ownerBit = addAllInteGers(Owner); 
            string usernameBit = convertToAscii(username).ToString();
           // int registryBit = convertToAscii(RegistrationName);
           

            string ownerCode = ownerBit + "0" + Owner.Length;
            string usernameCode = usernameBit;
            // string registryCode = registryBit + "0" + RegistrationName.Length;


            string Code = ownerCode + "-" + usernameCode;// + "-" + registryCode;
           // Console.WriteLine(Code);
            return Code;
        }

        public static int addAllInteGers(string code)
        {
            int codeBit = 0;
            int check;
            foreach (char ch in code) // owner is actually processor ID
            {
                if (int.TryParse(ch.ToString(), out check))
                {
                    codeBit += Convert.ToInt32(ch.ToString());
                }
            }

            return codeBit;
        }

        public static int convertToAscii(string line)
        {
            int asciiCode=0;
            foreach (char ch in line)
            {
                asciiCode += (int)ch;
            }
            return asciiCode;
        }

        public static void CheckCreatePath()
        {

            string filePath = Directory.GetParent("Parent").ToString();
            if (!Directory.Exists(filePath))
            Directory.CreateDirectory(filePath);
            
            if (!File.Exists(keyFilePath))
            {
                File.Create(keyFilePath).Close();
            }
            
        }

        public static void registered(string hashKey)
        {
            File.Create(keyFilePath).Close();
            string[] hashKey_part = hashKey.Split('-');
            int atPosition = addAllInteGers(hashKey_part[1]);
            Random ss = new Random();
            for (int i = 0; i < atPosition*5; i++)
            {
                if (i==atPosition)
                {
                    File.AppendAllText(keyFilePath, hashKey_part[1]+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText( keyFilePath, ss.Next(hashKey_part[1].Length,Convert.ToInt32(hashKey_part[1])).ToString() + Environment.NewLine);
                }
            }
            

        }

        public static bool checkIfRegistered()
        {
            if (!File.Exists(dbController.localPath))
            {
                DirectoryInfo folder = Directory.CreateDirectory(dbController.localPath);
            }

            int atPosition = addAllInteGers(convertToAscii(Environment.UserName).ToString());
            if (!File.Exists(keyFilePath))
            {
                return false;
            }
            string[] fileHashes = File.ReadAllLines(keyFilePath);
            if (!(fileHashes.Length >= atPosition) || fileHashes.Length == 0)
            {
                return false;
            }
            Console.WriteLine(atPosition + " file Lines "  + fileHashes.Length);
            Console.WriteLine( ">" +fileHashes[atPosition] + " == " + convertToAscii(Environment.UserName).ToString() + "<");
            if (fileHashes[atPosition] == convertToAscii(Environment.UserName).ToString())
            {
                return true;
            }
            else
            {
                return false;   
            }
        }


    }

   
}
