using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtbashCipherConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value to be encrypted: ");
            string value = Console.ReadLine();

            string encryptedValue = Atbash.Encrypt(value);
            string decryptedValue = Atbash.Decrypt(encryptedValue);

            Console.WriteLine("Encrypted Text: " + encryptedValue);
            Console.WriteLine("Decrypted Text: " + decryptedValue);
        }
    }
}
