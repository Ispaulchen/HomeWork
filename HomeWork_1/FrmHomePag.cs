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
    public partial class FrmHomePag : Form
    {
        public FrmHomePag()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void frmCall(Form frm)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            //非最上層
            frm.TopLevel = false;

            //顯示Form，要加上去才會顯示Form
            frm.Visible = true;

            //設定Form位置
            frm.Top = 0;
            frm.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm);

        }


        private void btnHello_Click(object sender, EventArgs e)
        {
          Frm_Hello fr = new Frm_Hello();
            frmCall(fr);

        }

        private void btnLoan_Click(object sender, EventArgs e)
        {

            Frm_Loan fr = new Frm_Loan();
            frmCall(fr);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            Frm_POSn fr = new Frm_POSn();
            frmCall(fr);

        }

       

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            Frm_StudentGrade fr = new Frm_StudentGrade();
            frmCall(fr);
        }

              

        private void btnStruct_Click(object sender, EventArgs e)
        {
            Frm_Stu1 fr = new Frm_Stu1();
            frmCall(fr);
        }

        private void btnScreen_Click_1(object sender, EventArgs e)
        {
            Frm_Screen fr = new Frm_Screen();
            fr.Show();

        }

        private void btnMyclac_Click_1(object sender, EventArgs e)
        {
            Frm_MyClac fr = new Frm_MyClac();
            frmCall(fr);
        }
    }
}
