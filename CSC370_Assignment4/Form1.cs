//assignment 4 by jonathan yakimow

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC370_Assignment4
{
    public partial class Form1 : Form
    {
        string inputString = "";
        string outputString = "";
        int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void input_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //read value from textbox and assign to variable and conver to integer to do logical operations
                inputString = this.input_textBox.Text; 
                int input = int.Parse(inputString);
                total = input + total;

                //assign current total to to string and assign bottom textbox value
                outputString = total.ToString();
                this.output_textBox.Text = outputString;

                //reset values to prepare for more input
                inputString = "";
                this.input_textBox.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString());
                this.input_textBox.Text = "";
            }   
        }

        private void output_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //reset all variables to being empty like they would be in a fresh start of the program
            this.output_textBox.Text = "";
            this.input_textBox.Text = "";
            inputString = "";
            outputString = "";
            total = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
