using System;
using System.IO;

namespace outsideWindowsForm
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("test.txt")) 
            {
                // something code
                Console.WriteLine("File Exists");
                // file name must be in quotes
                Console.WriteLine("The file was created on {0}", File.GetCreationTime("test.txt"));

                Console.WriteLine("The file was last accessed on {0}", File.GetLastAccessTime("test.txt"));

                Console.WriteLine("The file was written to on {0}", File.GetLastWriteTime("test.txt"));
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

            string directoryName;
            string[] listOfFiles;
            if (Directory.Exists("Chapter14"))
            {
                Console.WriteLine("\nThe directory exists and it containes the follwoing files:");
                listOfFiles = Directory.GetFiles("Chapter14");
                foreach(string file in listOfFiles)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }
    }
}
