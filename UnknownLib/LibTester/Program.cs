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
            string path = "C:\\Users\\MartinRiehnMadsen\\Desktop\\test.txt";
            string fill = "Kage er super godt";
            UnknownLib.Managers.LibraManager libManager = new UnknownLib.Managers.LibraManager();

            foreach (char c in libManager.CharsFromTxt(path))
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
