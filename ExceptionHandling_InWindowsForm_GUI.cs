using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHanldingWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double miles;  // to hold miles driven
                double gallons;  // to hold gallons used
                double mpg; // to hold MPG

                miles = double.Parse(milesTextBox.Text);    // assigning our values from our text boxes
                gallons = double.Parse(gallonsTextBox.Text);    // instead of ReadLine()
                mpg = miles / gallons;

                mpgLabel.Text = mpg.ToString();
            }
            catch (Exception ex) // you dont have to have Exception ex since we built our own message
            {
                // this allows you to display a message on screen
                // basically adds an extra text box on screen
                MessageBox.Show("Invalid data entered, please check the value");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // we just close the form here
            // because it is the exit button
            this.Close();
        }
    }
}
