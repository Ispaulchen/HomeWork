using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace HomeWork_1
{
    public partial class Frm_POSn : Form
    {
        string[] menu = new string[4];

        int Brcount = 0; int Teqcount = 0; int Whiscount = 0; int Wincount = 0;
        int BrTot; int TeqTot; int WhisTot; int WineTot;
        public Frm_POSn()
        {
            InitializeComponent();
        }


        void LabMenu()
        {
            labList.Text = menu[0] + menu[1] + menu[2] + menu[3];   
        }


        private void btnBeer_Click(object sender, EventArgs e)
        {
            Brcount++;
            BrTot += 120;
            menu[0] = $"啤酒 Bree X{Brcount},共NT${BrTot}元\r\n";
            LabMenu();
            Toaa();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            Teqcount++;
            TeqTot += 150;
            menu[1] = $"龍舌蘭 Tequila X{Teqcount},共NT${TeqTot}元\r\n";
            LabMenu();
            Toaa();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {

            Whiscount++;
            WhisTot += 350;
            menu[2] = $"威士忌 Whisky X{Whiscount},共NT${WhisTot}元\r\n";
            LabMenu();
            Toaa();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            Wincount++;
            WineTot+= 250;
            menu[3] = $"紅酒 Wine X{Wincount},共NT${WineTot}元\r\n";
            LabMenu();
            Toaa();
        }

        int Total;

        public void Toaa()
        {
            Total = BrTot + TeqTot + WhisTot + WineTot;

            labTotal.Text = $"NT$ {Total}";
        }


        private void Frm_POSn_Load(object sender, EventArgs e)
        {
            if (Total == 0)
            {
                labList.Text = "尚未點餐";
                labTotal.Text = "NT$0";
            }

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (Total == 0)
            {
                MessageBox.Show( "尚未點餐");
            }
            else
            { 
            DialogResult result = MessageBox.Show($"總金額:NT${Total}", "確定付款",
             MessageBoxButtons.OKCancel);
                
            }

        }

        private void btncreditCard_Click(object sender, EventArgs e)
        {
            if (Total == 0)
            {
                MessageBox.Show("尚未點餐");
            }
            else
            {
                DialogResult result = MessageBox.Show($"總金額:NT${Total}\n折扣後總金額:NT${Total * 0.9}", "確定付款",
                 MessageBoxButtons.OKCancel);

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            
            menu[0]= menu[1]= menu[2]= menu[3] = "";
            Brcount = 0; Teqcount = 0; Whiscount = 0; Wincount = 0;
            BrTot = 0; TeqTot = 0; WhisTot = 0; WineTot = 0;

            Total = 0;
            labList.Text = "尚未點餐";
            labTotal.Text = "NT$0"; 
        }
    }
       
}

