using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageValues
{
    public partial class Form1 : Form
    {
        double integer;
        double sum = 0;
        double numIntegers = 0;
        double average;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            integer = Convert.ToDouble(integerInput.Text);

            if (integer != 0)
            {
                sum = sum + integer;
                numIntegers++;
                outputLabel.Text = $"{integer} was added to the sum";
            }
            else
            {
                average = sum / numIntegers;
                outputLabel.Text = $"The average of all number inputed is {average}";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            integerInput.Text = "";
        }
    }
}
