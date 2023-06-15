namespace HomeWork_1
{
    partial class Frm_StudentGrade
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRanOut = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRanIn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labList = new System.Windows.Forms.Label();
            this.lab統計 = new System.Windows.Forms.Label();
            this.labScList = new System.Windows.Forms.Label();
            this.btn統計 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnRanOut
            // 
            this.btnRanOut.Location = new System.Drawing.Point(41, 246);
            this.btnRanOut.Name = "btnRanOut";
            this.btnRanOut.Size = new System.Drawing.Size(112, 26);
            this.btnRanOut.TabIndex = 5;
            this.btnRanOut.Text = "隨機存取資料";
            this.btnRanOut.UseVisualStyleBackColor = true;
            this.btnRanOut.Click += new System.EventHandler(this.btnRanOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(41, 365);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 26);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRanIn
            // 
            this.btnRanIn.Location = new System.Drawing.Point(41, 412);
            this.btnRanIn.Name = "btnRanIn";
            this.btnRanIn.Size = new System.Drawing.Size(112, 26);
            this.btnRanIn.TabIndex = 7;
            this.btnRanIn.Text = "隨機加入20筆";
            this.btnRanIn.UseVisualStyleBackColor = true;
            this.btnRanIn.Click += new System.EventHandler(this.btnRanIn_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(75, 25);
            this.txtName.TabIndex = 10;
            // 
            // txtCh
            // 
            this.txtCh.Location = new System.Drawing.Point(128, 76);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(75, 25);
            this.txtCh.TabIndex = 11;
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(128, 117);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(75, 25);
            this.txtEn.TabIndex = 12;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(128, 164);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(75, 25);
            this.txtMath.TabIndex = 13;
            // 
            // labList
            // 
            this.labList.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(0, 0);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(566, 26);
            this.labList.TabIndex = 14;
            this.labList.Text = "姓名        國文      英文      數學      總分      平均      最低      最高          \r\n";
            // 
            // lab統計
            // 
            this.lab統計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab統計.Location = new System.Drawing.Point(220, 321);
            this.lab統計.Name = "lab統計";
            this.lab統計.Size = new System.Drawing.Size(570, 120);
            this.lab統計.TabIndex = 15;
            // 
            // labScList
            // 
            this.labScList.Location = new System.Drawing.Point(0, 21);
            this.labScList.Name = "labScList";
            this.labScList.Size = new System.Drawing.Size(566, 237);
            this.labScList.TabIndex = 16;
            // 
            // btn統計
            // 
            this.btn統計.Location = new System.Drawing.Point(41, 278);
            this.btn統計.Name = "btn統計";
            this.btn統計.Size = new System.Drawing.Size(112, 26);
            this.btn統計.TabIndex = 17;
            this.btn統計.Text = "各科統計";
            this.btn統計.UseVisualStyleBackColor = true;
            this.btn統計.Click += new System.EventHandler(this.btn統計_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labScList);
            this.panel1.Controls.Add(this.labList);
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 263);
            this.panel1.TabIndex = 18;
            // 
            // Frm_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn統計);
            this.Controls.Add(this.lab統計);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRanIn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRanOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_StudentGrade";
            this.Text = "Frm_StudentGrade";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRanOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRanIn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Label lab統計;
        private System.Windows.Forms.Label labScList;
        private System.Windows.Forms.Button btn統計;
        private System.Windows.Forms.Panel panel1;
    }
}