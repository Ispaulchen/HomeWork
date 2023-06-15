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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            String Cname = text_name.Text;
            String Ename = text_Ename.Text;
            String stellation = text_S.Text;
            String Sex = text_Sex.Text;

            MessageBox.Show("Hi 我是" + Cname + '\n' +
                            "英文名子是" + Ename + '\n' +
                            "星座是" + stellation + '\n' +
                            "性別是" + Sex+'\n'+
                            "我是孩子王~~"
                            );

        
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            String Cname = text_name.Text;
            String Ename = text_Ename.Text;
            String stellation = text_S.Text;
            String Sex = text_Sex.Text;

            MessageBox.Show("Hello 我是" + Cname + '\n' +
                            "英文名子是" + Ename + '\n' +
                            "星座是" + stellation + '\n' +
                             "性別是" + Sex + '\n' +
                            "我是孩子王~~"
                            );
        }
    }
}
