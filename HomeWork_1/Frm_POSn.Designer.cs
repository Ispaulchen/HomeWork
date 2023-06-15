namespace HomeWork_1
{
    partial class Frm_POSn
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncreditCard = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btncreditCard);
            this.groupBox4.Controls.Add(this.btnMoney);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(251, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 134);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "付款方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(120, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "信用卡享九折";
            // 
            // btncreditCard
            // 
            this.btncreditCard.BackColor = System.Drawing.SystemColors.Control;
            this.btncreditCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncreditCard.Location = new System.Drawing.Point(129, 44);
            this.btncreditCard.Name = "btncreditCard";
            this.btncreditCard.Size = new System.Drawing.Size(102, 55);
            this.btncreditCard.TabIndex = 3;
            this.btncreditCard.Text = "信用卡";
            this.btncreditCard.UseVisualStyleBackColor = false;
            this.btncreditCard.Click += new System.EventHandler(this.btncreditCard_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoney.Location = new System.Drawing.Point(6, 44);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(102, 55);
            this.btnMoney.TabIndex = 2;
            this.btnMoney.Text = "現金";
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.labTotal);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(251, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "總金額 Total Price";
            // 
            // labTotal
            // 
            this.labTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotal.BackColor = System.Drawing.SystemColors.WindowText;
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotal.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTotal.Location = new System.Drawing.Point(6, 30);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(226, 69);
            this.labTotal.TabIndex = 2;
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnClean);
            this.groupBox2.Controls.Add(this.labList);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(495, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 311);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "購物清單 List";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.Control;
            this.btnClean.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClean.Location = new System.Drawing.Point(143, 257);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(143, 43);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "清除清單";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.SystemColors.Window;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labList.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(6, 24);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(281, 213);
            this.labList.TabIndex = 0;
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnWine);
            this.groupBox1.Controls.Add(this.btnWhisky);
            this.groupBox1.Controls.Add(this.btnTequila);
            this.groupBox1.Controls.Add(this.btnBeer);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 311);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單 Menu";
            // 
            // btnWine
            // 
            this.btnWine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWine.BackgroundImage = global::HomeWork_1.Properties.Resources.Wine;
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(115, 170);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(94, 106);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT$250";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWhisky.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWhisky.BackgroundImage = global::HomeWork_1.Properties.Resources.whisky;
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(15, 170);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(94, 106);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTequila.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTequila.BackgroundImage = global::HomeWork_1.Properties.Resources.Tequila1;
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTequila.Location = new System.Drawing.Point(115, 30);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(94, 106);
            this.btnTequila.TabIndex = 1;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT$150";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBeer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBeer.BackgroundImage = global::HomeWork_1.Properties.Resources.beer;
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(15, 30);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(94, 106);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT$ 120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // Frm_POSn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_POSn";
            this.Text = "Frm_POS01s";
            this.Load += new System.EventHandler(this.Frm_POSn_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncreditCard;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnBeer;
    }
}