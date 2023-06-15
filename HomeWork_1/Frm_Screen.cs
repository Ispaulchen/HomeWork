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
    public partial class Frm_Screen : Form
    {
        public Frm_Screen()
        {
            InitializeComponent();
        }


        // photo select and move step setting

        int xStep = 10;
        int yStep = 10;
        //private int imageSpeedX = 10;  // 圖片在水平方向上的移動速度
        //private int imageSpeedY = 10;  // 圖片在垂直方向上的移動速度

        private void timer1_Tick(object sender, EventArgs e)
        {
            //// 更新圖片位置
            //pictureBox1.Left += imageSpeedX;
            //pictureBox1.Top += imageSpeedY;

            //// 邊緣碰撞檢測
            //if (pictureBox1.Left <= 0 || pictureBox1.Right >= ClientSize.Width)
            //{
            //    imageSpeedX = -imageSpeedX;  // 水平方向速度取反，實現回彈效果
            //}

            //if (pictureBox1.Top <= 0 || pictureBox1.Bottom >= ClientSize.Height)
            //{
            //    imageSpeedY = -imageSpeedY;  // 垂直方向速度取反，實現回彈效果
            //}
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int width = this.Width;
            int height = this.Height;

            if (x < 0 || x + pictureBox1.Width > width)
            {
                xStep *= -1;
            }
            if (y < 0 || y + pictureBox1.Height > height)
            {
                yStep *= -1;
            }
            x += xStep;
            y += yStep;
            pictureBox1.Location = new Point(x, y);

        }

        private void Frm_Screen_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Screen_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
