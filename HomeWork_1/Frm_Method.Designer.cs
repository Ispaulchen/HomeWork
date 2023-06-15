namespace HomeWork_1
{
    partial class Frm_Method
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btn奇偶數 = new System.Windows.Forms.Button();
            this.labAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(117, 7);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(87, 25);
            this.txtNumber.TabIndex = 2;
            // 
            // btn奇偶數
            // 
            this.btn奇偶數.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn奇偶數.Location = new System.Drawing.Point(3, 48);
            this.btn奇偶數.Name = "btn奇偶數";
            this.btn奇偶數.Size = new System.Drawing.Size(156, 66);
            this.btn奇偶數.TabIndex = 3;
            this.btn奇偶數.Text = "輸入的數\r\n為奇數或偶數";
            this.btn奇偶數.UseVisualStyleBackColor = true;
            this.btn奇偶數.Click += new System.EventHandler(this.button1_Click);
            // 
            // labAns
            // 
            this.labAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAns.Location = new System.Drawing.Point(3, 228);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(1084, 294);
            this.labAns.TabIndex = 16;
            // 
            // Frm_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 522);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.btn奇偶數);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Method";
            this.Text = "Frm_Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btn奇偶數;
        private System.Windows.Forms.Label labAns;
    }
}