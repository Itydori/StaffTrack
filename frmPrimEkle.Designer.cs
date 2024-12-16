namespace Personal_takip_1
{
    partial class frmPrimEkle
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
            txtPersonelID = new TextBox();
            txtPersonelAdSoyad = new TextBox();
            radioKisiyeOzel = new RadioButton();
            radioTumPersoneller = new RadioButton();
            label6 = new Label();
            label1 = new Label();
            comboYil = new ComboBox();
            comboAy = new ComboBox();
            txtPrimTutari = new TextBox();
            txtAciklama = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPrimEkle = new Button();
            btnPrimleriGoster = new Button();
            btnPersoneleGörePrim = new Button();
            btnCikis = new Button();
            btnTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(139, 55);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(196, 26);
            txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            txtPersonelAdSoyad.Location = new Point(139, 100);
            txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            txtPersonelAdSoyad.Size = new Size(196, 26);
            txtPersonelAdSoyad.TabIndex = 0;
            // 
            // radioKisiyeOzel
            // 
            radioKisiyeOzel.AutoSize = true;
            radioKisiyeOzel.Location = new Point(139, 12);
            radioKisiyeOzel.Name = "radioKisiyeOzel";
            radioKisiyeOzel.Size = new Size(124, 23);
            radioKisiyeOzel.TabIndex = 1;
            radioKisiyeOzel.TabStop = true;
            radioKisiyeOzel.Text = "Kişiye Özel Prim";
            radioKisiyeOzel.UseVisualStyleBackColor = true;
            radioKisiyeOzel.CheckedChanged += radioKisiyeOzel_CheckedChanged;
            // 
            // radioTumPersoneller
            // 
            radioTumPersoneller.AutoSize = true;
            radioTumPersoneller.Location = new Point(461, 12);
            radioTumPersoneller.Name = "radioTumPersoneller";
            radioTumPersoneller.Size = new Size(149, 23);
            radioTumPersoneller.TabIndex = 2;
            radioTumPersoneller.TabStop = true;
            radioTumPersoneller.Text = "Tüm Personeller İçin";
            radioTumPersoneller.UseVisualStyleBackColor = true;
            radioTumPersoneller.Visible = false;
            radioTumPersoneller.CheckedChanged += radioTumPersoneller_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 148);
            label6.Name = "label6";
            label6.Size = new Size(14, 19);
            label6.TabIndex = 12;
            label6.Text = "/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 150);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 11;
            label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            comboYil.FormattingEnabled = true;
            comboYil.Items.AddRange(new object[] { "Tüm Personeller" });
            comboYil.Location = new Point(263, 145);
            comboYil.Name = "comboYil";
            comboYil.Size = new Size(72, 27);
            comboYil.TabIndex = 9;
            // 
            // comboAy
            // 
            comboAy.FormattingEnabled = true;
            comboAy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboAy.Location = new Point(139, 145);
            comboAy.Name = "comboAy";
            comboAy.Size = new Size(72, 27);
            comboAy.TabIndex = 10;
            // 
            // txtPrimTutari
            // 
            txtPrimTutari.Location = new Point(139, 191);
            txtPrimTutari.Name = "txtPrimTutari";
            txtPrimTutari.Size = new Size(236, 26);
            txtPrimTutari.TabIndex = 0;
            txtPrimTutari.TextChanged += txtPrimTutari_TextChanged;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(461, 55);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(236, 58);
            txtAciklama.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(714, 189);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 106);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 11;
            label2.Text = "Personel Ad Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 62);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 11;
            label3.Text = "Personel ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 194);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 11;
            label4.Text = "Prim Tutarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 55);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 11;
            label5.Text = "Açıklama:";
            // 
            // btnPrimEkle
            // 
            btnPrimEkle.Location = new Point(461, 125);
            btnPrimEkle.Name = "btnPrimEkle";
            btnPrimEkle.Size = new Size(236, 92);
            btnPrimEkle.TabIndex = 14;
            btnPrimEkle.Text = "Prim Ekle";
            btnPrimEkle.UseVisualStyleBackColor = true;
            btnPrimEkle.Click += btnPrimEkle_Click;
            // 
            // btnPrimleriGoster
            // 
            btnPrimleriGoster.Location = new Point(8, 247);
            btnPrimleriGoster.Name = "btnPrimleriGoster";
            btnPrimleriGoster.Size = new Size(122, 49);
            btnPrimleriGoster.TabIndex = 14;
            btnPrimleriGoster.Text = "Prim Göster";
            btnPrimleriGoster.UseVisualStyleBackColor = true;
            btnPrimleriGoster.Click += btnPrimleriGoster_Click;
            // 
            // btnPersoneleGörePrim
            // 
            btnPersoneleGörePrim.Location = new Point(150, 247);
            btnPersoneleGörePrim.Name = "btnPersoneleGörePrim";
            btnPersoneleGörePrim.Size = new Size(122, 49);
            btnPersoneleGörePrim.TabIndex = 14;
            btnPersoneleGörePrim.Text = "Personel Primleri";
            btnPersoneleGörePrim.UseVisualStyleBackColor = true;
            btnPersoneleGörePrim.Click += btnPersoneleGörePrim_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(434, 247);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(122, 49);
            btnCikis.TabIndex = 15;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(292, 247);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(122, 49);
            btnTemizle.TabIndex = 16;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // frmPrimEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 502);
            Controls.Add(btnTemizle);
            Controls.Add(btnCikis);
            Controls.Add(btnPersoneleGörePrim);
            Controls.Add(btnPrimleriGoster);
            Controls.Add(btnPrimEkle);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboYil);
            Controls.Add(comboAy);
            Controls.Add(radioTumPersoneller);
            Controls.Add(radioKisiyeOzel);
            Controls.Add(txtAciklama);
            Controls.Add(txtPrimTutari);
            Controls.Add(txtPersonelAdSoyad);
            Controls.Add(txtPersonelID);
            Name = "frmPrimEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prim Sayfası";
            Load += Primler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonelID;
        private TextBox txtPersonelAdSoyad;
        private RadioButton radioKisiyeOzel;
        private RadioButton radioTumPersoneller;
        private Label label6;
        private Label label1;
        private ComboBox comboYil;
        private ComboBox comboAy;
        private TextBox txtPrimTutari;
        private TextBox txtAciklama;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPrimEkle;
        private Button btnPrimleriGoster;
        private Button btnPersoneleGörePrim;
        private Button btnCikis;
        private Button btnTemizle;
    }
}