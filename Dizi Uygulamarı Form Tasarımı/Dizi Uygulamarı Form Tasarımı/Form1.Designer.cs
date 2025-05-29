
namespace Dizi_Uygulamarı_Form_Tasarımı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnEnYüksek = new System.Windows.Forms.Button();
            this.btnEnDüşük = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.txtEnYüksek = new System.Windows.Forms.TextBox();
            this.txtEnDüşük = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(151, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Des Notu :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(255, 128);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(165, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Location = new System.Drawing.Point(255, 184);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(69, 20);
            this.txtDersNotu.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(255, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnEnYüksek
            // 
            this.btnEnYüksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnYüksek.Location = new System.Drawing.Point(255, 276);
            this.btnEnYüksek.Name = "btnEnYüksek";
            this.btnEnYüksek.Size = new System.Drawing.Size(75, 23);
            this.btnEnYüksek.TabIndex = 5;
            this.btnEnYüksek.Text = "EnYüksek";
            this.btnEnYüksek.UseVisualStyleBackColor = true;
            this.btnEnYüksek.Click += new System.EventHandler(this.btnEnYüksek_Click);
            // 
            // btnEnDüşük
            // 
            this.btnEnDüşük.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnDüşük.Location = new System.Drawing.Point(255, 328);
            this.btnEnDüşük.Name = "btnEnDüşük";
            this.btnEnDüşük.Size = new System.Drawing.Size(75, 23);
            this.btnEnDüşük.TabIndex = 6;
            this.btnEnDüşük.Text = "EnDüşük";
            this.btnEnDüşük.UseVisualStyleBackColor = true;
            this.btnEnDüşük.Click += new System.EventHandler(this.btnEnDüşük_Click);
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtalama.Location = new System.Drawing.Point(255, 380);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(75, 23);
            this.btnOrtalama.TabIndex = 7;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // txtEnYüksek
            // 
            this.txtEnYüksek.Location = new System.Drawing.Point(351, 276);
            this.txtEnYüksek.Name = "txtEnYüksek";
            this.txtEnYüksek.Size = new System.Drawing.Size(100, 20);
            this.txtEnYüksek.TabIndex = 8;
            // 
            // txtEnDüşük
            // 
            this.txtEnDüşük.Location = new System.Drawing.Point(351, 328);
            this.txtEnDüşük.Name = "txtEnDüşük";
            this.txtEnDüşük.Size = new System.Drawing.Size(100, 20);
            this.txtEnDüşük.TabIndex = 9;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(351, 382);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 10;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(658, 204);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(90, 35);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(479, 149);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(173, 147);
            this.lbListe.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtEnDüşük);
            this.Controls.Add(this.txtEnYüksek);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.btnEnDüşük);
            this.Controls.Add(this.btnEnYüksek);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDersNotu);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnEnYüksek;
        private System.Windows.Forms.Button btnEnDüşük;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.TextBox txtEnYüksek;
        private System.Windows.Forms.TextBox txtEnDüşük;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lbListe;
    }
}

