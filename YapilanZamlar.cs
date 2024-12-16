using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_takip_1
{
    internal class YapilanZamlar
    {
        #region Zamlar Kısmı        
        private int _ZamID;
        private string _Donem;
        private string _Personel;
        private decimal _Yuzde;
        private decimal _Fiyat;
        private string _Aciklama;
        private DateTime _Tarih;

        public int ZamID { get => _ZamID; set => _ZamID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string Personel { get => _Personel; set => _Personel = value; }
        public decimal Yuzde { get => _Yuzde; set => _Yuzde = value; }
        public decimal Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        #endregion

        //public static SqlDataReader ComboyaPersonelGetir(ComboBox cmb)
        //{
        //    Veritabanı.baglantı.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT PersonelID, Adi + Soyadi AS AdSoyad FROM Personeller", Veritabanı.baglantı);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        cmb.Items.Add(dr[0] + "." + dr[1]);
        //    }
        //    Veritabanı.baglantı.Close();

        //    return dr;
        //}
        

        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabanı.baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Departmanlar", Veritabanı.baglantı);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID";
            combo.DisplayMember = "Departman";
            Veritabanı.baglantı.Close();
            return tbl;
        }
        public void DepartmanSecildiktenSonraPersonelGetir(ComboBox comboDepartman, ComboBox comboPersonel)
        {
            comboDepartman.SelectedIndexChanged += (sender, e) =>
            {
                // Seçilen departmanın ID'sini al
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
                    comboPersonel.Items.Add(dr[0] + "." + dr[1]);
                }

                // Veritabanı bağlantısını kapat
                Veritabanı.baglantı.Close();
            };
        }
    }
 }

   
