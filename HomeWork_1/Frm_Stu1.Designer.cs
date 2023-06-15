namespace HomeWork_1
{
    partial class Frm_Stu1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab高低分 = new System.Windows.Forms.Label();
            this.lab成績 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textChin = new System.Windows.Forms.TextBox();
            this.textEn = new System.Windows.Forms.TextBox();
            this.textMath = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab高低分);
            this.groupBox1.Controls.Add(this.lab成績);
            this.groupBox1.Location = new System.Drawing.Point(436, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // lab高低分
            // 
            this.lab高低分.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab高低分.Location = new System.Drawing.Point(6, 136);
            this.lab高低分.Name = "lab高低分";
            this.lab高低分.Size = new System.Drawing.Size(261, 102);
            this.lab高低分.TabIndex = 15;
            // 
            // lab成績
            // 
            this.lab成績.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab成績.Location = new System.Drawing.Point(6, 15);
            this.lab成績.Name = "lab成績";
            this.lab成績.Size = new System.Drawing.Size(261, 112);
            this.lab成績.TabIndex = 14;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(145, 76);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(101, 25);
            this.textName.TabIndex = 6;
            // 
            // textChin
            // 
            this.textChin.Location = new System.Drawing.Point(145, 114);
            this.textChin.Name = "textChin";
            this.textChin.Size = new System.Drawing.Size(101, 25);
            this.textChin.TabIndex = 7;
            // 
            // textEn
            // 
            this.textEn.Location = new System.Drawing.Point(145, 152);
            this.textEn.Name = "textEn";
            this.textEn.Size = new System.Drawing.Size(101, 25);
            this.textEn.TabIndex = 8;
            // 
            // textMath
            // 
            this.textMath.Location = new System.Drawing.Point(145, 190);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(101, 25);
            this.textMath.TabIndex = 9;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(64, 345);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(90, 38);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "儲存";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(174, 345);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(110, 38);
            this.btnOut.TabIndex = 12;
            this.btnOut.Text = "顯示儲存內容";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(549, 340);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(154, 49);
            this.btnMaxMin.TabIndex = 13;
            this.btnMaxMin.Text = "最高分/最低分 科目";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Frm_Stu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.textEn);
            this.Controls.Add(this.textChin);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Stu1";
            this.Text = "Frm_Stu1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textChin;
        private System.Windows.Forms.TextBox textEn;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Label lab高低分;
        private System.Windows.Forms.Label lab成績;
    }
}