using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_takip_1
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDepartmanlar_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.ShowDialog();
        }


        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmKullanici k = new frmKullanici();
            k.ShowDialog();
            if (frmKullanici.dilIngilizce)
            {
                btnDepartmanlar.Text = "Departments";
                btnPersonelEkle.Text = "Add Personnel";
                btnPersonelListele.Text = "List Personnel";
                btnMaasZamlari.Text = "Wage Increases";
                btnPrimler.Text = "Bonuses";
                btnCikisYap.Text = "Log Out";
            }
            else
            {
                btnDepartmanlar.Text = "Departmanlar";
                btnPersonelEkle.Text = "Personel Ekle";
                btnPersonelListele.Text = "Personel Listele";
                btnMaasZamlari.Text = "Maaş Zamları";
                btnPrimler.Text = "Primler";
                btnCikisYap.Text = "Çıkış Yap";
            }
        }


            private void btnCikisYap_Click(object sender, EventArgs e)
            {
                frmKullanici frm = new frmKullanici();
                frm.Show();
                this.Hide();
            }

            private void btnMaasZamlari_Click(object sender, EventArgs e)
            {
                frmYapilanZamlar frm = new frmYapilanZamlar();
                frm.ShowDialog();
            }

            private void btnPrimler_Click(object sender, EventArgs e)
            {
                frmPrimEkle frm = new frmPrimEkle();
                frm.ShowDialog();
            }
        }
    }
