using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_takip_1
{
    internal class Primler
    {
        #region Kapsulleme
        private int _PrimID;
        private int _PersonelID;
        private int _KullaniciID;
        private string _Donem;
        private string _Odenmedurumu;
        private decimal _PrimTutari;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Islem;


        public int PrimID { get => _PrimID; set => _PrimID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string Odenmedurumu { get => _Odenmedurumu; set => _Odenmedurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public decimal PrimTutari { get => _PrimTutari; set => _PrimTutari = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        #endregion

        public static SqlDataReader PersonelAdSoyadGetir(TextBox txtPersonelID, TextBox txtAdSoyad)
        {
            Veritabanı.baglantı.Open();
            SqlCommand cmd = new SqlCommand("Select Adi, Soyadi from Personeller where PersonelID=@PersonelID", Veritabanı.baglantı);
            cmd.Parameters.AddWithValue("@PersonelID", txtPersonelID.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAdSoyad.Text = dr["Adi"].ToString() + " " + dr["Soyadi"].ToString();
            }
            Veritabanı.baglantı.Close();
            return dr;
        }
    }
}
