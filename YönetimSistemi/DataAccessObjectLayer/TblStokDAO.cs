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

    class TblStokDAO
    {

        private VtBağlanti bağlanti;

        public TblStokDAO()
        {

            bağlanti = new VtBağlanti();
        }

        public bool insertStok(int stokId, string ürünAdi, int ürünAdet)
        {
            string sorgu = string.Format("insert into Stok(id,ürünAdı,ürünAdet) values(@stokId,@ürünAdi,@ürünAdet)");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@stokId", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(stokId);

            sqlParameters[1] = new SqlParameter("@ürünAdi", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(ürünAdi);

            sqlParameters[2] = new SqlParameter("@ürünAdet", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(ürünAdet);



            return bağlanti.exucuteInsertQuery(sorgu, sqlParameters);


        }



        public bool updateKullanici(int stokId, string ürünAdi, int ürünAdet)
        {

            string sorgu = string.Format("update Stok set ürünAdı=@ürünAdi, ürünAdet=@ürünAdet " +
                "where id = '" + stokId + "'");



            SqlParameter[] sqlParameters = new SqlParameter[2];


            sqlParameters[0] = new SqlParameter("@ürünAdi", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(ürünAdi);

            sqlParameters[1] = new SqlParameter("@ürünAdet", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(ürünAdet);





            return bağlanti.exucuteUpdateQuery(sorgu, sqlParameters);



        }


        public bool deleteStok(string stokİd)
        {

            string sorgu = string.Format("delete from Stok where id='" + stokİd + "'");


            return bağlanti.exucuteDeleteQuery(sorgu);
        }
    }
}
