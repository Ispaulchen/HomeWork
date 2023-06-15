namespace HomeWork_1
{
    partial class Frm_Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.text_name = new System.Windows.Forms.TextBox();
            this.CH_name = new System.Windows.Forms.Label();
            this.En_name = new System.Windows.Forms.Label();
            this.text_Ename = new System.Windows.Forms.TextBox();
            this.S_ITEM = new System.Windows.Forms.Label();
            this.text_S = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.text_Sex = new System.Windows.Forms.TextBox();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(413, 194);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(98, 25);
            this.text_name.TabIndex = 0;
            // 
            // CH_name
            // 
            this.CH_name.AutoSize = true;
            this.CH_name.Location = new System.Drawing.Point(318, 197);
            this.CH_name.Name = "CH_name";
            this.CH_name.Size = new System.Drawing.Size(37, 15);
            this.CH_name.TabIndex = 1;
            this.CH_name.Text = "姓名";
            // 
            // En_name
            // 
            this.En_name.AutoSize = true;
            this.En_name.Location = new System.Drawing.Point(318, 245);
            this.En_name.Name = "En_name";
            this.En_name.Size = new System.Drawing.Size(67, 15);
            this.En_name.TabIndex = 2;
            this.En_name.Text = "英文名子";
            // 
            // text_Ename
            // 
            this.text_Ename.Location = new System.Drawing.Point(413, 242);
            this.text_Ename.Name = "text_Ename";
            this.text_Ename.Size = new System.Drawing.Size(98, 25);
            this.text_Ename.TabIndex = 3;
            // 
            // S_ITEM
            // 
            this.S_ITEM.AutoSize = true;
            this.S_ITEM.Location = new System.Drawing.Point(318, 294);
            this.S_ITEM.Name = "S_ITEM";
            this.S_ITEM.Size = new System.Drawing.Size(37, 15);
            this.S_ITEM.TabIndex = 4;
            this.S_ITEM.Text = "星座";
            this.S_ITEM.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_S
            // 
            this.text_S.Location = new System.Drawing.Point(413, 291);
            this.text_S.Name = "text_S";
            this.text_S.Size = new System.Drawing.Size(98, 25);
            this.text_S.TabIndex = 5;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(318, 340);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(37, 15);
            this.Sex.TabIndex = 6;
            this.Sex.Text = "性別";
            // 
            // text_Sex
            // 
            this.text_Sex.Location = new System.Drawing.Point(413, 337);
            this.text_Sex.Name = "text_Sex";
            this.text_Sex.Size = new System.Drawing.Size(98, 25);
            this.text_Sex.TabIndex = 7;
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(299, 413);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(103, 30);
            this.btnSayHi.TabIndex = 8;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(452, 413);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(103, 30);
            this.btnSayHello.TabIndex = 9;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeWork_1.Properties.Resources.Poli;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.text_Sex);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.text_S);
            this.Controls.Add(this.S_ITEM);
            this.Controls.Add(this.text_Ename);
            this.Controls.Add(this.En_name);
            this.Controls.Add(this.CH_name);
            this.Controls.Add(this.text_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label CH_name;
        private System.Windows.Forms.Label En_name;
        private System.Windows.Forms.TextBox text_Ename;
        private System.Windows.Forms.Label S_ITEM;
        private System.Windows.Forms.TextBox text_S;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox text_Sex;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Button btnSayHello;
    }
}

