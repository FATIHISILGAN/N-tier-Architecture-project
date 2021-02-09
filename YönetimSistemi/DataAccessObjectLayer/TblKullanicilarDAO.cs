using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using YönetimSistemi.vtBağlanti;
using System.Data.SqlClient;
//veri erişim katmanı


namespace YönetimSistemi.DataAccessObjectLayer
{
    class TblKullanicilarDAO
    {
        private VtBağlanti bağlanti;

        public TblKullanicilarDAO(){

            bağlanti = new VtBağlanti();
        }


        public DataTable SearchKullaniciAdiveSifre(string kullaniciAdi,string sifre)
        {
            string sorgu = string.Format("select *from kullanıcılar where  kullanıcıAdı =@kullaniciAdi and  parola = @sifre");

            SqlParameter[] sqlParemeters = new SqlParameter[2];
            sqlParemeters[0] = new SqlParameter("@kullaniciAdi",SqlDbType.NVarChar);
            sqlParemeters[0].Value = Convert.ToString(kullaniciAdi);
            sqlParemeters[1] = new SqlParameter("@sifre", SqlDbType.NVarChar);
            sqlParemeters[1].Value = Convert.ToString(sifre);


            return bağlanti.exucuteSelectQuery(sorgu,sqlParemeters);   
        }

        public bool insertkullanici(int kullaniciId,string kullaniciAdi,string parola , string adSoyad,string email,string cinsiyet,string telno1,string telno2)
        {
            string sorgu = string.Format("insert into kullanıcılar(id,kullanıcıAdı,parola,adSoyad,email,cinsiyet,telno1,telno2) values(@kullaniciID,@kullaniciAdi,@parola,@adSoyad,@email,@cinsiyet,@telno1,@telno2)");

            SqlParameter[] sqlParameters = new SqlParameter[8];

            sqlParameters[0] = new SqlParameter("@kullaniciID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(kullaniciId);

            sqlParameters[1] = new SqlParameter("@kullaniciAdi", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(kullaniciAdi);

            sqlParameters[2] = new SqlParameter("@parola", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(parola);


            sqlParameters[3] = new SqlParameter("@adSoyad", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(adSoyad);

            sqlParameters[4] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(email);




            sqlParameters[5] = new SqlParameter("@cinsiyet", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(cinsiyet);




            sqlParameters[6] = new SqlParameter("@telno1", SqlDbType.VarChar);
            sqlParameters[6].Value = Convert.ToString(telno1);


            sqlParameters[7] = new SqlParameter("@telno2", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(telno2);


            return bağlanti.exucuteInsertQuery(sorgu, sqlParameters);


        }

        public bool updateKullanici(int kullaniciId, string kullaniciAdi, string parola, string adSoyad, string email, string cinsiyet, string telno1, string telno2)
        {

            string sorgu = string.Format("update kullanıcılar set kullanıcıAdı = @kullaniciAdi , parola =@parola , adSoyad=@adSoyad, email =@email, cinsiyet=@cinsiyet, telno1=@telno1, telno2=@telno2 " + 
                
                "where id ="+kullaniciId);



            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@kullaniciAdi", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciAdi);

            sqlParameters[1] = new SqlParameter("@parola", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(parola);


            sqlParameters[2] = new SqlParameter("@adSoyad", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(adSoyad);

            sqlParameters[3] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(email);




            sqlParameters[4] = new SqlParameter("@cinsiyet", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(cinsiyet);




            sqlParameters[5] = new SqlParameter("@telno1", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(telno1);


            sqlParameters[6] = new SqlParameter("@telno2", SqlDbType.VarChar);
            sqlParameters[6].Value = Convert.ToString(telno2);


            return bağlanti.exucuteUpdateQuery(sorgu, sqlParameters);



        }

        public bool deleteKullanici(string kullaniciİd)
        {

            string sorgu = string.Format("delete from kullanıcılar where id='"+kullaniciİd+"'");


            return bağlanti.exucuteDeleteQuery(sorgu);
        }
    }
}
