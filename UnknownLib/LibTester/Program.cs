using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using UnknownLib.Hooks;
using UnknownLib.Managers;
using UnknownLib.TestEnvironment;

namespace LibTester
{
    class Program
    {
        /// <summary>
        /// This project is used for testing the library and its functions only
        /// It is not ment for running calculations or data edeting it self
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            Console.WriteLine("This process may take some time depending on the amount of files on your pc");
            //tc.RecursiveMapping(@"C:\Uniconta\PluginPath\fr");
            tc.FindFile("dev", @"C:\Uniconta\PluginPath");

            while (tc.GetMapping() == null)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Checking if mapping is done");
            }
            Console.WriteLine("Mapping is done!");
            foreach (string line in tc.GetMapping())
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
