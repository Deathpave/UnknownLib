using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace UnknownLib.TestEnvironment
{
    public class TestClass
    {
        private List<string> _pathNames;
        private System.Timers.Timer _timer;
        private bool _running;

        public TestClass()
        {
            _pathNames = new List<string>();
            _timer = new System.Timers.Timer();
            _timer.Interval = 10000;
            _timer.Elapsed += _timer_Elapsed;
            _running = false;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _running = false;
        }

        public List<string> GetMapping()
        {
            if (!_running)
            {
                return _pathNames;
            }
            else
            {
                return null;
            }
        }

        public void RecursiveMapping(string folderPath)
        {
            _running = true;
            _timer.Stop();
            _timer.Start();
            try
            {
                Monitor.Enter(_pathNames);
                try
                {
                    foreach (string file in Directory.GetFiles(folderPath))
                    {
                        _pathNames.Add(file);
                    }
                }
                catch (Exception)
                {
                    Debug.WriteLine("File error");
                }
                foreach (string dir in Directory.GetDirectories(folderPath))
                {
                    _pathNames.Add(dir);

                    Thread t = new Thread(() => RecursiveMapping(dir));
                    t.Start();
                }
            }
            catch
            {
                Debug.WriteLine("Folder error");
                _timer.Stop();
            }
            finally
            {
                Monitor.Exit(_pathNames);
            }
        }
    }
}
