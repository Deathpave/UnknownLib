using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnknownLib.Files
{
    class ToCsv
    {
        SaveFileDialog SaveFileDialog = new SaveFileDialog();
        public bool StringsToCsv(string[] input)
        {
            SaveFileDialog.Filter = "*.csv|*.csv";
            // lets the user select where to save
            SaveFileDialog.ShowDialog();

            // checks if the filename is valid
            if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
            {
                // appends all lines in input array
                File.AppendAllLines(SaveFileDialog.FileName, input);

                return true;
            }

            return false;
        }

        public bool StringToCsv(string input)
        {
            SaveFileDialog.Filter = "*.csv|*.csv";
            // lets the user select where to save
            SaveFileDialog.ShowDialog();

            // checks if the filename is valid
            if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
            {
                // appends all lines in input array
                File.AppendAllText(SaveFileDialog.FileName, input + Environment.NewLine);

                return true;
            }

            return false;
        }
    }
}
