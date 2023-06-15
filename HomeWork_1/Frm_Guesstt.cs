using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork_1
{
    public partial class Frm_Guesstt : Form
    {
        public Frm_Guesstt()
        {
            InitializeComponent();
            
        }
        


        private void btnGuess_Click(object sender, EventArgs e)
        {

            Random rud = new Random();

            int Value = rud.Next(1, 100);
            string inputBox = "";
            int Count = 0;
            int ct = Count++;
            int[] ges;
            


           
            do
            {
                
                inputBox = Interaction.InputBox("Please input a number", "Guess", "", -1, -1);
                ges = new int[] { Convert.ToInt32(inputBox) };
                if (!IsNumeric(inputBox))
                {
                    MessageBox.Show("請輸入0~100之間的數字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int keyin = Convert.ToInt32(inputBox);
                    if (keyin > Value)
                    {
                        labMessage.Text = $"值太大!!\n Between 0 to {keyin}";
                    }
                    else if (keyin < Value)
                    {
                        labMessage.Text = $"值太小!!\n Between {keyin} to 100 ";
                    }
                   



                    //if (keyin == Value)
                    //{
                    //    MessageBox.Show("恭喜猜中了!!" + " ANS:" + Value);



                    }
            }
            while (!IsNumeric(inputBox));

            //textBox2.Text = inputBox;



        }
        public bool IsNumeric(String inputBox)
        {
            Regex NumberPattern = new Regex("[^0-9]");
            return !NumberPattern.IsMatch(inputBox);
        }
    }
}
