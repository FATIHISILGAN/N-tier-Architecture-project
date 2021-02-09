using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YönetimSistemi.PocosLayer
{
    class TblStokPoco
    {

        private int ID_ { get; set; }

        private string  UrunAdi_ { get; set; }

        private int UrunAdet_ { get; set; }


        public TblStokPoco()
        {

        }


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



        public string UrunAdi
        {
            get
            {
                return UrunAdi_;
            }
            set
            {
                UrunAdi_ = value;
            }
        }



        public  int urunAdet
        {
            get
            {
                return UrunAdet_;
            }
            set
            {
                UrunAdet_ = value;
            }
        }



    }
}
