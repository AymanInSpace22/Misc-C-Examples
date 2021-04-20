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
            // also this send it to the default folder
            // you can define your own path
            // open it
            //FileStream fs = new FileStream("employee.txt", FileMode.Create, FileAccess.Write);
            // putting the '@' symbol allows you to use only one slash instead of two
            // typically they wont let you 

            saveFileDialog1.ShowDialog();
            //string path = pathTextBox.Text;
            string path = saveFileDialog1.FileName;
           // FileStream fs = new FileStream(@"C:\\users\boula\desktop\employee.txt", FileMode.Create, FileAccess.Write);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            // do stuff to it
            sw.Write("Bob makes $10.00 per hour\nBill makes $12.00 per hour");


            // saveFileDialogBox




            // then close it
            // you have to make sure to close
            sw.Close();
            fs.Close();

        }
    }
}
