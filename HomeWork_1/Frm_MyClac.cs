using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_1
{
    public partial class Frm_MyClac : Form
    {
        public Frm_MyClac()
        {
            InitializeComponent();
        }


        private void btn加_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool isNum_1 = double.TryParse(text_Num1.Text, out Num1);
            bool isNum_2 = double.TryParse(text_Num2.Text, out Num2);

            if(isNum_1&&isNum_2==true)
            {
                double An = double.Parse(text_Num1.Text) + double.Parse(text_Num2.Text);
               labAns.Text = An.ToString();
            }
            else   
            {
                MessageBox.Show("請輸入數值");
            }

           





        }

        private void btn減_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool isNum_1 = double.TryParse(text_Num1.Text, out Num1);
            bool isNum_2 = double.TryParse(text_Num2.Text, out Num2);

            if (isNum_1 && isNum_2 == true)
            {
                double An = double.Parse(text_Num1.Text) - double.Parse(text_Num2.Text);
                labAns.Text = An.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn乘_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool isNum_1 = double.TryParse(text_Num1.Text, out Num1);
            bool isNum_2 = double.TryParse(text_Num2.Text, out Num2);

            if (isNum_1 && isNum_2 == true)
            {
                double An = double.Parse(text_Num1.Text) * double.Parse(text_Num2.Text);
                labAns.Text = An.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn除_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool isNum_1 = double.TryParse(text_Num1.Text, out Num1);
            bool isNum_2 = double.TryParse(text_Num2.Text, out Num2);

            if (isNum_1 && isNum_2 == true)
            {
                double An = double.Parse(text_Num1.Text) / double.Parse(text_Num2.Text);
                labAns.Text = An.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}
