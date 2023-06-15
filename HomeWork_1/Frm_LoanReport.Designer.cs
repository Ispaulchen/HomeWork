namespace HomeWork_1
{
    partial class Frm_LoanReport
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
            this.btnEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab貸款 = new System.Windows.Forms.Label();
            this.lab期限 = new System.Windows.Forms.Label();
            this.lab利率 = new System.Windows.Forms.Label();
            this.labPMT_1 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmail.Location = new System.Drawing.Point(486, 346);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(120, 59);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款";
            // 
            // lab貸款
            // 
            this.lab貸款.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab貸款.Location = new System.Drawing.Point(153, 72);
            this.lab貸款.Name = "lab貸款";
            this.lab貸款.Size = new System.Drawing.Size(102, 27);
            this.lab貸款.TabIndex = 6;
            // 
            // lab期限
            // 
            this.lab期限.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab期限.Location = new System.Drawing.Point(153, 117);
            this.lab期限.Name = "lab期限";
            this.lab期限.Size = new System.Drawing.Size(102, 27);
            this.lab期限.TabIndex = 7;
            // 
            // lab利率
            // 
            this.lab利率.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab利率.Location = new System.Drawing.Point(153, 171);
            this.lab利率.Name = "lab利率";
            this.lab利率.Size = new System.Drawing.Size(102, 27);
            this.lab利率.TabIndex = 8;
            // 
            // labPMT_1
            // 
            this.labPMT_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labPMT_1.Location = new System.Drawing.Point(153, 227);
            this.labPMT_1.Name = "labPMT_1";
            this.labPMT_1.Size = new System.Drawing.Size(102, 27);
            this.labPMT_1.TabIndex = 9;
            // 
            // labTotal
            // 
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotal.Location = new System.Drawing.Point(153, 279);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(102, 27);
            this.labTotal.TabIndex = 10;
            // 
            // Frm_LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labPMT_1);
            this.Controls.Add(this.lab利率);
            this.Controls.Add(this.lab期限);
            this.Controls.Add(this.lab貸款);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_LoanReport";
            this.Text = "Frm_LoanReport";
            this.Load += new System.EventHandler(this.Frm_LoanReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab貸款;
        private System.Windows.Forms.Label lab期限;
        private System.Windows.Forms.Label lab利率;
        private System.Windows.Forms.Label labPMT_1;
        private System.Windows.Forms.Label labTotal;
    }
}