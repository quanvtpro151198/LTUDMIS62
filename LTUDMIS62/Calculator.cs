using System;
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
    public partial class Calculator : Form
    {
        double value = 0;
        string pheptoan = "";
        bool pheptoan_nhan = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(pheptoan_nhan))
                result.Clear();
            pheptoan_nhan = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void pheptoan_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                button12.PerformClick();
                pheptoan_nhan = true;
                pheptoan = b.Text;
                sotieptheo.Text = value + " " + pheptoan;
            }
            else
            {
                pheptoan = b.Text;
                value = double.Parse(result.Text);
                pheptoan_nhan = true;
                sotieptheo.Text = value + " " + pheptoan;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sotieptheo.Text = "";
            switch(pheptoan)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch
            value = Int64.Parse(result.Text);
            pheptoan = "";
        }
    }
}
