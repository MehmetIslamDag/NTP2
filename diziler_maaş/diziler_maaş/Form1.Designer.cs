
namespace diziler_maaş
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEnYuksek = new System.Windows.Forms.Button();
            this.btnEnDusuk = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMaaş = new System.Windows.Forms.TextBox();
            this.lbAdSoyad = new System.Windows.Forms.Label();
            this.lbMaaş = new System.Windows.Forms.Label();
            this.txtEnYuksek = new System.Windows.Forms.TextBox();
            this.txtEnDusuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.btnToplam = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(275, 273);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEnYuksek
            // 
            this.btnEnYuksek.Location = new System.Drawing.Point(7, 269);
            this.btnEnYuksek.Name = "btnEnYuksek";
            this.btnEnYuksek.Size = new System.Drawing.Size(75, 23);
            this.btnEnYuksek.TabIndex = 2;
            this.btnEnYuksek.Text = "EnYuksek";
            this.btnEnYuksek.UseVisualStyleBackColor = true;
            this.btnEnYuksek.Click += new System.EventHandler(this.btnEnYuksek_Click);
            // 
            // btnEnDusuk
            // 
            this.btnEnDusuk.Location = new System.Drawing.Point(7, 321);
            this.btnEnDusuk.Name = "btnEnDusuk";
            this.btnEnDusuk.Size = new System.Drawing.Size(75, 23);
            this.btnEnDusuk.TabIndex = 3;
            this.btnEnDusuk.Text = "EnDusuk";
            this.btnEnDusuk.UseVisualStyleBackColor = true;
            this.btnEnDusuk.Click += new System.EventHandler(this.btnEnDusuk_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(275, 244);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(71, 92);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // txtMaaş
            // 
            this.txtMaaş.Location = new System.Drawing.Point(71, 130);
            this.txtMaaş.Name = "txtMaaş";
            this.txtMaaş.Size = new System.Drawing.Size(100, 20);
            this.txtMaaş.TabIndex = 6;
            // 
            // lbAdSoyad
            // 
            this.lbAdSoyad.AutoSize = true;
            this.lbAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdSoyad.Location = new System.Drawing.Point(4, 92);
            this.lbAdSoyad.Name = "lbAdSoyad";
            this.lbAdSoyad.Size = new System.Drawing.Size(70, 15);
            this.lbAdSoyad.TabIndex = 7;
            this.lbAdSoyad.Text = "AdSoyad :";
            // 
            // lbMaaş
            // 
            this.lbMaaş.AutoSize = true;
            this.lbMaaş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMaaş.Location = new System.Drawing.Point(13, 131);
            this.lbMaaş.Name = "lbMaaş";
            this.lbMaaş.Size = new System.Drawing.Size(50, 15);
            this.lbMaaş.TabIndex = 8;
            this.lbMaaş.Text = "Maaş :";
            // 
            // txtEnYuksek
            // 
            this.txtEnYuksek.Location = new System.Drawing.Point(126, 269);
            this.txtEnYuksek.Name = "txtEnYuksek";
            this.txtEnYuksek.Size = new System.Drawing.Size(100, 20);
            this.txtEnYuksek.TabIndex = 9;
            // 
            // txtEnDusuk
            // 
            this.txtEnDusuk.Location = new System.Drawing.Point(126, 321);
            this.txtEnDusuk.Name = "txtEnDusuk";
            this.txtEnDusuk.Size = new System.Drawing.Size(100, 20);
            this.txtEnDusuk.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(229, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Maaş\'ı 2000\'den Az Olanlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(397, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Maaş\'ı 50.000-70.000 Arası Olanlar :";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(126, 381);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(100, 20);
            this.txtToplam.TabIndex = 16;
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(12, 366);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(75, 48);
            this.btnToplam.TabIndex = 17;
            this.btnToplam.Text = "Toplam Verilen Maaş";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(259, 143);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 95);
            this.lbListe.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnDusuk);
            this.Controls.Add(this.txtEnYuksek);
            this.Controls.Add(this.lbMaaş);
            this.Controls.Add(this.lbAdSoyad);
            this.Controls.Add(this.txtMaaş);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEnDusuk);
            this.Controls.Add(this.btnEnYuksek);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEnYuksek;
        private System.Windows.Forms.Button btnEnDusuk;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtMaaş;
        private System.Windows.Forms.Label lbAdSoyad;
        private System.Windows.Forms.Label lbMaaş;
        private System.Windows.Forms.TextBox txtEnYuksek;
        private System.Windows.Forms.TextBox txtEnDusuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.TextBox textBox1;
    }
}

