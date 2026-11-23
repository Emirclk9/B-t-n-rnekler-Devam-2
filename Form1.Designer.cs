namespace _20TaneSayıyıToplama
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
            this.lstSayılar = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSayılar
            // 
            this.lstSayılar.FormattingEnabled = true;
            this.lstSayılar.Items.AddRange(new object[] {
            "23",
            "34",
            "54",
            "64",
            "34",
            "23",
            "45",
            "345",
            "34",
            "32",
            "45",
            "5",
            "324",
            "32",
            "3",
            "342",
            "65",
            "43",
            "76",
            "43"});
            this.lstSayılar.Location = new System.Drawing.Point(552, 43);
            this.lstSayılar.Name = "lstSayılar";
            this.lstSayılar.Size = new System.Drawing.Size(120, 95);
            this.lstSayılar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Topla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSayılar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSayılar;
        private System.Windows.Forms.Button button1;
    }
}

