using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double Number1, Number2, Result; // declaration of variable of importance

        public Form1()
        {
            InitializeComponent();
        }

        //method to close the program 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to perform addition of two numbers from the textbox value objects
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UploadData(); // the upload data method is being called here
            Result = Number1 + Number2; // Evaluation the result i.e the addition of them both
            lblResult.Text = Result.ToString();
        }

        //funtion to help erase all text boxes after and arithmetic operation
        private void cLRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFirstValue.Text = " ";
            txtSecondValue.Text = " ";
            lblResult.Text = " ";
        }

        //method to easily import data from the textbox objects
        private void UploadData()
        {
            //an exception block to help handle errors 
            //like a user mistakenly using a text e.g "hello" in place of a number
            //to enable the code not to crash :)
            try
            {
                Number1 = Double.Parse(txtFirstValue.Text);
                Number2 = Double.Parse(txtSecondValue.Text);
            }
            catch (FormatException e)
            {
                txtFirstValue.Text = "";
                txtSecondValue.Text = "";
                lblResult.Text = "";
            }
        }

        //method to perfom substraction on two numbers from the textbox value objects
        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadData();
            Result = Number1 - Number2;
            lblResult.Text = Result.ToString();
        }

        //method to perfom division of two numbers
        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadData();
            Result = Number1 / Number2;
            lblResult.Text = Result.ToString();
        }

        //method to perfom multiplication of two numbers
        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadData();
            Result = Number1 * Number2;
            lblResult.Text = Result.ToString();
        }

        //method to perform power / exponential arithmetic operation
        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadData();
            Result = Math.Pow(Number1, Number2);
            lblResult.Text = Result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
