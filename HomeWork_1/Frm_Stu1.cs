using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork_1
{
    public partial class Frm_Stu1 : Form
    {

        public Frm_Stu1()
        {
            InitializeComponent();
        }


       public struct Scores
        {
           public string Name { get; set; } 
           public int Chin { get; set; }
            public int En { get; set; }
           public int Math { get; set; }

            public Scores(string ScoreName, int ScoreChin, int ScoreEn, int ScoreMath)
            {
                Name = ScoreName;
                Chin = ScoreChin;
                En = ScoreEn;
                Math = ScoreMath;
            }
        }


        int Max_Score;
        int Min_Score;
        string ScoreResult ;
                

        private void btnIn_Click(object sender, EventArgs e)
        {


            //sc.Name = textName.Text;
            //sc.Chin = int.Parse(textChin.Text);
            //sc.En = int.Parse(textEn.Text);
            //sc.Math = int.Parse(textMath.Text);

            int chin = 0; int en = 0; int math = 0;
            bool isNum = int.TryParse(textChin.Text,out chin);
            bool isNum1 = int.TryParse(textEn.Text, out en);
            bool isNum2 = int.TryParse(textMath.Text, out math);

            if (isNum == isNum1 == isNum2)
            {
                Scores sc = new Scores(textName.Text, chin,en,math);
                sc.Name = textName.Text;
                ScoreResult = "姓名:" + sc.Name +"\n" + "國文:" + sc.Chin  +"\n" +"英文:"  + sc.En + "\n" + "數學:" + sc.Math;


            }
            else
            {
               MessageBox.Show("請輸入分數");

                textChin.Clear();
                textEn.Clear();
                textMath.Clear();
            }



        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            lab成績.Text = ScoreResult;
        }

        string High;
        string Low;

        private void btnMaxMin_Click(object sender, EventArgs e)
        {


            Scores sc = new Scores();
            
            sc.Chin = int.Parse(textChin.Text);
            sc.En = int.Parse(textEn.Text);
            sc.Math = int.Parse(textMath.Text);
            int[] ScoresArray = new int[3] {sc.Chin,sc.En,sc.Math};

            Max_Score = ScoresArray.Max();
            Min_Score = ScoresArray.Min();

            string[] subjectArray = new string[3] { "國文", "英文", "數學" };
            string Max_Result;
            string Min_Result;
            Max_Result = subjectArray[Array.IndexOf(ScoresArray, Max_Score)];
            Min_Result = subjectArray[Array.IndexOf(ScoresArray, Min_Score)];

            lab高低分.Text = $"最高科目成績為:{Max_Result}{Max_Score}分\n" +
                             $"最低科目成績為:{Min_Result}{Min_Score}分";

        }


      

        // Scores sc = new Scores();

        //sc.Chin= int.Parse(textChin.Text);
        //sc.En= int.Parse(textEn.Text);
        // sc.Math = int.Parse(textMath.Text);

        // lab高低分.Text = High + "\n" + Low;

        // bool c = (sc.Chin > sc.En && sc.Chin > sc.En );
        // if (c)
        // {
        //     High = $"最高科目成績為:國文{sc.Chin}分";
        // }
        // else
        // {
        //     Low = $"最低科目成績為:國文{sc.Chin}分";
        // }


        // bool n = (sc.En>sc.Chin && sc.En > sc.Math);
        // if (n)
        // {
        //     High = $"最高科目成績為:英文{sc.En}分";
        // }
        // else
        // {
        //     Low = $"最低科目成績為:英文{sc.En}分";
        // }

        // bool m = (sc.Math > sc.Chin && sc.Math > sc.En);
        // if (m)
        // {
        //     High = $"最高科目成績為:數學{sc.Math}分";
        // }
        // else
        // {
        //     Low = $"最低科目成績為:數學{sc.Math}分";
        // }
    }


}
        
       

    


