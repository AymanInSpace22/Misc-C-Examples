using System;
using System.IO;
using static System.Console;

namespace StringReaderStringWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "fruit.txt";
                int count = 0;
                // to see file - find your project foler - click on foler - bin - debug - then you should see the file you created
                // putting true aft fruit.text appends to it (adds or double it)
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine("Apple");
                    sw.WriteLine("Strawberry");
                    sw.WriteLine("Orange");
                    sw.WriteLine("Pear");
                    // when working with data bases -- three main parts
                    // connencting to file, doing something to file, then close the file
                    sw.Close();
                }



                // this is reading the file
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream) // while not at the end of my file
                    {
                        Console.WriteLine(sr.ReadLine());
                        count++;
                    }

                    Console.WriteLine($"Total number of line: {count}");
                   // sr.Close();
                }
                int lines = File.ReadAllLines(fileName).Length;
                Console.WriteLine($"Total number of lines: {lines}");
            }
            
            catch(FileNotFoundException ex)
            {
                WriteLine("The file does not exist. Please contact IT\n" + ex.Message);
            }
            catch(IOException ex)
            {
                WriteLine("Error with file input/output.\nErrot:" + ex.Message);
            }
            catch (Exception ex)
            {

                WriteLine("Error: " +ex.Message);
            }
        }
    }
}
