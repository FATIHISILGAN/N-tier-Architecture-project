using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YönetimSistemi.DataAccessObjectLayer;
using YönetimSistemi.PocosLayer;
using System.Data;
using YönetimSistemi.PresantationLayer.kullanicilar;
using YönetimSistemi.PresantationLayer;

//iş mantık katmanı

namespace YönetimSistemi.BussinessLogicLayer
{
    class TblKullanicilarBLL
    {
        private TblKullanicilarDAO tblKullanicilarDAO;



        public TblKullanicilarBLL()
        {
            tblKullanicilarDAO = new TblKullanicilarDAO();

        }

        public TblKullanicilarPoco getSorgu(string kullaniciAdi,string sifre)         
        {
            TblKullanicilarPoco kullaniciGirisi = new TblKullanicilarPoco();

            DataTable dataTable = new DataTable();
            dataTable = tblKullanicilarDAO.SearchKullaniciAdiveSifre(kullaniciAdi,sifre);


            foreach (DataRow dr in dataTable.Rows)
            {
                kullaniciGirisi.kullaniciAdi = dr["kullanıcıAdı"].ToString();
                kullaniciGirisi.kullaniciPassword = dr["parola"].ToString();

            }


            return kullaniciGirisi;
        }

        public TblKullanicilarPoco kullaniciKaydet(int kullaniciId, string kullaniciAdi, string parola, string adSoyad, string email, string cinsiyet, string telno1, string telno2)
        {
            TblKullanicilarPoco tblKullanicilarPoco = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();


            tblKullanicilarDAO.insertkullanici(kullaniciId, kullaniciAdi, parola, adSoyad, email, cinsiyet, telno1, telno2);

            foreach(DataRow dr in dataTable.Rows)
            {
                dr["id"] = tblKullanicilarPoco.kullaniciID;
                dr["kullanıcıAdı"] = tblKullanicilarPoco.kullaniciAdi;
                dr["parola"] = tblKullanicilarPoco.kullaniciPassword;
                dr["adSoyad"] = tblKullanicilarPoco.kullaniciadsoyad;
                dr["email"] = tblKullanicilarPoco.kullaniciMail;
                dr["cinsiyet"] = tblKullanicilarPoco.kullaniciCinsiyet;
                dr["telno1"] = tblKullanicilarPoco.kullaniciTelno1;
                dr["telno2"] = tblKullanicilarPoco.kullaniciTelno2;






            }

            return tblKullanicilarPoco;

        }

        public TblKullanicilarPoco kullaniciguncelle(int kullaniciId, string kullaniciAdi, string parola, string adSoyad, string email, string cinsiyet, string telno1, string telno2)
        {
            TblKullanicilarPoco tblKullanicilarPoco = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            tblKullanicilarDAO.updateKullanici(kullaniciId, kullaniciAdi, parola, adSoyad, email, cinsiyet, telno1, telno2);

            foreach (DataRow dr in dataTable.Rows)
            {
               
                dr["kullanıcıAdı"] = tblKullanicilarPoco.kullaniciAdi;
                dr["parola"] = tblKullanicilarPoco.kullaniciPassword;
                dr["adSoyad"] = tblKullanicilarPoco.kullaniciadsoyad;
                dr["email"] = tblKullanicilarPoco.kullaniciMail;
                dr["cinsiyet"] = tblKullanicilarPoco.kullaniciCinsiyet;
                dr["telno1"] = tblKullanicilarPoco.kullaniciTelno1;
                dr["telno2"] = tblKullanicilarPoco.kullaniciTelno2;
            }

            return tblKullanicilarPoco;
        }
        public TblKullanicilarPoco silKullanici(string kullaniciİd)
        {
            TblKullanicilarPoco tblKullanicilarPoco = new TblKullanicilarPoco();

            DataTable dataTable = new DataTable();

            tblKullanicilarDAO.deleteKullanici(kullaniciİd);
            return tblKullanicilarPoco;
        }
    }

   
}
