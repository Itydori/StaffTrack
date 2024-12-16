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
    public partial class frmYapilanZamlar : Form
    {
        private int selectedYear;
        private int selectedDepartmentID;
        private int selectedPersonelID;

        public frmYapilanZamlar()
        {
            InitializeComponent();
            selectedYear = DateTime.Now.Year;
            selectedDepartmentID = 0;
            selectedPersonelID = 0;

            comboPersoneller.SelectedIndex = 0; // Select the first item by default
            radioFiyat.Checked = true; // Set "Fiyat" radio button as checked initially

            // Load years in the combo box
            for (int i = selectedYear; i >= (selectedYear - 5); i--)
            {
                comboYil.Items.Add(i.ToString());
            }

            // Load departments in the combo box (assuming YapilanZamlar.ComboyaDepartmanGetir exists)
            YapilanZamlar.ComboyaDepartmanGetir(comboDepartman);
        }
        private void DepartmanlariYukle()
        {
            Veritabanı.baglantı.Open();
            SqlCommand cmd = new SqlCommand("SELECT DepartmanID, Departman FROM Departmanlar", Veritabanı.baglantı);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboDepartman.DataSource = dt;
            comboDepartman.DisplayMember = "Departman";
            comboDepartman.ValueMember = "DepartmanID";
            Veritabanı.baglantı.Close();
        }
        private void Temizle()
        {
            // ComboBox kontrollerini temizle
            comboDepartman.SelectedIndex = -1;
            comboPersoneller.Items.Clear();
            comboDepartman.SelectedIndex = -1;

            // Label kontrollerini temizle
            lblPersonelID.Text = string.Empty;
            lblDepartmanID.Text = string.Empty;
        }
        private void frmYapilanZamlar_Load(object sender, EventArgs e)
        {
            DepartmanlariYukle();
            DepartmanSecildiktenSonraPersonelGetir(comboDepartman, comboPersoneller);
        }
        public void DepartmanSecildiktenSonraPersonelGetir(ComboBox comboDepartman, ComboBox comboPersonel)
        {
            comboDepartman.SelectedIndexChanged += (sender, e) =>
            {
                if (comboDepartman.SelectedValue != null)
                {
                    int selectedDepartmanID = (int)comboDepartman.SelectedValue;

                    // Personel ComboBox'ını temizle
                    comboPersonel.Items.Clear();

                    // Veritabanı bağlantısını aç
                    Veritabanı.baglantı.Open();

                    // Seçilen departmana göre personelleri getir
                    SqlCommand cmd = new SqlCommand("SELECT PersonelID, Adi + Soyadi AS AdSoyad FROM Personeller WHERE DepartmanID = @DepartmanID", Veritabanı.baglantı);
                    cmd.Parameters.AddWithValue("@DepartmanID", selectedDepartmanID);
                    SqlDataReader dr = cmd.ExecuteReader();

                    // Personelleri ComboBox'a ekle
                    while (dr.Read())
                    {
                        comboPersonel.Items.Add(new { PersonelID = dr[0], AdSoyad = dr[1] });
                    }

                    // Veritabanı bağlantısını kapat
                    Veritabanı.baglantı.Close();
                }
                else
                {
                    // Handle the case where SelectedValue is null
                    MessageBox.Show("Lütfen geçerli bir departman seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // comboPersonel'in SelectedIndexChanged olayını bağla
            comboPersonel.SelectedIndexChanged += (sender, e) =>
            {
                if (comboPersonel.SelectedItem != null)
                {
                    var selectedPersonel = (dynamic)comboPersonel.SelectedItem;
                    if (selectedPersonel != null)
                    {
                        lblPersonelID.Text = selectedPersonel.PersonelID.ToString();
                    }
                }
            };
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            YapilanZamlar y =new YapilanZamlar();
            y.Personel= comboPersoneller.Text;
            y.Donem = comboAy.Text + "/" + comboYil.Text;
            y.Aciklama = txtAciklama.Text;
            y.Tarih = DateTime.Now;
            if (comboYil.SelectedIndex == -1 || comboAy.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen geçerli bir yıl ve ay seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioYuzde.Checked)
            {
                y.Yuzde = decimal.Parse(txtYuzde.Text);

                if (decimal.TryParse(txtYuzde.Text, out decimal yuzde))
                {
                    SqlCommand cmd = new SqlCommand();
                    string sql;

                    if (comboDepartman.SelectedIndex == -1)
                    {
                        sql = "update Personeller set Maasi=Maasi+(Maasi * @yuzde)/100";
                        cmd.Parameters.AddWithValue("@yuzde", yuzde);
                        Veritabanı.ESG(cmd, sql);
                        MessageBox.Show("Tüm Personellerin maaşına zam yapıldı: " +   y.Yuzde + "%", "Maas Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comboDepartman.SelectedIndex != 0 && comboPersoneller.SelectedIndex == -1)
                    {
                        sql = "update Personeller set Maasi=Maasi+(Maasi * @yuzde)/100 where DepartmanID=@departmanID";
                        cmd.Parameters.AddWithValue("@yuzde", yuzde);
                        cmd.Parameters.AddWithValue("@departmanID", Convert.ToInt32(comboDepartman.SelectedValue));
                        Veritabanı.ESG(cmd, sql);
                        MessageBox.Show("Tüm Departman çalışanlarının maaşına zam yapıldı: " + y.Yuzde + "%", "Maas Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comboPersoneller.SelectedIndex != -1)
                    {
                        if (int.TryParse(lblPersonelID.Text, out int personelID))
                        {
                            sql = "update Personeller set Maasi=Maasi+(Maasi * @yuzde)/100 where PersonelID=@personelID";
                            cmd.Parameters.AddWithValue("@yuzde", yuzde);
                            cmd.Parameters.AddWithValue("@personelID", personelID);
                            Veritabanı.ESG(cmd, sql);
                            MessageBox.Show("Seçili Personelin maaşına zam yapıldı: " + y.Yuzde + "%", "Maas Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();

                        }
                    }
                    String sql2 = "insert into YapilanZamlar(KullaniciID,Donem,Personeller,Yuzde,Aciklama,Tarih) values ('"+k.KullaniciID+"','"+y.Donem+"','"+y.Personel+"',@Yuzde,'"+y.Aciklama+"',@Tarih)";
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Parameters.AddWithValue("@Yuzde",SqlDbType.Decimal).Value=y.Yuzde;
                    cmd2.Parameters.AddWithValue("@Tarih", SqlDbType.DateTime).Value = y.Tarih;
                    Veritabanı.ESG(cmd2, sql2);
                }
                
            }
            if (radioFiyat.Checked)
            {
                y.Fiyat = decimal.Parse(txtFiyat.Text);

                if (decimal.TryParse(txtFiyat.Text, out decimal fiyat))
                {
                    SqlCommand cmd = new SqlCommand();
                    string sql;

                    if (comboDepartman.SelectedIndex == -1)
                    {
                        sql = "update Personeller set Maasi=Maasi+@fiyat";
                        cmd.Parameters.AddWithValue("@fiyat", y.Fiyat);
                        Veritabanı.ESG(cmd, sql);
                        MessageBox.Show("Tüm Personellerin maaşına zam yapıldı: " + y.Fiyat + " TL", "Maas Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comboDepartman.SelectedIndex != 0 && comboPersoneller.SelectedIndex == -1)
                    {
                        sql = "update Personeller set Maasi=Maasi+@fiyat where DepartmanID=@departmanID";
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@departmanID", Convert.ToInt32(comboDepartman.SelectedValue));
                        Veritabanı.ESG(cmd, sql);
                        MessageBox.Show("Tüm Departman çalışanlarının maaşına zam yapıldı: " + y.Fiyat + " TL", "Maas Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comboPersoneller.SelectedIndex != -1)
                    {
                        if (int.TryParse(lblPersonelID.Text, out int personelID))
                        {
                            sql = "update Personeller set Maasi=Maasi+@fiyat where PersonelID=@personelID";
                            cmd.Parameters.AddWithValue("@fiyat", fiyat);
                            cmd.Parameters.AddWithValue("@personelID", personelID);
                            Veritabanı.ESG(cmd, sql);
                            MessageBox.Show("Seçili Personelin maaşına zam yapıldı: " + fiyat + " TL", "Maas Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz Personel ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                String sql2 = "insert into YapilanZamlar(KullaniciID,Donem,Personeller,Fiyat,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + y.Donem + "','" + y.Personel + "',@Fiyat,'" + y.Aciklama + "',@Tarih)";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Parameters.AddWithValue("@Yuzde", SqlDbType.Decimal).Value = y.Yuzde;
                cmd2.Parameters.AddWithValue("@Tarih", SqlDbType.DateTime).Value = y.Tarih;
                Veritabanı.ESG(cmd2, sql2);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Handle any actions associated with label7 click (if needed)
        }

        private void radioFiyat_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = true;
            txtYuzde.Enabled = false;
        }

        private void radioYuzde_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = false;
            txtYuzde.Enabled = true;
        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPersoneller.SelectedIndex == 0) // "Tüm Personeller" selected
            {
                lblPersonelID.Text = "0";
                selectedPersonelID = 0;
                return;
            }

            // Seçilen personelin ID'sini al
            var selectedPersonel = comboPersoneller.SelectedItem as Personeller;
            if (selectedPersonel != null)
            {
                selectedPersonelID = selectedPersonel.PersonelID;
                lblPersonelID.Text = selectedPersonelID.ToString();
            }
        }



        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDepartman.SelectedIndex == 0) // "Tüm Departmanlar" selected
            {
                lblDepartmanID.Text = "0";
                selectedDepartmentID = 0;
                return;
            }
            var selectedDepartman = comboDepartman.SelectedItem as Departmanlar;
            if (selectedDepartman != null)
            {
                selectedDepartmentID = selectedDepartman.DepartmanID;
                lblDepartmanID.Text = selectedDepartmentID.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Formu gizle
            frmYapilanZamlar newForm = new frmYapilanZamlar(); // Yeni bir form oluştur
            newForm.ShowDialog(); // Yeni formu göster
            this.Close(); // Eski formu kapat
        }

        // Formun InitializeComponent metodunda butonun Click olayını bağlayın
       
    }
    public class Departman
    {
        public int DepartmanID { get; set; }
        public string Ad { get; set; }
    }

    public class Personel
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
    }
}