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
    public partial class TachTen : Form
    {
        string ht, kq;
        int vt1, vt2;
        public TachTen()
        {
            InitializeComponent();
        }

        private void btnTachHoDem_Click(object sender, EventArgs e)
        {
            /*ht=txtHT.Text.Trim();
            vt1=ht.LastIndexOf(" ");
            kq=ht.Substring(0, vt1);
            lblKQ.Text=kq;*/
            lblKQ.Text=HoDem(txtHT.Text.Trim());
        }
        private string HoDem(string str)
        {
            vt1=str.LastIndexOf(" ");
            kq=str.Substring(0, vt1);
            return kq;
        }
        private void btnTachDem_Click(object sender, EventArgs e)
        {
            /*ht=txtHT.Text.Trim();
            vt1=ht.IndexOf(" ");
            vt2=ht.LastIndexOf(" ");
            kq=ht.Substring(vt1, vt2-vt1);
            lblKQ.Text=kq;*/
            lblKQ.Text =Dem(txtHT.Text.Trim());
        }
        private string Dem(string str)
        {
            vt1=str.IndexOf(" ");
            vt2=str.LastIndexOf(" ");
            kq=str.Substring(vt1, vt2-vt1);
            return kq;
        }
        private void btnTachDemTen_Click(object sender, EventArgs e)
        {
            /*ht=txtHT.Text.Trim();
            vt1=ht.IndexOf(" ");
            kq=ht.Substring(vt1++);
            lblKQ.Text=kq;*/
            lblKQ.Text=DemTen(txtHT.Text.Trim());
        }
        private string DemTen(string str)
        { 
            vt1=str.IndexOf(" ");
            kq=str.Substring(vt1++);
            return kq;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
