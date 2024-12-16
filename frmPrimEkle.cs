using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_takip_1
{
    public partial class frmPrimEkle : Form
    {
        public frmPrimEkle()
        {
            InitializeComponent();
        }

        private void Primler_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            Veritabanı.Listele_Ara(dataGridView1, "Select PersonelID,Adi,Soyadi,Maasi,GirisTarihi from Personeller");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrimleriGoster_Click(object sender, EventArgs e)
        {
            frmPrimleriGoster frm = new frmPrimleriGoster();
            frm.ShowDialog();
        }
        private void btnPrimEkle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler()
            {
                KullaniciID = Kullanicilar.kid,
                Donem = comboYil.Text + "/" + comboAy.Text,
                PrimTutari = int.Parse(txtPrimTutari.Text),
                Aciklama = txtAciklama.Text,
                Tarih = DateTime.Now
                
            };
            if (radioTumPersoneller.Checked)
            {
                string sql = "Insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih) values (@KullaniciID,@PersonelID, @Donem, @PrimTutari, @Aciklama, @Tarih)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@KullaniciID", p.KullaniciID);
                cmd.Parameters.AddWithValue("@PersonelID", p.PersonelID);
                cmd.Parameters.AddWithValue("@Donem", p.Donem);
                cmd.Parameters.AddWithValue("@PrimTutari", p.PrimTutari);
                cmd.Parameters.AddWithValue("@Aciklama", p.Aciklama);
                cmd.Parameters.AddWithValue("@Tarih", p.Tarih);
                Veritabanı.ESG(cmd, sql);
                MessageBox.Show("İşlem Başarılı Tüm Personele Prim Eklendi", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTemizle.PerformClick();

            }
            else if (radioKisiyeOzel.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtPersonelID.Text) || !int.TryParse(txtPersonelID.Text, out int personelID))
                {
                    MessageBox.Show("Lütfen geçerli bir Personel ID giriniz.", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                p.PersonelID = personelID;
                string sql = "Insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih) values (@KullaniciID, @PersonelID, @Donem, @PrimTutari, @Aciklama, @Tarih)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@KullaniciID", p.KullaniciID);
                cmd.Parameters.AddWithValue("@PersonelID", p.PersonelID);
                cmd.Parameters.AddWithValue("@Donem", p.Donem);
                cmd.Parameters.AddWithValue("@PrimTutari", p.PrimTutari);
                cmd.Parameters.AddWithValue("@Aciklama", p.Aciklama);
                cmd.Parameters.AddWithValue("@Tarih", p.Tarih);
                Veritabanı.ESG(cmd, sql);
                MessageBox.Show("İşlem Başarılı Personele Prim Eklendi", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTemizle.PerformClick();
            }
            

            //if (radioKisiyeOzel.Checked)
            //{
            //    if (string.IsNullOrWhiteSpace(txtPersonelID.Text) || !int.TryParse(txtPersonelID.Text, out int personelID))
            //    {
            //        MessageBox.Show("Lütfen geçerli bir Personel ID giriniz.", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

                //    if (string.IsNullOrWhiteSpace(txtPrimTutari.Text) || !decimal.TryParse(txtPrimTutari.Text, out decimal primTutari))
                //    {
                //        MessageBox.Show("Lütfen geçerli bir Prim Tutarı giriniz.", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }

                //    Primler p = new Primler
                //    {
                //        KullaniciID = Kullanicilar.kid,
                //        PersonelID = personelID,
                //        Donem = comboYil.Text + "/" + comboAy.Text,
                //        PrimTutari = (int)primTutari,
                //        Aciklama = txtAciklama.Text,
                //        Tarih = DateTime.Now
                //    };

                //    string sql = "Insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih) values (@KullaniciID, @PersonelID, @Donem, @PrimTutari, @Aciklama, @Tarih)";
                //    SqlCommand cmd = new SqlCommand(sql);
                //    cmd.Parameters.AddWithValue("@KullaniciID", p.KullaniciID);
                //    cmd.Parameters.AddWithValue("@PersonelID", p.PersonelID);
                //    cmd.Parameters.AddWithValue("@Donem", p.Donem);
                //    cmd.Parameters.AddWithValue("@PrimTutari", p.PrimTutari);
                //    cmd.Parameters.AddWithValue("@Aciklama", p.Aciklama);
                //    cmd.Parameters.AddWithValue("@Tarih", p.Tarih);

                //    Veritabanı.ESG(cmd, sql);
                //    MessageBox.Show("İşlem Başarılı Personele Prim Eklendi", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    btnTemizle.PerformClick();
                //}
                //else if (radioTumPersoneller.Checked)
                //{
                //    if (string.IsNullOrWhiteSpace(txtPrimTutari.Text) || !decimal.TryParse(txtPrimTutari.Text, out decimal primTutari))
                //    {
                //        MessageBox.Show("Lütfen geçerli bir Prim Tutarı giriniz.", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }
                //    Primler p = new Primler
                //    {
                //        KullaniciID = Kullanicilar.kid,
                //        Donem = comboYil.Text + "/" + comboAy.Text,
                //        PrimTutari = (int)primTutari,
                //        Aciklama = txtAciklama.Text,
                //        Tarih = DateTime.Now
                //    };

                //    string sql = "Insert into Primler(KullaniciID,Donem,PrimTutari,Aciklama,Tarih) values (@KullaniciID, @Donem, @PrimTutari, @Aciklama, @Tarih)";
                //    SqlCommand cmd = new SqlCommand(sql);
                //    cmd.Parameters.AddWithValue("@KullaniciID", p.KullaniciID);
                //    cmd.Parameters.AddWithValue("@Donem", p.Donem);
                //    cmd.Parameters.AddWithValue("@PrimTutari", p.PrimTutari);
                //    cmd.Parameters.AddWithValue("@Aciklama", p.Aciklama);
                //    cmd.Parameters.AddWithValue("@Tarih", p.Tarih);

                //    Veritabanı.ESG(cmd, sql);
                //    MessageBox.Show("İşlem Başarılı Tüm Personele Prim Eklendi", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    btnTemizle.PerformClick();
                //}
                //else
                //{
                //    MessageBox.Show("Lütfen Bir Seçim Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnPersoneleGörePrim_Click(object sender, EventArgs e)
        {
            frmPersoneleGorePrimler frm = new frmPersoneleGorePrimler();
            frm.txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[0] != null)
            {
                Veritabanı.Listele_Ara(frm.dataGridView1, "Select * from Primler where PersonelID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else if (!string.IsNullOrEmpty(txtPersonelID.Text))
            {
                Veritabanı.Listele_Ara(frm.dataGridView1, "Select * from Primler where PersonelID=" + txtPersonelID.Text);
            }
            else
            {
                // İstenilen durumları ele almak için uygun bir işlem yapılabilir.
            }
            frm.ShowDialog();
        }
        private void radioKisiyeOzel_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is ComboBox)
                {
                    item.Text = string.Empty;
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
        }
        private void btnPrimListele_Click(object sender, EventArgs e)
        {

        }
        private void radioTumPersoneller_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKisiyeOzel.Checked)
            {
                // radioKisiyeOzel seçili olduğunda yapılacak işlemler
                txtPersonelID.Enabled = true; // Personel ID alanını etkinleştir
            }
            else if (radioTumPersoneller.Checked)
            {
                // radioTumPersoneller seçili olduğunda yapılacak işlemler
                txtPersonelID.Enabled = false; // Personel ID alanını devre dışı bırak
                txtPersonelID.Text = string.Empty; // Personel ID alanını temizle
            }
        }

        private void txtPrimTutari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
