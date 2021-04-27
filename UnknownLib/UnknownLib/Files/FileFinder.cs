using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace UnknownLib.Files
{
    internal class FileFinder
    {
        private List<string> _pathNames;
        private System.Timers.Timer _timer;
        private bool _running;
        private List<string> res;
        public FileFinder()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = 5000;
            _timer.Elapsed += _timer_Elapsed;
            _running = false;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _running = false;
        }

        /// <summary>
        /// GetMapping returns the list of found file and or folder paths
        /// Deppending on what method has been runned
        /// Returns null while mapping is is in progress
        /// </summary>
        /// <returns></returns>
        public List<string> GetMapping()
        {
            if (!_running)
            {
                if (_pathNames.Count > 0)
                {
                    res = new List<string>(_pathNames);
                }
                _pathNames.Clear();
                return res;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// RecursiveMapping gets all files and sub folders from the starting path.
        /// This method can take long time to run depending on starting folder path.
        /// </summary>
        /// <param name="startFolderPath"></param>
        public void RecursiveMapping(string startFolderPath)
        {
            _running = true;
            _timer.Stop();
            try
            {
                Monitor.Enter(_pathNames);
                try
                {
                    foreach (string file in Directory.GetFiles(startFolderPath))
                    {
                        _pathNames.Add(file);
                    }
                }
                catch (Exception)
                {
                    Debug.WriteLine("File error");
                }
                foreach (string dir in Directory.GetDirectories(startFolderPath))
                {
                    _pathNames.Add(dir);

                    Thread t = new Thread(() => RecursiveMapping(dir));
                    t.Start();
                }
            }
            catch
            {
                Debug.WriteLine("Folder error");
                _timer.Start();
            }
            finally
            {
                Monitor.Exit(_pathNames);
                _timer.Start();
            }
        }

        public void FindFile(string filename, string startFolderPath = @"C:\")
        {
            _running = true;
            _timer.Stop();
            try
            {
                Monitor.Enter(_pathNames);
                try
                {
                    foreach (string file in Directory.GetFiles(startFolderPath))
                    {
                        if (file.ToLower().Contains(filename.ToLower()))
                        {
                            _pathNames.Add(file);
                        }
                    }
                }
                catch (Exception)
                {
                    Debug.WriteLine("File error");
                }
                foreach (string dir in Directory.GetDirectories(startFolderPath))
                {
                    Thread t = new Thread(() => FindFile(filename, dir));
                    t.Start();
                }
            }
            catch
            {
                Debug.WriteLine("Folder error");
                _timer.Start();
            }
            finally
            {
                Monitor.Exit(_pathNames);
                _timer.Start();
            }
        }
    }
}
