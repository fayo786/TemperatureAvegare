using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //EXIT BUTTON EVENT
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //AVERAGE BUTTON EVENT (MAIN FUNCTION)
        private void averageButton_Click(object sender, EventArgs e)
        {
            decimal COUNTER = 5;
            decimal averageTemperature;

            decimal doMonday = numericUpDown1.Value;
            decimal doTuesday = numericUpDown2.Value;
            decimal doWednesday = numericUpDown3.Value;
            decimal doThursday = numericUpDown4.Value;
            decimal doFriday = numericUpDown5.Value;

            decimal total = doMonday + doThursday + doTuesday + doWednesday + doFriday;

            averageTemperature = total / COUNTER;

            if (doMonday <= doTuesday && doTuesday <= doWednesday && doWednesday <= doThursday && doThursday <= doFriday)
            {
                MessageBox.Show("Getting warmer :" + Convert.ToString(averageTemperature));
            }
            else if (doMonday >= doTuesday && doTuesday >= doWednesday && doWednesday >= doThursday && doThursday >= doFriday)
            {
                MessageBox.Show("Getting cooler :" + Convert.ToString(averageTemperature));
            }
            else
            {
                MessageBox.Show("It's a mixed bag :" + Convert.ToString(averageTemperature));
            }

        }
        // I WAS TRYING TO RESTRICT USER INPUT EVENT - I ADDED REFERENCES, BUT IT DID NOT WORK
        /*private void numericUpDown1_ValueChanged(Object sender, EventArgs e)
        {

            if (numericUpDown1.Value >= 130 || numericUpDown1.Value <= -30)
            {
                MessageBox.Show("You enter an invalid value, must be between -30 and 130");
            }

        }
        
        private void numericUpDown2_ValueChanged(Object sender, EventArgs e)
        {
            decimal doMonday = numericUpDown1.Value;

            if (doMonday >= 130 || doMonday <= -30)
            {
                MessageBox.Show("You enter an invalid value, must be between -30 and 130");
            }

        }

        private void numericUpDown3_ValueChanged(Object sender, EventArgs e)
        {
            decimal doMonday = numericUpDown1.Value;

            if (doMonday >= 130 || doMonday <= -30)
            {
                MessageBox.Show("You enter an invalid value, must be between -30 and 130");
            }

        }
        private void numericUpDown4_ValueChanged(Object sender, EventArgs e)
        {
            decimal doMonday = numericUpDown1.Value;

            if (doMonday >= 130 || doMonday <= -30)
            {
                MessageBox.Show("You enter an invalid value, must be between -30 and 130");
            }

        }

        private void numericUpDown5_ValueChanged(Object sender, EventArgs e)
        {
            decimal doMonday = numericUpDown1.Value;

            if (doMonday >= 130 || doMonday <= -30)
            {
                MessageBox.Show("You enter an invalid value, must be between -30 and 130");
            }

        }*/

    }
}


