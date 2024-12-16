namespace Personal_takip_1
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);
            if (Kullanicilar.durum)
            {

                this.Hide(); // Giriþ yapýldýktan sonra giriþ ekranýný gizler


            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmYeniKullanici frm = new frmYeniKullanici();
            frm.ShowDialog();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static bool dilIngilizce = false; // Varsayýlan dil Türkçe
        private void btnEn_Click(object sender, EventArgs e)
        {

            if (dilIngilizce)
            {
                dilIngilizce = false;
                lblKullaniciAdi.Text = "Kullanýcý Adý";
                lblSifre.Text = "Þifre";
                btnKullaniciGiris.Text = "Giriþ";
                btnKayitOl2.Text = "Kayýt Ol";
                lblSifremiUnuttum.Text = "Þifremi Unuttum";
                lblKullaniciGiris.Text = "Kullanýcý Giriþi";
            }
            else
            {
                dilIngilizce = true;
                lblKullaniciAdi.Text = "Username";
                lblSifre.Text = "Password";
                btnKullaniciGiris.Text = "Login";
                btnKayitOl2.Text = "Sign Up";
                lblSifremiUnuttum.Text = "Forgot Password";
                lblKullaniciGiris.Text = "User Login";
            }
        }
    }
}
