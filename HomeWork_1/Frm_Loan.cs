using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_1
{
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }
        
        
        int M; //Money
        int D; //Date
        double R; //Rate
        int F; //Frist
        double PMT;
        int PMT_1;
        int Total;
        private void btnPMT_Click(object sender, EventArgs e)
        {
            Laon();

            MessageBox.Show("月付額:"+ PMT_1.ToString() +"元");
        }

              
         public void Laon()

        {
            M = int.Parse(text貸款.Text);
            D = int.Parse(text期限.Text);
            R = double.Parse(text利率.Text);
            F = int.Parse(text頭期.Text);


            double C_R = 1 + (R / 12 / 100); //C_R 公比
            double M_D = D * 12; //期數
            double C_D = Math.Pow(C_R,M_D);
            PMT= (M * C_D * (C_R - 1)) / (C_D - 1);
            PMT_1 = Convert.ToInt32(PMT);

            /*
            (x*r^n(r-1))/(r^n-1)
            (本金 * 公比 ^ 期數(公比 - 1)) / (公比 ^ 期數 - 1)
 本金 * (1 + (rate / 12 / 100) ^ 期數 * (1 + (rate / 12 / 100)) - 1) / (1 + (rate / 12 / 100) - 1)
            */

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Laon();
            int Total = PMT_1 * D * 12;
            MessageBox.Show("總付款金額:"+Total.ToString());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Frm_LoanReport Lr = new Frm_LoanReport();
            Laon();
            Lr.Lab1 = M.ToString();
            Lr.Lab2 = D.ToString();
            Lr.Lab3 = R.ToString();
            Lr.Lab4 = PMT_1.ToString();
            Lr.Lab5 = Total.ToString();
            Lr.ShowDialog();
            
           
        }
    }
      
    
}
