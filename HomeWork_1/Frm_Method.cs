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
    public partial class Frm_Method : Form
    {
        public Frm_Method()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num;
            bool isNum = int.TryParse(txtNumber.Text, out Num);
            if (isNum)
            {
                if (Num % 2 == 0)
                {
                    labAns.Text = $"輸入{txtNumber.Text},此為偶數值";
                }
                else 
                {
                    labAns.Text = $"輸入{txtNumber.Text},此為奇數值";
                }

                                
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }

            //switch (Num % 2==0)
            //{
            //    case true : ltBoxAns.Text = $"數入{txtNumber},此為偶數值";
            //        break;
            //    case false : ltBoxAns.Text = $"數入{txtNumber},此為奇數值";
            //        break;
            //}
        }
    }
}
