using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using UnknownLib.Managers;

namespace LibTester
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            UnknownLib.Managers.LibraManager manager = new UnknownLib.Managers.LibraManager();

            CarModel car = new CarModel();
            car.Color = "Red";
            car.Name = "Ford Focus";
            car.Year = 1995;
            car.NumberOfWheels = 4;

            object a = new { a = "cookie", b = "100 styks", c = "Pris", d = 20 };
            object b = (object)car;

            List<string> o = manager.ReadObject((object)car);
            foreach (string prop in o)
            {
                Console.WriteLine(prop);
            }

            Console.ReadLine();

        }
    }
}
