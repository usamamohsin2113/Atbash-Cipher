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
            string value;
            Atbash ob = new Atbash();
            Console.Write("Enter value to be encrypted : ");
            value = Console.ReadLine();

            Console.WriteLine(ob.Encrypt(value));
            Console.WriteLine(ob.Decrypt(ob.Encrypt(value)));
        }
    }
}
