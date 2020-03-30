using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Variables
            int counter = 0;
            
            listBox43.Items.Clear(); // Clears box on each click

            for (int i = 1; i <= 1000000; i++) // while below or equal to 1000000
            {
                if (i % 43 == 0) // we find every number that is true to the if statment
                {
                    listBox43.Items.Add(i); // adds the value of i to lixtbox
                    counter++; // adds 1 to counter every time the if statement is true
                }
            }
            labelResult.Text = $"How many times did [ x % 43 = 0 ]:\n{counter}"; // using the counter we can see how many times above if statement is true
        }
    }
}
