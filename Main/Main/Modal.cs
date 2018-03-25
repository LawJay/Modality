using System;
using System.Collections;
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
        string t;
        public static ArrayList modals = new ArrayList();


        public Modal(int ID, String command, String name, String type)
        {
            this.X = ID;
            this.cmd = command;
            this.n = name;
            this.t = type;

        }

        public string Load(String filePath)
        {
            string line = File.ReadLines(filePath).Skip(0).Take(1).First();
            string line2 = File.ReadLines(filePath).Skip(1).Take(1).First();
            string line3 = File.ReadLines(filePath).Skip(2).Take(1).First();
            string line4 = File.ReadLines(filePath).Skip(3).Take(1).First();
            int idline = Int32.Parse(line);
            Modal m = new Modal(idline, line2, line3, line4);
            m.Execute(m);
            
            return null;

        }
        public void Save()
        {
            string s = this.X.ToString();
            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { s, cmd, n, t };
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
        public void Execute(Modal m)
        {

            

        }

        
    }


}
