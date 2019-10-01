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
            int op1 = 8;
            int op2 = 16;
            int result = op1 + op2;
            lblDisplay.Text = op1.ToString() + " + " + op2.ToString() + " = " + result.ToString();
        }
    }
}
