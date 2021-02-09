using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YönetimSistemi.PocosLayer
{
    class TblSiparisPoco
    {

        public TblSiparisPoco()
        {
            Console.WriteLine("Siparis poco yüklendi");
        }

        private int ID_ { get; set; }

        private int Urunİd_ { get; set; }

        private int siparisiVerenKullaniciİd_ { get; set; }

        private string  ürünAdı_ { get; set; }

        private int siparisAdet_ { get; set; }




     


        public int UrunID
        {
            get
            {
                return ID_;
            }
            set
            {
                ID_ = value;
            }
        }



        public int Urunİd
        {
            get
            {
                return Urunİd_;
            }
            set
            {
                Urunİd_ = value;
            }
        }


        public int siparisVerenKullaniciİd
        {
            get
            {
                return siparisiVerenKullaniciİd_;
            }
            set
            {
                siparisiVerenKullaniciİd_ = value;
            }
        }


        public string ürünAdi
        {
            get
            {
                return ürünAdı_;
            }
            set
            {
                ürünAdı_ = value;
            }
        }


        public int siparisAdet
        {
            get
            {
                return siparisAdet_;
            }
            set
            {
                siparisAdet_ = value;
            }
        }
    }
}
