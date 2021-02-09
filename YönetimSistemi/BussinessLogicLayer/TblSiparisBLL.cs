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
    class TblSiparisBLL
    {
        private TblSiparisDAO tblSiparisDAO;

        public TblSiparisBLL()
        {
            tblSiparisDAO = new TblSiparisDAO();
        }


        public TblSiparisPoco siparisKaydet(int Id, int ürünİd, int siparisVerenKullaniciİd, string ürünAdi,int siparisAdet )
        {
            TblSiparisPoco tblSiparisPoco = new TblSiparisPoco();
            DataTable dataTable = new DataTable();


            tblSiparisDAO.insertSiparis(Id, ürünİd, siparisVerenKullaniciİd,ürünAdi,siparisAdet);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["İd"] = tblSiparisPoco.UrunID;
                dr["ürünİd"] = tblSiparisPoco.Urunİd;
                dr["siparisiVerenKullaniciİd"] = tblSiparisPoco.siparisVerenKullaniciİd;
                dr["ürünAdı"] = tblSiparisPoco.ürünAdi;
                dr["siparisAdet"] = tblSiparisPoco.siparisAdet;





            }

            return tblSiparisPoco;

        }



        public TblSiparisPoco siparisguncelle(int Id, int ürünİd, int siparisVerenKullaniciİd, string ürünAdi, int siparisAdet)
        {
            TblSiparisPoco tblSiparisPoco = new TblSiparisPoco();
            DataTable dataTable = new DataTable();

            tblSiparisDAO.updateSiparis(Id, ürünİd, siparisVerenKullaniciİd,ürünAdi,siparisAdet);

            foreach (DataRow dr in dataTable.Rows)
            {



                dr["ürünİd"] = tblSiparisPoco.Urunİd;
                dr["siparisiVerenKullaniciİd"] = tblSiparisPoco.siparisVerenKullaniciİd;
                dr["ürünAdı"] = tblSiparisPoco.ürünAdi;
                dr["siparisAdet"] = tblSiparisPoco.siparisAdet;


            }

            return tblSiparisPoco;
        }



        public TblSiparisPoco silSiparis(string id)
        {
            TblSiparisPoco tblSiparisPoco = new TblSiparisPoco();

            DataTable dataTable = new DataTable();

            tblSiparisDAO.deleteSiparis(id);
            return tblSiparisPoco;
        }

    }
}
