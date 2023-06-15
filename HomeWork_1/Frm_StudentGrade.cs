using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork_1
{
    public partial class Frm_StudentGrade : Form
    {
        public Frm_StudentGrade()
        {
            InitializeComponent();

            //btnAdd.Enabled = false;
            //btnRanOut.Enabled = false;
            //btnRanIn.Enabled = false;
            btn統計.Enabled = false;
           



        }
        public class Scores
        {
            public string m_Name;
            public int m_Chin;
            public int m_En;
            public int m_Math;           
        }

       

        int Max_Score;
        int Min_Score;
        string ScoreResult;
        string Max_Result;
        string Min_Result;
        int ScoreTotal;
        double Scoreavage;

        
        int count_ADD ;
        int count_Rad ;
        int count_Rad20;
        int countsum;
        int Ch_sum; 
        int En_sum;
        int M_sum;

        

         List<Scores> lsScores = new List<Scores>();

        int Ch_H; int CH_L;
        int En_H; int En_L;
        int M_H; int M_L;





        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            
            count_ADD++;
            int chin = 0; int en = 0; int math = 0;int name = 0;
            bool isNum = int.TryParse(txtCh.Text, out chin);
            bool isNum1 = int.TryParse(txtEn.Text, out en);
            bool isNum2 = int.TryParse(txtMath.Text, out math);
            bool isNum3;
            isNum3 = txtName.Text == null || txtName.Text == string.Empty;
           
            if (isNum3)
            {
                MessageBox.Show("請輸入姓名"); 
                return;
            }

            if (isNum == isNum1 == isNum2 )
            {
                
                Scores sc = new Scores();
                sc.m_Name = txtName.Text;                                
                sc.m_Chin = int.Parse(txtCh.Text);
                sc.m_En = int.Parse(txtEn.Text);
                sc.m_Math = int.Parse(txtMath.Text);
                int CH = sc.m_Chin;
                lsScores.Add(sc);
                //lsScores.Add(new Scores() { m_Name = "QQQ", m_Chin = 1234,m_En = 50,m_Math=80 });

                int[] ScoresArray = new int[3] { sc.m_Chin, sc.m_En, sc.m_Math };


                Max_Score = ScoresArray.Max();
                Min_Score = ScoresArray.Min();
                ScoreTotal = ScoresArray.Sum();
                Scoreavage = ScoresArray.Average();


                string[] subjectArray = new string[3] { "國文", "英文", "數學" };
                string Max_Result;
                string Min_Result;
                Max_Result = subjectArray[Array.IndexOf(ScoresArray, Max_Score)];
                Min_Result = subjectArray[Array.IndexOf(ScoresArray, Min_Score)];


                //ScoreResult += $"{sc.m_Name}{sc.m_Chin,15}{sc.m_En,15}{sc.m_Math,15}{ScoreTotal,15}{Scoreavage.ToString("F1"),17}{Min_Result,10}{Min_Score}{Max_Result,10}{Max_Score}\n";
                ScoreResult += $"{sc.m_Name}{sc.m_Chin.ToString("000"),16}{sc.m_En.ToString("000"),16}{sc.m_Math.ToString("000"),16}{ScoreTotal.ToString("000"),15}{Scoreavage.ToString("F1"),15}{Min_Result,10}{Min_Score.ToString("00")}{Max_Result,10}{Max_Score.ToString("00")}\n";
                labScList.Text = ScoreResult;
                Ch_sum+= sc.m_Chin;
                En_sum+= sc.m_En;
                M_sum+= sc.m_Math;
                btn統計.Enabled = true;
                lab統計.Text = "";

            }
            else
            {
                MessageBox.Show("請輸入分數");

                txtCh.Clear();
                txtEn.Clear();
                txtMath.Clear();
              

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            labScList.Text = "";
            lsScores.Clear();
            count_ADD = 0;
             count_Rad = 0; 
             count_Rad20 = 0;
            lab統計.Text = "";
            ScoreResult = "";
            Ch_sum = 0;
            En_sum = 0;
            M_sum = 0;



        }

        private void btnRanOut_Click(object sender, EventArgs e)
        {

            count_Rad++;
            Random rud = new Random();
            int Value_Na = rud.Next(0, 101);
            int Value_Ch = rud.Next(0, 101);
            int Value_En = rud.Next(0, 101);
            int Value_Ma = rud.Next(0, 101);           


            Scores sc = new Scores();
            sc.m_Name = Value_Na.ToString("00");
            sc.m_Chin = Value_Ch;
            sc.m_En = Value_En;
            sc.m_Math = Value_Ma;
            lsScores.Add(sc);
            int[] ScoresArray = new int[3] { sc.m_Chin, sc.m_En, sc.m_Math };

            Max_Score = ScoresArray.Max();
            Min_Score = ScoresArray.Min();
            ScoreTotal = ScoresArray.Sum();
            Scoreavage = ScoresArray.Average();

            string[] subjectArray = new string[3] { "國文", "英文", "數學" };
            string Max_Result;
            string Min_Result;
            Max_Result = subjectArray[Array.IndexOf(ScoresArray, Max_Score)];
            Min_Result = subjectArray[Array.IndexOf(ScoresArray, Min_Score)];


            ScoreResult += $"{sc.m_Name}{sc.m_Chin.ToString("000"),18}{sc.m_En.ToString("000"),16}{sc.m_Math.ToString("000"),16}{ScoreTotal.ToString("000"),15}{Scoreavage.ToString("F1"),15}{Min_Result,10}{Min_Score.ToString("00")}{Max_Result,10}{Max_Score.ToString("00")}\n";

            labScList.Text = ScoreResult;
            btn統計.Enabled = true;
            lab統計.Text = "";

            Ch_sum += sc.m_Chin;
            En_sum += sc.m_En;
            M_sum += sc.m_Math;

        }

        private void btnRanIn_Click(object sender, EventArgs e)
        {
            btn統計.Enabled = true;
            lab統計.Text = "";

            //int cr = count_Rad20;
            for (int i = 0; i < 21; i++)
            {
                count_Rad20++;

                Random rud = new Random(i);
                int Value_Na = rud.Next(0, 101);
                int Value_Ch = rud.Next(0, 101);
                int Value_En = rud.Next(0, 101);
                int Value_Ma = rud.Next(0, 101);

                string[] subjectArray = new string[3] { "國文", "英文", "數學" };
                
                Scores sc = new Scores();
                sc.m_Name = Value_Na.ToString("00");
                sc.m_Chin = Value_Ch;
                sc.m_En = Value_En;
                sc.m_Math = Value_Ma;
                lsScores.Add(sc);
                int[] ScoresArray = new int[3] { sc.m_Chin, sc.m_En, sc.m_Math };

                Max_Score = ScoresArray.Max();
                Min_Score = ScoresArray.Min();
                ScoreTotal = ScoresArray.Sum();
                Scoreavage = ScoresArray.Average();

                Max_Result = subjectArray[Array.IndexOf(ScoresArray, Max_Score)];
                Min_Result = subjectArray[Array.IndexOf(ScoresArray, Min_Score)];
                ScoreResult += $"{sc.m_Name}{sc.m_Chin.ToString("000"),18}{sc.m_En.ToString("000"),16}{sc.m_Math.ToString("000"),16}{ScoreTotal.ToString("000"),15}{Scoreavage.ToString("F1"),15}{Min_Result,10}{Min_Score.ToString("00")}{Max_Result,10}{Max_Score.ToString("00")}\n";
                Ch_sum += sc.m_Chin;
                En_sum += sc.m_En;
                M_sum += sc.m_Math;

            }

               labScList.Text = ScoreResult; 
           



        }

        private void btn統計_Click(object sender, EventArgs e)
        {
            

            countsum = count_ADD + count_Rad + count_Rad20;


            int Ch_H; int CH_L;
            int En_H; int En_L;
            int M_H; int M_L;

            var maxChin = lsScores.Max(sc => sc.m_Chin);
            var minChin = lsScores.Min(sc => sc.m_Chin);
            var maxEn   = lsScores.Max(sc => sc.m_En);
            var minEn = lsScores.Min(sc => sc.m_En);
            var maxMath = lsScores.Max(sc => sc.m_Math);
            var minMath = lsScores.Min(sc => sc.m_Math);


            lab統計.Text += $"總分{Ch_sum,15}{En_sum,15}{M_sum,15}\n平均{Ch_sum / countsum,15}  "
            + $" {En_sum / countsum,15}{M_sum / countsum,15}\n"
            + $"最高分{maxChin,15}{maxEn,15}{maxMath,15}\n"
            + $"最低分{minChin,15}{minEn,15}{minMath,15}";
            
            
              


        }
    }
}
