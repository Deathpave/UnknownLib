using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.TestEnvironment
{
    public class TestClass
    {
        private List<string> _pathNames;

        public TestClass()
        {
            _pathNames = new List<string>();
        }

        public void RecursiveMapping(string folderPath)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(folderPath))
                {
                    _pathNames.Add(dir);
                    try
                    {
                        foreach (string file in Directory.GetFiles(folderPath))
                        {
                            _pathNames.Add(file);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    RecursiveMapping(dir);
                }
            }
            catch
            {
            }
        }
    }
}
