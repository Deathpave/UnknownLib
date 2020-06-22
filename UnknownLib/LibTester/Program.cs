using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTester
{
    class Program
    {
        static void Main(string[] args)
        {
            UnknownLib.Managers.LibraManager manager = new UnknownLib.Managers.LibraManager();
            Console.WriteLine("insert input, then password");
            string input = Console.ReadLine();
            string pass = Console.ReadLine();
            string encrypted = manager.EncryptString(input, pass);
            string plain = manager.DecryptString(encrypted, pass);
            Console.WriteLine(encrypted);
            Console.WriteLine(plain);
            Console.ReadLine();
        }
    }
}
