using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using YönetimSistemi.vtBağlanti;
using System.Data.SqlClient;


namespace YönetimSistemi.DataAccessObjectLayer
{
    class TblSiparisDAO
    {

        private VtBağlanti bağlanti;

        public TblSiparisDAO()
        {

            bağlanti = new VtBağlanti();
        }




        public bool insertSiparis(int Id, int ürünİd, int siparisVerenKullaniciİd, string ürünAdi, int siparisAdet)
        {
            string sorgu = string.Format("insert into Siparis(id,ürünİd,siparisiVerenKullaniciİd,ürünAdı,siparisAdet) values(@Id,@ürünİd,@siparisVerenKullaniciİd,@ürünAdi,@siparisAdet)");

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(Id);

            sqlParameters[1] = new SqlParameter("@ürünİd", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(ürünİd);

            sqlParameters[2] = new SqlParameter("@siparisVerenKullaniciİd", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(siparisVerenKullaniciİd);

            sqlParameters[3] = new SqlParameter("@ürünAdi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ürünAdi);

            sqlParameters[4] = new SqlParameter("@siparisAdet", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(siparisAdet);

            return bağlanti.exucuteInsertQuery(sorgu, sqlParameters);


        }




        public bool updateSiparis(int Id, int ürünİd, int siparisVerenKullaniciİd, string ürünAdi, int siparisAdet)
        {

            string sorgu = string.Format("Update Siparis set ürünİd = @Ürünİd, siparisiVerenKullaniciİd = @siparisVerenKullaniciİd, ürünAdı = @ürünAdi, " +
                "siparisAdet = @siparisAdet where id = '" + Id + "'");


            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@ürünİd", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(ürünİd);

            sqlParameters[1] = new SqlParameter("@siparisVerenKullaniciİd", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(siparisVerenKullaniciİd);

            sqlParameters[2] = new SqlParameter("@ürünAdi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ürünAdi);

            sqlParameters[3] = new SqlParameter("@siparisAdet", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(siparisAdet);





            return bağlanti.exucuteUpdateQuery(sorgu, sqlParameters);



        }



        public bool deleteSiparis(string siparisİd)
        {

            string sorgu = string.Format("delete from Siparis where id='" + siparisİd + "'");


            return bağlanti.exucuteDeleteQuery(sorgu);
        }
    }
}
