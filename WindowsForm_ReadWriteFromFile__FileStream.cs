using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsAppStreamReaderStreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // anytime you write to a file - you use create

         // doing it this way will save the file to the project you are currently in
            //FileStream fs = new FileStream("employee.txt", FileMode.Create, FileAccess.Write);

         // putting the '@' symbol allows you to use only one slash instead of two. Usually they wont let you put one slash so you must prefix the line with the '@' symbol
            // FileStream fs = new FileStream(@"C:\\users\boula\desktop\employee.txt", FileMode.Create, FileAccess.Write);

            saveFileDialog1.ShowDialog();
            //string path = pathTextBox.Text;
            string path = saveFileDialog1.FileName;
          
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write("Bob makes $10.00 per hour\nBill makes $12.00 per hour");


            // saveFileDialogBox is what we were using in the design portion to open file explorer




            // then close it
            // you have to make sure to close
            sw.Close();
            fs.Close();

        }
    }
}
