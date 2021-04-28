using System;
using System.IO;

namespace CreateNameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // pass in file name, then create, then set the access to write
            FileStream file = new FileStream("Names.txt", FileMode.Create, FileAccess.Write);
            // this lets you write to the file
            StreamWriter writer = new StreamWriter(file);


            // here we are delcaring an arrary of names
            // also we made each of them padded with 10 spaces so we can use the Seek() method
            string[] names =   {"Anthony   " ,
                                "Belle     " ,
                                "Carolyn   " ,
                                "Edwin     " ,
                                "Frannie   " ,
                                "Gina      " ,
                                "Hannah    " ,
                                "Inez      " ,
                                "Juan      "};


            // loop through to write each name into the file
            int x;
            for(x = 0; x < names.Length; ++x)
            {
                writer.WriteLine(names[x]);
            }


            // you close them by the given variable
            // not by the FileStream or StreamWriter
            writer.Close();
            file.Close();
        }
    }
}
