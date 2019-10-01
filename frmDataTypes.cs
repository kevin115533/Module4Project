using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void BtnByte_Click(object sender, EventArgs e)
        {
            byte op1 = 8;
            byte op2 = 16;
            int result = op1 + op2;
            lblDisplay.Text = op1.ToString() + " + " + op2.ToString() + " = " + result.ToString();
            
        }

        private void BtnShort_Click(object sender, EventArgs e)
        {
            short op1 = 2453;
            short op2 = 3572;
            int result = op1 - op2;
            lblDisplay.Text = op1.ToString() + " + " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            int op1 = 1468;
            int op2 = 23;
            int result = op1 % op2;
            lblDisplay.Text = op1.ToString() + " % " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnLong_Click(object sender, EventArgs e)
        {
            long op1 = 24676;
            long op2 = 23647;
            long result = op1 * op2;
            lblDisplay.Text = op1.ToString() + " * " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            decimal op1 = 1m;
            decimal op2 = 3m;
            decimal result = op1 / op2;
            lblDisplay.Text = op1.ToString() + " / " + op2.ToString() + " = " + result.ToString();
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            Double op1 = 32.2134325325254474235;
            Double op2 = 3.82635983259236574366;
            Double result = op1 % op2;
            lblDisplay.Text = op1.ToString() + " % " + op2.ToString() + " = " + result.ToString();
        }
    }
}
