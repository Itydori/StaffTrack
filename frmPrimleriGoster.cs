using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_takip_1
{
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGoster_Load(object sender, EventArgs e)
        {
            Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string[] donem = dataGridView1.CurrentRow.Cells[3].Value.ToString().Split('/');
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrimTutari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (donem.Length > 1)
            {
                comboAy.Text = donem[1];
                comboYil.Text = donem[0];
            }
            else
            {
                comboAy.Text = string.Empty;
                comboYil.Text = string.Empty;
            }
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            Primler p = new Primler
            {
                PrimID = int.Parse(txtPrimID.Text),
                Donem = comboYil.Text + "/" + comboAy.Text
            };
            p.Islem= "Dönem Değiştirme"; // Ensure this is set correctly
            SqlCommand cmd = new SqlCommand("Update Primler set Donem=@Donem where PrimID=@PrimID", Veritabanı.baglantı);
            Veritabanı.baglantı.Open();
            cmd.Parameters.AddWithValue("@Donem", p.Donem);
            cmd.Parameters.AddWithValue("@PrimID", p.PrimID);
            cmd.ExecuteNonQuery();
            Veritabanı.baglantı.Close();
            Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
            if (!string.IsNullOrEmpty(comboAy.Text) && !string.IsNullOrEmpty(comboYil.Text))
            {
                DialogResult result = MessageBox.Show("Dönem bilgisi girildi. Emin misiniz?", "Dönem Kontrolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            MessageBox.Show("İşlem Başarılı", "Dönem Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();

            // Prim hareketlerine kaydetme işlemi
            string sql3 = "Insert into PrimHareketleri(KullaniciID, PersonelID, PrimID, Islem, Tarih) values (@KullaniciID, @PersonelID, @PrimID, @Islem, @Tarih)";
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            SqlCommand cmd3 = new SqlCommand(sql3);
            cmd3.Parameters.AddWithValue("@KullaniciID", Kullanicilar.kid);
            cmd3.Parameters.AddWithValue("@PersonelID", int.Parse(txtPersonelID.Text));
            cmd3.Parameters.AddWithValue("@PrimID", int.Parse(txtPrimID.Text));
            cmd3.Parameters.AddWithValue("@Islem", "Dönem Değiştirme");
            cmd3.Parameters.AddWithValue("@Tarih", DateTime.Now);
            Veritabanı.ESG(cmd3, sql3);
        }

        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            string sql = "Update Primler set OdenmeDurumu='Odendi' where OdenmeDurumu = 'Odenmedi'";
            SqlCommand cmd = new SqlCommand(sql);
            Veritabanı.ESG(cmd, sql);

            string sql2 = "Insert into PrimHareketleri (KullaniciID, PersonelID, PrimID, Islem, Tarih) values (@KullaniciID, @PersonelID, @PrimID, @Islem, @Tarih)";
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["OdenmeDurumu"] != null && row.Cells["OdenmeDurumu"].Value != null && row.Cells["OdenmeDurumu"].Value.ToString() == "Odenmedi")
                {
                    // Your code here
                
                    int personelID = int.Parse(row.Cells["PersonelID"].Value.ToString());
                    int primID = int.Parse(row.Cells["PrimID"].Value.ToString());
                    string aciklama = "Toplu prim ödenmeyen primlerin ödenmesi";
                    string islem = "Toplu prim ödeme";
                    DateTime tarih = DateTime.Now;

                    SqlCommand cmd2 = new SqlCommand(sql2);
                    cmd2.Parameters.AddWithValue("@KullaniciID", k.KullaniciID);
                    cmd2.Parameters.AddWithValue("@PersonelID", personelID);
                    cmd2.Parameters.AddWithValue("@PrimID", primID);
                    cmd2.Parameters.AddWithValue("@Islem", islem);
                    cmd2.Parameters.AddWithValue("@Tarih", tarih);
                    Veritabanı.ESG(cmd2, sql2);
                }
            }

            Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
            MessageBox.Show("İşlem Başarılı Ödenmeyen Tüm Primler Ödendi", "Prim Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler primler = new Primler
            {
                Tarih = DateTime.Now,
                PersonelID = int.Parse(txtPersonelID.Text),
                Aciklama = (txtAciklama.Text),
                Islem = txtPersonelID.Text + " No'lu personel " + txtPersonelAdSoyad.Text + " için ödeme yapıldı",
                PrimID = int.Parse(txtPrimID.Text),
                Odenmedurumu = "Odendi"
            };
            primler.Islem = "Prim Ödeme"; // Ensure this is set correctly
            string sql = "Update Primler set OdenmeDurumu=@Odenmedurumu where PrimID=@PrimID";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@OdenmeDurumu", primler.Odenmedurumu);
            cmd.Parameters.AddWithValue("@PrimID", primler.PrimID);

            Veritabanı.ESG(cmd, sql);
            string sql2 = "Insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Tarih) values (@KullaniciID,@PersonelID,@PrimID,@Islem,@Tarih)";
            SqlCommand cmd2 = new SqlCommand(sql2);
            cmd2.Parameters.AddWithValue("@KullaniciID", k.KullaniciID);
            cmd2.Parameters.AddWithValue("@PersonelID", primler.PersonelID);
            cmd2.Parameters.AddWithValue("@PrimID", primler.PrimID);
            cmd2.Parameters.AddWithValue("@Tarih", primler.Tarih);
            cmd2.Parameters.AddWithValue("@Islem", primler.Islem);
            cmd2.Parameters.AddWithValue("@Aciklama", primler.Aciklama);
            //cmd2.Parameters.AddWithValue("@Tarih", primler.Tarih);
            //cmd2.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = DateTime.Now;
            //cmd2.Parameters.Add("@Islem", SqlDbType.NVarChar).Value = primler.Islem;
            //cmd2.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = primler.Aciklama;
            Veritabanı.ESG(cmd2, sql2);


            if (!string.IsNullOrEmpty(comboAy.Text) && !string.IsNullOrEmpty(comboYil.Text))
            {
                DialogResult result = MessageBox.Show("Dönem bilgisi girildi. Emin misiniz?", "Dönem Kontrolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string[] donem = dataGridView1.CurrentRow.Cells[3].Value.ToString().Split('/');
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrimTutari.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (donem.Length > 1)
            {
                comboAy.Text = donem[1];
                comboYil.Text = donem[0];
            }
            else
            {
                comboAy.Text = string.Empty;
                comboYil.Text = string.Empty;
            }
            MessageBox.Show("İşlem Başarılı", "Prim Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
            btnTemizle.PerformClick();
        }

        private void btnTumPrimleriOdenmediYapma_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler p = new Primler
            {
                Odenmedurumu = "Odenmedi"
            };
            string sql = "Update Primler set OdenmeDurumu=@Odenmedurumu where OdenmeDurumu = 'Odendi'";
            SqlCommand cmd = new SqlCommand(sql);
             cmd.Parameters.AddWithValue("@OdenmeDurumu", p.Odenmedurumu); // Bu satırı ekleyin
            Veritabanı.ESG(cmd, sql);
            Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
            MessageBox.Show("İşlem Başarılı", "Prim Ödemelerini İptal Etme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
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
            }
        }

        private void btnPrimiGuncelle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            p.PrimID = int.Parse(txtPrimID.Text);
            p.Islem = "Prim Güncelleme"; // Ensure this is set correctly
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            string sql = "Update Primler set PersonelID=@PersonelID, PrimTutari=@PrimTutari,Aciklama=@Aciklama where PrimID=@PrimID";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@PersonelID", p.PersonelID);
            cmd.Parameters.AddWithValue("@PrimTutari", p.PrimTutari);
            cmd.Parameters.AddWithValue("@Aciklama", p.Aciklama);
            cmd.Parameters.AddWithValue("@PrimID", p.PrimID);

            string sql2 = "Insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Tarih) values (@KullaniciID,@PersonelID,@PrimID,@Islem,@Tarih)";
            SqlCommand cmd2 = new SqlCommand(sql2);
            cmd2.Parameters.AddWithValue("@KullaniciID", k.KullaniciID);
            cmd2.Parameters.AddWithValue("@PersonelID", p.PersonelID);
            cmd2.Parameters.AddWithValue("@PrimID", p.PrimID);
            cmd2.Parameters.AddWithValue("@Tarih", DateTime.Now);
            cmd2.Parameters.AddWithValue("@Islem", p.Islem); // Ensure this is not null

            Veritabanı.ESG(cmd2, sql2);
            Veritabanı.ESG(cmd, sql);
            Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
            MessageBox.Show("İşlem Başarılı Seçili Kaydın Primi Güncellendi", "Prim Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Prim Silinsin mi ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Primler p = new Primler();
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());
                p.Islem = "Prim Silme"; // Ensure this is set correctly
                string sql = "Delete from Primler where PrimID=@PrimID";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@PrimID", p.PrimID);
                string sql2 = "Insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Tarih) values (@KullaniciID,@PersonelID,@PrimID,@Islem,@Tarih)";
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                SqlCommand cmd2 = new SqlCommand(sql2);
                cmd2.Parameters.AddWithValue("@KullaniciID", Kullanicilar.kid);
                cmd2.Parameters.AddWithValue("@PersonelID", int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString()));
                cmd2.Parameters.AddWithValue("@PrimID", p.PrimID);
                cmd2.Parameters.AddWithValue("@Tarih", DateTime.Now);
                cmd2.Parameters.AddWithValue("@Islem", p.Islem); // Ensure this is not null
                Veritabanı.ESG(cmd2, sql2);
                Veritabanı.ESG(cmd, sql);
                Veritabanı.Listele_Ara(dataGridView1, "Select * from Primler");
                MessageBox.Show("İşlem Başarılı Seçili Kayıt Silindi", "Prim Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnTemizle.PerformClick(); 
            }
        }
    }
}
