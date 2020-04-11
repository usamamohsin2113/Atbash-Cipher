using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtbashCipherConsoleApplication
{
    class Atbash
    {
        //This method will be used to cipher or decipher the given value
        string EncrypterAndDecrypter(string value)
        {
            string encrypted = "";

            //Loop through each chracter in the given string
            foreach (char item in value)
            {
                if (item >= 65 && item <= 90)
                {
                    encrypted += (char)('Z' - item + 65);
                }
                else if (item >= 97 && item <= 122)
                {
                    encrypted += (char)('z' - item + 97);
                }
            }
            return encrypted;
        }


        // This method will take plain text and returns cipher of it
        public string Encrypt(string value)
        {
            return this.EncrypterAndDecrypter(value);
        }

        // This method will take cipher text and produce decipher of it
        public string Decrypt(string value)
        {
            return this.EncrypterAndDecrypter(value);
        }
    }
}
