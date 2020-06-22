using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnknownLib.Managers;

namespace LibTester
{
    class Program
    {
        static void Main(string[] args)
        {
            UnknownLib.Managers.LibraManager manager = new UnknownLib.Managers.LibraManager();

            string pass = "Kagemanden";

            string input = Console.ReadLine();
            string binary = manager.StringToBinary(input);
            Console.WriteLine(binary);

            string encrypted = manager.EncryptString(binary, pass);
            Console.WriteLine(encrypted);

            string decrypted = manager.DecryptString(encrypted, pass);
            Console.WriteLine(decrypted);

            string text = manager.BinaryStringToString(decrypted);
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
