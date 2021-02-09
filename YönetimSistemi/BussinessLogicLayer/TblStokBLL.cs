using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YönetimSistemi.DataAccessObjectLayer;
using YönetimSistemi.PocosLayer;
using System.Data;

namespace YönetimSistemi.BussinessLogicLayer
{
    class TblStokBLL
    {
        private TblStokDAO tblStokDAO;


        public TblStokBLL()
        {
            tblStokDAO = new TblStokDAO();

        }


        public TblStokPoco stokKaydet(int ürünId, string ürünAdi, int ürünAdet)
        {
            TblStokPoco tblStokPoco = new TblStokPoco();
            DataTable dataTable = new DataTable();


            tblStokDAO.insertStok(ürünId,ürünAdi,ürünAdet);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = tblStokPoco.UrunID;
                dr["ürünAdı"] = tblStokPoco.UrunAdi;
                dr["ürünAdet"] = tblStokPoco.urunAdet;
            

            }

            return tblStokPoco;

        }


        public TblStokPoco stokguncelle(int ürünId, string ürünAdi, int ürünAdet)
        {
            TblStokPoco tblStokPoco = new TblStokPoco();
            DataTable dataTable = new DataTable();

            tblStokDAO.updateKullanici(ürünId,ürünAdi,ürünAdet);

            foreach (DataRow dr in dataTable.Rows)
            {

              

                dr["ürünAdı"] = tblStokPoco.UrunAdi;
                dr["ürünAdet"] = tblStokPoco.urunAdet;

            }

            return tblStokPoco;
        }


        public TblKullanicilarPoco silStok(string kullaniciİd)
        {
            TblKullanicilarPoco tblKullanicilarPoco = new TblKullanicilarPoco();

            DataTable dataTable = new DataTable();

            tblStokDAO.deleteStok(kullaniciİd);
            return tblKullanicilarPoco;
        }
    }
}
