namespace Kronometre
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ÜstSalise = new System.Windows.Forms.Label();
            this.ÜstSaniye = new System.Windows.Forms.Label();
            this.ÜstDakika = new System.Windows.Forms.Label();
            this.ÜstSaat = new System.Windows.Forms.Label();
            this.AltSalise = new System.Windows.Forms.Label();
            this.AltSaniye = new System.Windows.Forms.Label();
            this.AltDakika = new System.Windows.Forms.Label();
            this.AltSaat = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ss";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ss";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ÜstSalise
            // 
            this.ÜstSalise.AutoSize = true;
            this.ÜstSalise.Location = new System.Drawing.Point(403, 120);
            this.ÜstSalise.Name = "ÜstSalise";
            this.ÜstSalise.Size = new System.Drawing.Size(13, 13);
            this.ÜstSalise.TabIndex = 12;
            this.ÜstSalise.Text = "0";
            // 
            // ÜstSaniye
            // 
            this.ÜstSaniye.AutoSize = true;
            this.ÜstSaniye.Location = new System.Drawing.Point(315, 120);
            this.ÜstSaniye.Name = "ÜstSaniye";
            this.ÜstSaniye.Size = new System.Drawing.Size(13, 13);
            this.ÜstSaniye.TabIndex = 11;
            this.ÜstSaniye.Text = "0";
            // 
            // ÜstDakika
            // 
            this.ÜstDakika.AutoSize = true;
            this.ÜstDakika.Location = new System.Drawing.Point(230, 120);
            this.ÜstDakika.Name = "ÜstDakika";
            this.ÜstDakika.Size = new System.Drawing.Size(13, 13);
            this.ÜstDakika.TabIndex = 10;
            this.ÜstDakika.Text = "0";
            // 
            // ÜstSaat
            // 
            this.ÜstSaat.AutoSize = true;
            this.ÜstSaat.Location = new System.Drawing.Point(153, 120);
            this.ÜstSaat.Name = "ÜstSaat";
            this.ÜstSaat.Size = new System.Drawing.Size(13, 13);
            this.ÜstSaat.TabIndex = 9;
            this.ÜstSaat.Text = "0";
            // 
            // AltSalise
            // 
            this.AltSalise.AutoSize = true;
            this.AltSalise.Location = new System.Drawing.Point(403, 199);
            this.AltSalise.Name = "AltSalise";
            this.AltSalise.Size = new System.Drawing.Size(13, 13);
            this.AltSalise.TabIndex = 16;
            this.AltSalise.Text = "0";
            // 
            // AltSaniye
            // 
            this.AltSaniye.AutoSize = true;
            this.AltSaniye.Location = new System.Drawing.Point(315, 199);
            this.AltSaniye.Name = "AltSaniye";
            this.AltSaniye.Size = new System.Drawing.Size(13, 13);
            this.AltSaniye.TabIndex = 15;
            this.AltSaniye.Text = "0";
            // 
            // AltDakika
            // 
            this.AltDakika.AutoSize = true;
            this.AltDakika.Location = new System.Drawing.Point(230, 199);
            this.AltDakika.Name = "AltDakika";
            this.AltDakika.Size = new System.Drawing.Size(13, 13);
            this.AltDakika.TabIndex = 14;
            this.AltDakika.Text = "0";
            // 
            // AltSaat
            // 
            this.AltSaat.AutoSize = true;
            this.AltSaat.Location = new System.Drawing.Point(153, 199);
            this.AltSaat.Name = "AltSaat";
            this.AltSaat.Size = new System.Drawing.Size(13, 13);
            this.AltSaat.TabIndex = 13;
            this.AltSaat.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AltSalise);
            this.Controls.Add(this.AltSaniye);
            this.Controls.Add(this.AltDakika);
            this.Controls.Add(this.AltSaat);
            this.Controls.Add(this.ÜstSalise);
            this.Controls.Add(this.ÜstSaniye);
            this.Controls.Add(this.ÜstDakika);
            this.Controls.Add(this.ÜstSaat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "se";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ÜstSalise;
        private System.Windows.Forms.Label ÜstSaniye;
        private System.Windows.Forms.Label ÜstDakika;
        private System.Windows.Forms.Label ÜstSaat;
        private System.Windows.Forms.Label AltSalise;
        private System.Windows.Forms.Label AltSaniye;
        private System.Windows.Forms.Label AltDakika;
        private System.Windows.Forms.Label AltSaat;
        private System.Windows.Forms.Timer timer2;
    }
}

