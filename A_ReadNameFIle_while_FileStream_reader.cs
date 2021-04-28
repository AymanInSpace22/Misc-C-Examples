using System;
using System.IO;

namespace ReadNameFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            // we added a try catch so that way the program does not catch
            try
            {
                // its the same as the WriteNewFile program
                // however here we use the filename we want to read, set filemode to open and fileaccess to read
                FileStream file = new FileStream("Names.txt", FileMode.OpenOrCreate, FileAccess.Read);
                // then we use the streamreader class because we are reading from a file
                StreamReader reader = new StreamReader(file);
                int count = 1;
                string name;

              

                
                Console.WriteLine("Diaplaying all names");
                name = reader.ReadLine();
                while (name != null)
                {
                    Console.WriteLine("" + count + " " + name);
                    // this is to continue reading in the names
                    name = reader.ReadLine();
                    // this is to keep track of the count
                    ++count;
                }

                reader.Close();
                file.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
