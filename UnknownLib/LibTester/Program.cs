using System;
using System.Collections.Generic;
using System.Linq;
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

            string[] test = new string[] { "kage,mand", "test,objekt" };

            manager.StringsToCsv(test);
        }
    }
}
