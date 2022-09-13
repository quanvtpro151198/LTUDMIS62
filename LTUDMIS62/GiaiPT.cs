﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class GiaiPT : Form
    {
        public GiaiPT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;
            a=Convert.ToDouble(txtA.Text);
            b=Convert.ToDouble(txtB.Text);
            c=Convert.ToDouble(txtC.Text);
            d=b*b-4*a*c;
            if(d<0)
            {
                lblKQ.Text="Phuong trinh vo nghiem!";
            }
            else
            {
                x1=(-b+Math.Sqrt(d))/(2*a);
                x2=(-b-Math.Sqrt(d))/(2*a);
                lblKQ.Text="X1=" + Convert.ToString(x1)+", X2=" + Convert.ToString(x2);
            }
        }
    }
}
