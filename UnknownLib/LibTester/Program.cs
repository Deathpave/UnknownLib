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

            string input = Console.ReadLine();
            string binary = manager.StringToBinary(input);
            Console.WriteLine(binary);
            Console.WriteLine(manager.BinaryStringToString(binary));
            Console.ReadLine();
        }
    }
}
