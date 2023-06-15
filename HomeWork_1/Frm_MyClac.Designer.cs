namespace HomeWork_1
{
    partial class Frm_MyClac
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
            this.btn加 = new System.Windows.Forms.Button();
            this.btn減 = new System.Windows.Forms.Button();
            this.btn乘 = new System.Windows.Forms.Button();
            this.btn除 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Num1 = new System.Windows.Forms.TextBox();
            this.text_Num2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn加
            // 
            this.btn加.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加.Location = new System.Drawing.Point(350, 64);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(69, 59);
            this.btn加.TabIndex = 0;
            this.btn加.Text = "+";
            this.btn加.UseVisualStyleBackColor = true;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btn減
            // 
            this.btn減.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減.Location = new System.Drawing.Point(447, 64);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(69, 59);
            this.btn減.TabIndex = 1;
            this.btn減.Text = "-";
            this.btn減.UseVisualStyleBackColor = true;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // btn乘
            // 
            this.btn乘.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn乘.Location = new System.Drawing.Point(350, 165);
            this.btn乘.Name = "btn乘";
            this.btn乘.Size = new System.Drawing.Size(69, 59);
            this.btn乘.TabIndex = 2;
            this.btn乘.Text = "*";
            this.btn乘.UseVisualStyleBackColor = true;
            this.btn乘.Click += new System.EventHandler(this.btn乘_Click);
            // 
            // btn除
            // 
            this.btn除.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn除.Location = new System.Drawing.Point(447, 165);
            this.btn除.Name = "btn除";
            this.btn除.Size = new System.Drawing.Size(69, 59);
            this.btn除.TabIndex = 3;
            this.btn除.Text = "/";
            this.btn除.UseVisualStyleBackColor = true;
            this.btn除.Click += new System.EventHandler(this.btn除_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(63, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(63, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Num2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝";
            // 
            // text_Num1
            // 
            this.text_Num1.Location = new System.Drawing.Point(169, 107);
            this.text_Num1.Name = "text_Num1";
            this.text_Num1.Size = new System.Drawing.Size(104, 25);
            this.text_Num1.TabIndex = 7;
            // 
            // text_Num2
            // 
            this.text_Num2.Location = new System.Drawing.Point(169, 165);
            this.text_Num2.Name = "text_Num2";
            this.text_Num2.Size = new System.Drawing.Size(104, 25);
            this.text_Num2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(44, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Answer:";
            // 
            // labAns
            // 
            this.labAns.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAns.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAns.Location = new System.Drawing.Point(169, 274);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(158, 28);
            this.labAns.TabIndex = 10;
            
            // 
            // Frm_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Num2);
            this.Controls.Add(this.text_Num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn除);
            this.Controls.Add(this.btn乘);
            this.Controls.Add(this.btn減);
            this.Controls.Add(this.btn加);
            this.Name = "Frm_MyClac";
            this.Text = "Frm_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.Button btn乘;
        private System.Windows.Forms.Button btn除;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Num1;
        private System.Windows.Forms.TextBox text_Num2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labAns;
    }
}