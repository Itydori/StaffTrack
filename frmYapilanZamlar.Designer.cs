namespace Personal_takip_1
{
    partial class frmYapilanZamlar
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
            radioYuzde = new RadioButton();
            radioFiyat = new RadioButton();
            txtFiyat = new TextBox();
            txtYuzde = new TextBox();
            txtAciklama = new TextBox();
            comboAy = new ComboBox();
            comboYil = new ComboBox();
            comboPersoneller = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblPersonelID = new Label();
            btnOnay = new Button();
            btnCikis = new Button();
            comboDepartman = new ComboBox();
            label7 = new Label();
            lblDepartmanID = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioYuzde
            // 
            radioYuzde.AutoSize = true;
            radioYuzde.Location = new Point(149, 97);
            radioYuzde.Name = "radioYuzde";
            radioYuzde.Size = new Size(112, 23);
            radioYuzde.TabIndex = 0;
            radioYuzde.TabStop = true;
            radioYuzde.Text = "Yüzdeye Göre";
            radioYuzde.UseVisualStyleBackColor = true;
            radioYuzde.CheckedChanged += radioYuzde_CheckedChanged;
            // 
            // radioFiyat
            // 
            radioFiyat.AutoSize = true;
            radioFiyat.Location = new Point(299, 97);
            radioFiyat.Name = "radioFiyat";
            radioFiyat.Size = new Size(97, 23);
            radioFiyat.TabIndex = 1;
            radioFiyat.TabStop = true;
            radioFiyat.Text = "Fiyata Göre";
            radioFiyat.UseVisualStyleBackColor = true;
            radioFiyat.CheckedChanged += radioFiyat_CheckedChanged;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(160, 305);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(236, 26);
            txtFiyat.TabIndex = 2;
            // 
            // txtYuzde
            // 
            txtYuzde.Location = new Point(160, 261);
            txtYuzde.Name = "txtYuzde";
            txtYuzde.Size = new Size(236, 26);
            txtYuzde.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(160, 349);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(236, 70);
            txtAciklama.TabIndex = 4;
            // 
            // comboAy
            // 
            comboAy.FormattingEnabled = true;
            comboAy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboAy.Location = new Point(160, 171);
            comboAy.Name = "comboAy";
            comboAy.Size = new Size(101, 27);
            comboAy.TabIndex = 5;
            // 
            // comboYil
            // 
            comboYil.FormattingEnabled = true;
            comboYil.Items.AddRange(new object[] { "Tüm Personeller" });
            comboYil.Location = new Point(295, 171);
            comboYil.Name = "comboYil";
            comboYil.Size = new Size(101, 27);
            comboYil.TabIndex = 5;
            // 
            // comboPersoneller
            // 
            comboPersoneller.FormattingEnabled = true;
            comboPersoneller.Items.AddRange(new object[] { "Tüm Personeller" });
            comboPersoneller.Location = new Point(160, 216);
            comboPersoneller.Name = "comboPersoneller";
            comboPersoneller.Size = new Size(178, 27);
            comboPersoneller.TabIndex = 6;
            comboPersoneller.SelectedIndexChanged += comboPersoneller_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 172);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 7;
            label1.Text = "Dönem:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 218);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 7;
            label2.Text = "Personeller:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 264);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 7;
            label3.Text = "Yüzde (%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 310);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 7;
            label4.Text = "Fiyat (TL):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 356);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 7;
            label5.Text = "Açıklama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 179);
            label6.Name = "label6";
            label6.Size = new Size(14, 19);
            label6.TabIndex = 8;
            label6.Text = "/";
            // 
            // lblPersonelID
            // 
            lblPersonelID.AutoSize = true;
            lblPersonelID.Location = new Point(379, 224);
            lblPersonelID.Name = "lblPersonelID";
            lblPersonelID.Size = new Size(17, 19);
            lblPersonelID.TabIndex = 9;
            lblPersonelID.Text = "0";
            lblPersonelID.Click += label7_Click;
            // 
            // btnOnay
            // 
            btnOnay.Location = new Point(473, 163);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(100, 80);
            btnOnay.TabIndex = 10;
            btnOnay.Text = "Onay";
            btnOnay.UseVisualStyleBackColor = true;
            btnOnay.Click += btnOnay_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(476, 295);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 80);
            btnCikis.TabIndex = 10;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // comboDepartman
            // 
            comboDepartman.FormattingEnabled = true;
            comboDepartman.Location = new Point(160, 131);
            comboDepartman.Name = "comboDepartman";
            comboDepartman.Size = new Size(121, 27);
            comboDepartman.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 134);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 12;
            label7.Text = "Departman:";
            // 
            // lblDepartmanID
            // 
            lblDepartmanID.AutoSize = true;
            lblDepartmanID.Location = new Point(379, 139);
            lblDepartmanID.Name = "lblDepartmanID";
            lblDepartmanID.Size = new Size(17, 19);
            lblDepartmanID.TabIndex = 13;
            lblDepartmanID.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(476, 68);
            button1.Name = "button1";
            button1.Size = new Size(100, 80);
            button1.TabIndex = 14;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmYapilanZamlar
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblDepartmanID);
            Controls.Add(label7);
            Controls.Add(comboDepartman);
            Controls.Add(btnCikis);
            Controls.Add(btnOnay);
            Controls.Add(lblPersonelID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboPersoneller);
            Controls.Add(comboYil);
            Controls.Add(comboAy);
            Controls.Add(txtAciklama);
            Controls.Add(txtYuzde);
            Controls.Add(txtFiyat);
            Controls.Add(radioFiyat);
            Controls.Add(radioYuzde);
            Name = "frmYapilanZamlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Personel Zam Hareketleri";
            Load += frmYapilanZamlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioYuzde;
        private RadioButton radioFiyat;
        private TextBox txtFiyat;
        private TextBox txtYuzde;
        private TextBox txtAciklama;
        private ComboBox comboAy;
        private ComboBox comboYil;
        private ComboBox comboPersoneller;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPersonelID;
        private Button btnOnay;
        private Button btnCikis;
        private ComboBox comboDepartman;
        private Label label7;
        private Label lblDepartmanID;
        private Button button1;
    }
}