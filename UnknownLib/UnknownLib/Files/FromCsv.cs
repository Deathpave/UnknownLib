using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace UnknownLib.Files
{
    class FromCsv
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        List<string[]> result = new List<string[]>();

        public List<string[]> ListStringArraysFromCsv()
        {
            // lets user select the file to read
            fileDialog.ShowDialog();

            // checks if the selected file is valid
            if (fileDialog.FileName != null && fileDialog.FileName != string.Empty)
            {
                // creates a string array from the csv file
                string[] lines = File.ReadAllLines(fileDialog.FileName);
                foreach (string line in lines)
                {
                    // splits the lines in the string array
                    string[] splits = line.Split(',');
                    // adds the splitted line to the result list
                    result.Add(splits);
                }
                // returns the result list
                return result;
            }
            else
            {
                // returns null if the selected file is not valid
                return null;
            }
        }
    }
}
