namespace ArrayList_Uyg
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnArayaEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            this.ListeSehirler = new System.Windows.Forms.ListBox();
            this.txtSehirler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 151);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 44);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnArayaEkle
            // 
            this.btnArayaEkle.Location = new System.Drawing.Point(109, 151);
            this.btnArayaEkle.Name = "btnArayaEkle";
            this.btnArayaEkle.Size = new System.Drawing.Size(91, 44);
            this.btnArayaEkle.TabIndex = 1;
            this.btnArayaEkle.Text = "ArayaEkle";
            this.btnArayaEkle.UseVisualStyleBackColor = true;
            this.btnArayaEkle.Click += new System.EventHandler(this.btnArayaEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(206, 151);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(91, 44);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(303, 151);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 44);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(400, 151);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(91, 44);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şehirler";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(99, 261);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(75, 25);
            this.labelDurum.TabIndex = 6;
            this.labelDurum.Text = "Durum";
            // 
            // ListeSehirler
            // 
            this.ListeSehirler.FormattingEnabled = true;
            this.ListeSehirler.ItemHeight = 16;
            this.ListeSehirler.Location = new System.Drawing.Point(680, 118);
            this.ListeSehirler.Name = "ListeSehirler";
            this.ListeSehirler.Size = new System.Drawing.Size(120, 164);
            this.ListeSehirler.TabIndex = 7;
            // 
            // txtSehirler
            // 
            this.txtSehirler.Location = new System.Drawing.Point(156, 53);
            this.txtSehirler.Name = "txtSehirler";
            this.txtSehirler.Size = new System.Drawing.Size(100, 22);
            this.txtSehirler.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSehirler);
            this.Controls.Add(this.ListeSehirler);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnArayaEkle);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnArayaEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.ListBox ListeSehirler;
        private System.Windows.Forms.TextBox txtSehirler;
    }
}

