using System;

namespace KeyGen
{
     class syscontroller
    {

        public static string generateHashKey(string Owner, string username)
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

        private static int addAllInteGers(string code)
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

        private static int convertToAscii(string line)
        {
            int asciiCode = 0;
            foreach (char ch in line)
            {
                asciiCode += (int)ch;
            }
            return asciiCode;
        }
    }
}