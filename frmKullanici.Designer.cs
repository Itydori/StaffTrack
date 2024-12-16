namespace Personal_takip_1
{
    partial class frmKullanici
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            panel1 = new Panel();
            btnEn = new Button();
            lblCikis = new Label();
            lblKullaniciGiris = new Label();
            label1 = new Label();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            btnKullaniciGiris = new Button();
            checkBox1 = new CheckBox();
            lblSifremiUnuttum = new LinkLabel();
            btnKayitOl2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(75, 260);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(250, 26);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(75, 174);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(250, 26);
            txtKullaniciAdi.TabIndex = 0;
            txtKullaniciAdi.TextChanged += txtKullaniciAdi_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnEn);
            panel1.Controls.Add(lblCikis);
            panel1.Controls.Add(lblKullaniciGiris);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 105);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnEn
            // 
            btnEn.BackColor = Color.MidnightBlue;
            btnEn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEn.ForeColor = SystemColors.ButtonHighlight;
            btnEn.Location = new Point(308, 66);
            btnEn.Name = "btnEn";
            btnEn.Size = new Size(80, 39);
            btnEn.TabIndex = 8;
            btnEn.Text = "English";
            btnEn.UseVisualStyleBackColor = false;
            btnEn.Click += btnEn_Click;
            // 
            // lblCikis
            // 
            lblCikis.AutoSize = true;
            lblCikis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCikis.ForeColor = SystemColors.ButtonFace;
            lblCikis.Location = new Point(374, 9);
            lblCikis.Name = "lblCikis";
            lblCikis.Size = new Size(23, 25);
            lblCikis.TabIndex = 0;
            lblCikis.Text = "X";
            lblCikis.Click += lblCikis_Click;
            // 
            // lblKullaniciGiris
            // 
            lblKullaniciGiris.AutoSize = true;
            lblKullaniciGiris.Font = new Font("Segoe UI", 14F);
            lblKullaniciGiris.ForeColor = SystemColors.ButtonFace;
            lblKullaniciGiris.Location = new Point(122, 68);
            lblKullaniciGiris.Name = "lblKullaniciGiris";
            lblKullaniciGiris.Size = new Size(127, 25);
            lblKullaniciGiris.TabIndex = 0;
            lblKullaniciGiris.Text = "Kullanıcı Giriş";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 0;
            label1.Text = "Tynac Software";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblKullaniciAdi.Location = new Point(75, 152);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(98, 20);
            lblKullaniciAdi.TabIndex = 3;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblSifre.Location = new Point(76, 238);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 20);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre:";
            // 
            // btnKullaniciGiris
            // 
            btnKullaniciGiris.BackColor = Color.MidnightBlue;
            btnKullaniciGiris.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKullaniciGiris.ForeColor = SystemColors.ButtonFace;
            btnKullaniciGiris.Location = new Point(75, 335);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(250, 54);
            btnKullaniciGiris.TabIndex = 3;
            btnKullaniciGiris.Text = "Giriş Yap";
            btnKullaniciGiris.UseVisualStyleBackColor = false;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(75, 299);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 23);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblSifremiUnuttum
            // 
            lblSifremiUnuttum.AutoSize = true;
            lblSifremiUnuttum.Font = new Font("Segoe UI Black", 11.25F);
            lblSifremiUnuttum.LinkColor = Color.MidnightBlue;
            lblSifremiUnuttum.Location = new Point(201, 305);
            lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            lblSifremiUnuttum.Size = new Size(131, 20);
            lblSifremiUnuttum.TabIndex = 5;
            lblSifremiUnuttum.TabStop = true;
            lblSifremiUnuttum.Text = "Şifremi Unuttum";
            lblSifremiUnuttum.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnKayitOl2
            // 
            btnKayitOl2.BackColor = Color.MidnightBlue;
            btnKayitOl2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl2.ForeColor = SystemColors.ButtonFace;
            btnKayitOl2.Location = new Point(75, 395);
            btnKayitOl2.Name = "btnKayitOl2";
            btnKayitOl2.Size = new Size(250, 54);
            btnKayitOl2.TabIndex = 4;
            btnKayitOl2.Text = "Kayıt Ol";
            btnKayitOl2.UseVisualStyleBackColor = false;
            btnKayitOl2.Click += btnKayitOl_Click;
            // 
            // frmKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 500);
            Controls.Add(lblSifremiUnuttum);
            Controls.Add(checkBox1);
            Controls.Add(btnKayitOl2);
            Controls.Add(btnKullaniciGiris);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(panel1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKullanici";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı İşlemleri Sayfası";
            Load += frmKullanici_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Olay işleyicileri
        private void txSifre_TextChanged(object sender, EventArgs e)
        {
            // txSifre TextChanged olay işleyicisi
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            // txtKullaniciAdi TextChanged olay işleyicisi
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // btnGiris Click olay işleyicisi
        }

        #endregion

        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Panel panel1;
        private Label lblCikis;
        private Label lblKullaniciGiris;
        private Label label1;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Button btnKullaniciGiris;
        private CheckBox checkBox1;
        private LinkLabel lblSifremiUnuttum;
        private Button btnKayitOl2;
        private Button btnEn;
    }
}
