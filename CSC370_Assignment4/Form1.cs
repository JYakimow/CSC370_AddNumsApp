//add numbers app by Jonathan Yakimow
//for csc 370 with Dr. Locklair
//updated for Sprint 4 assignment 13

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
        string countOutput = "";
        int  resetStatus = 0;
        float total = 0;
        float lastTotal = 0;
        int count = 0;
        //float TempLastInput = 0;

        public Form1()
        {
            InitializeComponent();
            input_textBox.Focus();
            resetValues();
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
                float input = float.Parse(inputString);
                lastTotal = total;
                total = input + total;
                count++;

                //assign current total to to string and assign bottom textbox value
                outputString = total.ToString();
                this.output_textBox.Text = outputString;
                countOutput = count.ToString();
                this.counter_textBox.Text = countOutput;

                //reset values to prepare for more input
                prepForInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                //MessageBox.Show(ex.Message.ToString());
                this.errorLabel.Text = ex.Message.ToString();
                this.input_textBox.Text = "";
                input_textBox.Focus();
            }   
        }

        private void output_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void undo_buttton_Click(object sender, EventArgs e)
        {
            if (resetStatus == 1)
            {
                total = lastTotal;
                count--;
                countOutput = count.ToString();
                this.counter_textBox.Text = countOutput;
                outputString = total.ToString();
                this.output_textBox.Text = outputString;
                
                inputString = "";
                this.input_textBox.Text = "";
                this.errorLabel.Text = "";
                input_textBox.Focus();
                resetStatus = 0;
            }
            else 
            {
                input_textBox.Focus();
                this.errorLabel.Text = "";
                this.input_textBox.Text = "";
                inputString = "";
                MessageBox.Show("Cannot perform undo operation");
                //this.errorLabel.Text = "Cannot perform undo operation";
            }
        }

        private void prepForInput()
        {
            //reset values to prepare for more input
            inputString = "";
            this.input_textBox.Text = "";
            input_textBox.Focus();
            resetStatus = 1;
            this.errorLabel.Text = "";
        }

        private void resetValues()
        {
            //reset all variables to being empty like they would be in a fresh start of the program
            this.output_textBox.Text = "";
            this.input_textBox.Text = "";
            this.counter_textBox.Text = "";
            inputString = "";
            outputString = "";
            countOutput = "";
            this.errorLabel.Text = "";
            total = 0;
            count = 0;
            input_textBox.Focus();
            resetStatus = 0;
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use this app to add the weight of multiple shims together and keep track of the total number of shims. " +
                "Just type the value you wish to add into the top textbox and press the 'add' button. The total number of shims and the running total of all the weights" +
                " will be added to the 'total weight' field. If you made a mistake you can undo it by pressing the 'undo' button. If you wish to reset the app you can " +
                "press the 'reset' button.");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void printYourResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total weight of shims: " + outputString + "\n \n" + "Number of shims: " + countOutput);
            resetValues();
        }
    }
}