using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace LibTester
{
    class Program
    {
        /// <summary>
        /// This project is used for testing the library and its functions only
        /// It is not ment for running calculations a data edeting it self
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[] args)
        {
            UnknownLib.Managers.SecurityManager sec = new UnknownLib.Managers.SecurityManager();
            string a = "Kage er godt!";

        }
    }
}
