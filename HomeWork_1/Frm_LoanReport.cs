using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_1
{
    public partial class Frm_LoanReport : Form
    {

        public string Lab1;
        public string Lab2;
        public string Lab3;
        public string Lab4;
        public string Lab5;
        public Frm_LoanReport()
        {
            InitializeComponent();
        }
                    

        private void Frm_LoanReport_Load(object sender, EventArgs e)
        {
            lab貸款.Text = Lab1;
            lab期限.Text = Lab2;
            lab利率.Text = Lab3;
            labPMT_1.Text = Lab4;
            labTotal.Text = Lab5;
        }
    }
}
