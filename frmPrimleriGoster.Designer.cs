namespace Personal_takip_1
{
    partial class frmPrimleriGoster
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
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboYil = new ComboBox();
            comboAy = new ComboBox();
            txtAciklama = new TextBox();
            txtPrimTutari = new TextBox();
            txtPersonelAdSoyad = new TextBox();
            txtPersonelID = new TextBox();
            txtPrimID = new TextBox();
            label7 = new Label();
            btnTumPrimleriOde = new Button();
            btnPrimOde = new Button();
            btnPrimiGuncelle = new Button();
            btnPrimSil = new Button();
            btnDonemDegistir = new Button();
            btnTumPrimleriOdenmediYapma = new Button();
            btnTemizle = new Button();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(897, 407);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 432);
            label6.Name = "label6";
            label6.Size = new Size(14, 19);
            label6.TabIndex = 41;
            label6.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 508);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 36;
            label5.Text = "Açıklama:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 473);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 37;
            label4.Text = "Prim Tutarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 470);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 38;
            label3.Text = "Personel ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 510);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 39;
            label2.Text = "Personel Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 426);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 40;
            label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            comboYil.FormattingEnabled = true;
            comboYil.Items.AddRange(new object[] { "Tüm Personeller" });
            comboYil.Location = new Point(562, 423);
            comboYil.Name = "comboYil";
            comboYil.Size = new Size(72, 27);
            comboYil.TabIndex = 34;
            // 
            // comboAy
            // 
            comboAy.FormattingEnabled = true;
            comboAy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboAy.Location = new Point(438, 423);
            comboAy.Name = "comboAy";
            comboAy.Size = new Size(72, 27);
            comboAy.TabIndex = 35;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(438, 505);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(368, 58);
            txtAciklama.TabIndex = 30;
            // 
            // txtPrimTutari
            // 
            txtPrimTutari.Location = new Point(438, 469);
            txtPrimTutari.Name = "txtPrimTutari";
            txtPrimTutari.Size = new Size(236, 26);
            txtPrimTutari.TabIndex = 31;
            // 
            // txtPersonelAdSoyad
            // 
            txtPersonelAdSoyad.Location = new Point(147, 505);
            txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            txtPersonelAdSoyad.Size = new Size(196, 26);
            txtPersonelAdSoyad.TabIndex = 32;
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(147, 464);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(196, 26);
            txtPersonelID.TabIndex = 33;
            txtPersonelID.TextChanged += txtPersonelID_TextChanged;
            // 
            // txtPrimID
            // 
            txtPrimID.Location = new Point(147, 423);
            txtPrimID.Name = "txtPrimID";
            txtPrimID.Size = new Size(196, 26);
            txtPrimID.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 430);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 38;
            label7.Text = "Prim ID:";
            // 
            // btnTumPrimleriOde
            // 
            btnTumPrimleriOde.Location = new Point(16, 579);
            btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            btnTumPrimleriOde.Size = new Size(126, 50);
            btnTumPrimleriOde.TabIndex = 42;
            btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            btnTumPrimleriOde.UseVisualStyleBackColor = true;
            btnTumPrimleriOde.Click += btnTumPrimleriOde_Click;
            // 
            // btnPrimOde
            // 
            btnPrimOde.Location = new Point(148, 579);
            btnPrimOde.Name = "btnPrimOde";
            btnPrimOde.Size = new Size(126, 50);
            btnPrimOde.TabIndex = 42;
            btnPrimOde.Text = "Seçili Primi Öde";
            btnPrimOde.UseVisualStyleBackColor = true;
            btnPrimOde.Click += btnPrimOde_Click;
            // 
            // btnPrimiGuncelle
            // 
            btnPrimiGuncelle.Location = new Point(280, 579);
            btnPrimiGuncelle.Name = "btnPrimiGuncelle";
            btnPrimiGuncelle.Size = new Size(126, 50);
            btnPrimiGuncelle.TabIndex = 42;
            btnPrimiGuncelle.Text = "Prim Güncelle";
            btnPrimiGuncelle.UseVisualStyleBackColor = true;
            btnPrimiGuncelle.Click += btnPrimiGuncelle_Click;
            // 
            // btnPrimSil
            // 
            btnPrimSil.Location = new Point(411, 579);
            btnPrimSil.Name = "btnPrimSil";
            btnPrimSil.Size = new Size(126, 50);
            btnPrimSil.TabIndex = 42;
            btnPrimSil.Text = "Prim Sil";
            btnPrimSil.UseVisualStyleBackColor = true;
            btnPrimSil.Click += btnPrimSil_Click;
            // 
            // btnDonemDegistir
            // 
            btnDonemDegistir.Location = new Point(689, 423);
            btnDonemDegistir.Name = "btnDonemDegistir";
            btnDonemDegistir.Size = new Size(117, 67);
            btnDonemDegistir.TabIndex = 42;
            btnDonemDegistir.Text = "Dönem Değiştir";
            btnDonemDegistir.UseVisualStyleBackColor = true;
            btnDonemDegistir.Click += btnDonemDegistir_Click;
            // 
            // btnTumPrimleriOdenmediYapma
            // 
            btnTumPrimleriOdenmediYapma.Location = new Point(812, 423);
            btnTumPrimleriOdenmediYapma.Name = "btnTumPrimleriOdenmediYapma";
            btnTumPrimleriOdenmediYapma.Size = new Size(85, 85);
            btnTumPrimleriOdenmediYapma.TabIndex = 43;
            btnTumPrimleriOdenmediYapma.Text = "Tum Primleri Odenmedi Yapma";
            btnTumPrimleriOdenmediYapma.UseVisualStyleBackColor = true;
            btnTumPrimleriOdenmediYapma.Click += btnTumPrimleriOdenmediYapma_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(548, 579);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(126, 50);
            btnTemizle.TabIndex = 44;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(680, 579);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(126, 50);
            btnCikis.TabIndex = 45;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmPrimleriGoster
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 641);
            Controls.Add(btnCikis);
            Controls.Add(btnTemizle);
            Controls.Add(btnTumPrimleriOdenmediYapma);
            Controls.Add(btnDonemDegistir);
            Controls.Add(btnPrimSil);
            Controls.Add(btnPrimOde);
            Controls.Add(btnPrimiGuncelle);
            Controls.Add(btnTumPrimleriOde);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboYil);
            Controls.Add(comboAy);
            Controls.Add(txtAciklama);
            Controls.Add(txtPrimTutari);
            Controls.Add(txtPersonelAdSoyad);
            Controls.Add(txtPrimID);
            Controls.Add(txtPersonelID);
            Controls.Add(dataGridView1);
            Name = "frmPrimleriGoster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Tüm Personellerin Primleri";
            Load += frmPrimleriGoster_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboYil;
        private ComboBox comboAy;
        private TextBox txtAciklama;
        private TextBox txtPrimTutari;
        private TextBox txtPersonelAdSoyad;
        private TextBox txtPersonelID;
        private TextBox txtPrimID;
        private Label label7;
        private Button btnTumPrimleriOde;
        private Button btnPrimOde;
        private Button btnPrimiGuncelle;
        private Button btnPrimSil;
        private Button btnDonemDegistir;
        private Button btnTumPrimleriOdenmediYapma;
        private Button btnTemizle;
        private Button btnCikis;
    }
}