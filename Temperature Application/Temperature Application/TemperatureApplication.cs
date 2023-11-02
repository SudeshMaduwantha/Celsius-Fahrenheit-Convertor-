using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Temperature_Application
{
    public partial class TemperatureApplication : Form
    {
        public TemperatureApplication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*private object comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                if(float.TryParse(textBox1_GetInput.Text,out float celsius_value))
                {
                    float Calculated_Fahrenheit_Value = (celsius_value * 9 / 5) + 32;

                    MessageBox.Show($"Fahrenheit Value:{Calculated_Fahrenheit_Value}");

                }
                else
                {
                    MessageBox.Show($"Invalid Input. Please Enter Valid Number!!!");
                }
            }
            else if(comboBox1.SelectedIndex == 1) 
            {
                if(float.TryParse(textBox1_GetInput.Text,out float fahrenheight_value))
                {
                    float Calculated_Celsius_Value = (fahrenheight_value - 32) * 5 / 9;

                    MessageBox.Show($"Celsius Value:{Calculated_Celsius_Value}");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input . Please Enter A Valid Number!!!");
            }
        }
    }
}
 
