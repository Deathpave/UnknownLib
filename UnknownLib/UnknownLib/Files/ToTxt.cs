using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnknownLib.Files
{
    class ToTxt
    {
        SaveFileDialog SaveFileDialog = new SaveFileDialog();
        public bool StringToTxt(string input)
        {
            try
            {
                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // overrides the file with the input text
                    File.WriteAllText(SaveFileDialog.FileName, input);

                    // if the file has been written, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written, but without errors, returns false
                    return false;
                }
            }
            catch (Exception e)
            {
                // if the method has/gets an error returns false
                return false;
            }
        }

        public bool AppendStringToTxt(string input)
        {
            try
            {

                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // appends the string input to the text file
                    File.AppendAllText(SaveFileDialog.FileName, input);

                    // if the file has been written to, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written to, but without errors, return false
                    return false;
                }

            }
            catch (Exception e)
            {
                // if the mthod has/gets an error return false
                return false;
            }
        }

        public bool StringsToTxt(string[] input)
        {
            try
            {
                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // overrides the file with the input strings
                    File.WriteAllLines(SaveFileDialog.FileName, input);

                    // if the file has been written to, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written to, but without errors, return false
                    return false;
                }
            }
            catch (Exception e)
            {
                // if the mthod has/gets an error return false
                return false;
            }
        }

        public bool AppendStringsToTxt(string[] input)
        {
            try
            {
                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // appends input strings to file 
                    File.AppendAllLines(SaveFileDialog.FileName, input);

                    // if the file has been written to, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written to, but without errors, return false
                    return false;
                }
            }
            catch (Exception e)
            {
                // if the mthod has/gets an error return false
                return false;
            }
        }

        public bool CharToTxt(char input)
        {
            try
            {
                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // overrides the file with the input char
                    File.WriteAllText(SaveFileDialog.FileName, input.ToString());

                    // if the file has been written, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written, but without errors, returns false
                    return false;
                }
            }
            catch (Exception e)
            {
                // if the method has/gets an error returns false
                return false;
            }
        }

        public bool AppendCharToTxt(string path, char input)
        {
            try
            {

                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // appends the char input to the text file
                    File.AppendAllText(SaveFileDialog.FileName, input.ToString());

                    // if the file has been written to, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written to, but without errors, return false
                    return false;
                }

            }
            catch (Exception e)
            {
                // if the mthod has/gets an error return false
                return false;
            }
        }

        public bool CharsToTxt(char[] input)
        {
            try
            {
                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                List<string> sInput = new List<string>();
                foreach (char c in input)
                {
                    sInput.Add(c.ToString());
                }

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // overrides the file with the input chars
                    File.WriteAllLines(SaveFileDialog.FileName, sInput));

                    // if the file has been written to, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written to, but without errors, return false
                    return false;
                }
            }
            catch (Exception e)
            {
                // if the mthod has/gets an error return false
                return false;
            }
        }

        public bool AppendCharsToTxt(string path, char[] input)
        {
            try
            {
                // only shows .txt files to the user
                SaveFileDialog.Filter = "*.txt|*.txt";

                // lets the user select where to save
                SaveFileDialog.ShowDialog();

                List<string> sInput = new List<string>();
                foreach (char c in input)
                {
                    sInput.Add(c.ToString());
                }

                // checks if the filename is valid
                if (SaveFileDialog.FileName != null && SaveFileDialog.FileName != string.Empty)
                {
                    // appends the chars to the file
                    File.AppendAllLines(SaveFileDialog.FileName, sInput);

                    // if the file has been written to, returns true
                    return true;
                }
                else
                {
                    // if the file havent been written to, but without errors, return false
                    return false;
                }
            }
            catch (Exception e)
            {
                // if the mthod has/gets an error return false
                return false;
            }
        }

    }
}
