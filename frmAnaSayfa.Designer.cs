﻿namespace Personal_takip_1
{
    partial class frmAnaSayfa
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
            btnDepartmanlar = new Button();
            btnPersonelEkle = new Button();
            btnPersonelListele = new Button();
            btnCikisYap = new Button();
            btnMaasZamlari = new Button();
            btnPrimler = new Button();
            SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            btnDepartmanlar.BackColor = SystemColors.ButtonHighlight;
            btnDepartmanlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDepartmanlar.ForeColor = SystemColors.ActiveCaptionText;
            btnDepartmanlar.Location = new Point(50, 50);
            btnDepartmanlar.Name = "btnDepartmanlar";
            btnDepartmanlar.Size = new Size(150, 150);
            btnDepartmanlar.TabIndex = 0;
            btnDepartmanlar.Text = "Departmanlar";
            btnDepartmanlar.UseVisualStyleBackColor = false;
            btnDepartmanlar.Click += btnDepartmanlar_Click;
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.BackColor = SystemColors.ButtonHighlight;
            btnPersonelEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPersonelEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnPersonelEkle.Location = new Point(250, 50);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(150, 150);
            btnPersonelEkle.TabIndex = 1;
            btnPersonelEkle.Text = "Personel Ekleme";
            btnPersonelEkle.UseVisualStyleBackColor = false;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // btnPersonelListele
            // 
            btnPersonelListele.BackColor = SystemColors.ButtonHighlight;
            btnPersonelListele.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPersonelListele.ForeColor = SystemColors.ActiveCaptionText;
            btnPersonelListele.Location = new Point(450, 50);
            btnPersonelListele.Name = "btnPersonelListele";
            btnPersonelListele.Size = new Size(150, 150);
            btnPersonelListele.TabIndex = 2;
            btnPersonelListele.Text = "Personel Listeleme";
            btnPersonelListele.UseVisualStyleBackColor = false;
            btnPersonelListele.Click += btnPersonelListele_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = SystemColors.ActiveCaptionText;
            btnCikisYap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCikisYap.ForeColor = SystemColors.Control;
            btnCikisYap.Location = new Point(551, 206);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(71, 43);
            btnCikisYap.TabIndex = 3;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnMaasZamlari
            // 
            btnMaasZamlari.BackColor = SystemColors.ButtonHighlight;
            btnMaasZamlari.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMaasZamlari.ForeColor = SystemColors.ActiveCaptionText;
            btnMaasZamlari.Location = new Point(650, 50);
            btnMaasZamlari.Name = "btnMaasZamlari";
            btnMaasZamlari.Size = new Size(150, 150);
            btnMaasZamlari.TabIndex = 2;
            btnMaasZamlari.Text = "Maaş Zamları";
            btnMaasZamlari.UseVisualStyleBackColor = false;
            btnMaasZamlari.Click += btnMaasZamlari_Click;
            // 
            // btnPrimler
            // 
            btnPrimler.BackColor = SystemColors.ButtonHighlight;
            btnPrimler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrimler.ForeColor = SystemColors.ActiveCaptionText;
            btnPrimler.Location = new Point(50, 227);
            btnPrimler.Name = "btnPrimler";
            btnPrimler.Size = new Size(150, 150);
            btnPrimler.TabIndex = 4;
            btnPrimler.Text = "Primler";
            btnPrimler.UseVisualStyleBackColor = false;
            btnPrimler.Click += btnPrimler_Click;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 420);
            Controls.Add(btnPrimler);
            Controls.Add(btnCikisYap);
            Controls.Add(btnMaasZamlari);
            Controls.Add(btnPersonelListele);
            Controls.Add(btnPersonelEkle);
            Controls.Add(btnDepartmanlar);
            Name = "frmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmAnaSayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDepartmanlar;
        private Button btnPersonelEkle;
        private Button btnPersonelListele;
        private Button btnCikisYap;
        private Button btnMaasZamlari;
        private Button btnPrimler;
    }
}