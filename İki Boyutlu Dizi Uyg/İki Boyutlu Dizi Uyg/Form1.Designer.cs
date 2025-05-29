namespace İki_Boyutlu_Dizi_Uyg
{
    partial class Form1
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
            this.txtRasgeleMin = new System.Windows.Forms.TextBox();
            this.txtSutunSayısı = new System.Windows.Forms.TextBox();
            this.txtRasgeleMax = new System.Windows.Forms.TextBox();
            this.txtSatırSayısı = new System.Windows.Forms.TextBox();
            this.btnDiziOluştur = new System.Windows.Forms.Button();
            this.btnDiziGöster = new System.Windows.Forms.Button();
            this.listDizi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizi Satır Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dizi Sutün Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rasgee En Düşük Sayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rasgele En Yüksek Sayı";
            // 
            // txtRasgeleMin
            // 
            this.txtRasgeleMin.Location = new System.Drawing.Point(261, 124);
            this.txtRasgeleMin.Name = "txtRasgeleMin";
            this.txtRasgeleMin.Size = new System.Drawing.Size(100, 22);
            this.txtRasgeleMin.TabIndex = 4;
            // 
            // txtSutunSayısı
            // 
            this.txtSutunSayısı.Location = new System.Drawing.Point(261, 90);
            this.txtSutunSayısı.Name = "txtSutunSayısı";
            this.txtSutunSayısı.Size = new System.Drawing.Size(100, 22);
            this.txtSutunSayısı.TabIndex = 5;
            // 
            // txtRasgeleMax
            // 
            this.txtRasgeleMax.Location = new System.Drawing.Point(261, 161);
            this.txtRasgeleMax.Name = "txtRasgeleMax";
            this.txtRasgeleMax.Size = new System.Drawing.Size(100, 22);
            this.txtRasgeleMax.TabIndex = 6;
            // 
            // txtSatırSayısı
            // 
            this.txtSatırSayısı.Location = new System.Drawing.Point(261, 59);
            this.txtSatırSayısı.Name = "txtSatırSayısı";
            this.txtSatırSayısı.Size = new System.Drawing.Size(100, 22);
            this.txtSatırSayısı.TabIndex = 7;
            // 
            // btnDiziOluştur
            // 
            this.btnDiziOluştur.Location = new System.Drawing.Point(131, 339);
            this.btnDiziOluştur.Name = "btnDiziOluştur";
            this.btnDiziOluştur.Size = new System.Drawing.Size(86, 23);
            this.btnDiziOluştur.TabIndex = 8;
            this.btnDiziOluştur.Text = "Dizi Oluştur";
            this.btnDiziOluştur.UseVisualStyleBackColor = true;
            this.btnDiziOluştur.Click += new System.EventHandler(this.btnDiziOluştur_Click);
            // 
            // btnDiziGöster
            // 
            this.btnDiziGöster.Location = new System.Drawing.Point(501, 38);
            this.btnDiziGöster.Name = "btnDiziGöster";
            this.btnDiziGöster.Size = new System.Drawing.Size(86, 23);
            this.btnDiziGöster.TabIndex = 9;
            this.btnDiziGöster.Text = "Dizi Göster";
            this.btnDiziGöster.UseVisualStyleBackColor = true;
            this.btnDiziGöster.Click += new System.EventHandler(this.btnDiziGöster_Click);
            // 
            // listDizi
            // 
            this.listDizi.FormattingEnabled = true;
            this.listDizi.ItemHeight = 16;
            this.listDizi.Location = new System.Drawing.Point(466, 145);
            this.listDizi.Name = "listDizi";
            this.listDizi.Size = new System.Drawing.Size(120, 148);
            this.listDizi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listDizi);
            this.Controls.Add(this.btnDiziGöster);
            this.Controls.Add(this.btnDiziOluştur);
            this.Controls.Add(this.txtSatırSayısı);
            this.Controls.Add(this.txtRasgeleMax);
            this.Controls.Add(this.txtSutunSayısı);
            this.Controls.Add(this.txtRasgeleMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRasgeleMin;
        private System.Windows.Forms.TextBox txtSutunSayısı;
        private System.Windows.Forms.TextBox txtRasgeleMax;
        private System.Windows.Forms.TextBox txtSatırSayısı;
        private System.Windows.Forms.Button btnDiziOluştur;
        private System.Windows.Forms.Button btnDiziGöster;
        private System.Windows.Forms.ListBox listDizi;
    }
}

