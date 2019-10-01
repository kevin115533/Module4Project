using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Author: Kevin Tran
 Class: ITD 1253
 Due Date: 10/2/2019
     
     */
namespace Module4Project

{
    public partial class frmDataTypes : Form

    {
        public frmDataTypes()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = " ";
        }

        private void BtnByte_Click(object sender, EventArgs e) // Adds the two variables
        {
            byte op1 = 8;
            byte op2 = 16;
            int result = op1 + op2;
            lblDisplay.Text = op1.ToString() + " + " + op2.ToString() + " = " + result.ToString();
            
        }

        private void BtnShort_Click(object sender, EventArgs e) // Subtracts the two variables
        {
            short op1 = 2453;
            short op2 = 3572;
            int result = op1 - op2;
            lblDisplay.Text = op1.ToString() + " - " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnInt_Click(object sender, EventArgs e) // Finds the modulus of the two variables
        {
            int op1 = 1468;
            int op2 = 23;
            int result = op1 % op2;
            lblDisplay.Text = op1.ToString() + " % " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnLong_Click(object sender, EventArgs e) // Multiplies the two variables
        {
            long op1 = 24676;
            long op2 = 23647;
            long result = op1 * op2;
            lblDisplay.Text = op1.ToString() + " * " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnDecimal_Click(object sender, EventArgs e) // Divides the two variables
        {
            decimal op1 = 1m;
            decimal op2 = 3m;
            decimal result = op1 / op2;
            lblDisplay.Text = op1.ToString() + " / " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnDouble_Click(object sender, EventArgs e) // Finds the modulus of the two variables
        {
            Double op1 = 32.2134325325254474235;
            Double op2 = 3.82635983259236574366;
            Double result = op1 % op2;
            lblDisplay.Text = op1.ToString() + " % " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnFloat_Click(object sender, EventArgs e) // Adds the two variables
        {
            float op1 = 5.65483665f;
            float op2 = 8.56541358f;
            float result = op1 + op2;
            lblDisplay.Text = op1.ToString() + " + " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnRound_Click(object sender, EventArgs e) // Rounds the variable
        {
            Double op1 = 54.235;
            Double result = Math.Round(op1);
            lblDisplay.Text = op1.ToString() + " rounds to " + result.ToString();
        }

        private void BtnPow_Click(object sender, EventArgs e) // Finds the power of the variables given
        {
            Double op1 = 23;
            Double op2 = 4;
            Double result = Math.Pow(op1, op2);
            lblDisplay.Text = op1.ToString() + " to the power of " + op2.ToString() + " is " + result.ToString();
        }

        private void BtnSqrt_Click(object sender, EventArgs e) // Finds the square root of the numbers
        {
            Double op1 = 81;
            Double result = Math.Sqrt(op1);
            lblDisplay.Text = "The square root of " + op1.ToString() + " is " + result.ToString();
        }
    }
}
