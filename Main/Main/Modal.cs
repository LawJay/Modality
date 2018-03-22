using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Main
{
    class Modal
    {
        int X;
        String cmd;
        String n;


        public Modal(int ID, String command, String name)
        {
            this.X = ID;
            this.cmd = command;
            this.n = name;

        }

        public void Load()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(path + "/Modality/" + @"\WriteLines.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    MessageBox.Show(line);                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
        public void Save()
        {
            string s = this.X.ToString();
            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { s, cmd, n };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // Set a variable to the My Documents path.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + "/Modality/" +  @"\" + n + ".modal"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
                //test
            }
        }
    }


}
