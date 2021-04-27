using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MoreWithFiles
{
    class Program
    {
        // StreamReader and StreamWriter reads and writes one line at a time
        // ReadAllLines reads all lines in a file
        // WriteAllLilnes is good too


        static void Main(string[] args)
        {
            string filePath = (@"C:\Users\boula\OneDrive\Documents\INFS 3400 OOP\test10.txt");
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Sue, Gillin, 16");
            File.WriteAllLines(filePath, lines);
        }
    }
}
